using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArmoTest
{
    class FileSearcher
    {

        public bool IsSearchPaused { get; set; }
        public bool IsSearchCanseled { get; set; }

        private int filesCount;
        private int filesFound;
        private int filesProcessed;

        private object lockObj = new object();




        List<IFilesDataReceiver> filesDataReceivers;

        public FileSearcher()
        {
            filesDataReceivers = new List<IFilesDataReceiver>();
        }

        private void AddFilesCount(int num)
        {
            lock (lockObj)
            {
                filesCount += num;
            }
        }

        public void Subscribe(IFilesDataReceiver filesDataReceiver)
        {
            filesDataReceivers.Add(filesDataReceiver);
        }

        private void SendFileData(string currentDir, int filesCount, int currentFile)
        {
            filesDataReceivers.ForEach(x => x.UpdateCurrentDirData(currentDir, filesCount, currentFile));
        }

        private void SendFilePath(string filePath)
        {
            string[] path = filePath.Split('\\');

            TreeNode mainNode = new TreeNode(path[0]);
            TreeNode curNode = new TreeNode();
            curNode = mainNode;

            for(int i = 1; i < path.Length; i++) 
            { 
                TreeNode node = new TreeNode(path[i]);
                curNode.Nodes.Add(node);
                curNode = node;
            }

            filesDataReceivers.ForEach(x => x.AddNewFilePath(mainNode));
        }


        public async Task StartSearchAsync(string startDir, string pattern)
        {
            IsSearchPaused = false;
            IsSearchCanseled = false;
            filesCount = 0;
            filesFound = 0;
            filesProcessed = 0;

            await Task.Run(() => filesCount = CheckFilesCount(startDir));

            if (IsSearchCanseled)
            {
                return;
            }

            SendFileData("", filesCount, 0);

            await Task.Run(() => SearchFilesByPattern(startDir, pattern));

            if (IsSearchCanseled)
            {
                return;
            }

            SendFileData("", filesCount, filesProcessed);
            
        }

        private int CheckFilesCount(string startDir)
        {
            int count = 0;
            try
            {
                while (IsSearchPaused)
                {
                    if (IsSearchCanseled)
                    {
                        return count;
                    }
                }
                string[] directories = Directory.GetDirectories(startDir);


                directories.ToList().ForEach(x => count+= CheckFilesCount(x));

            
                string[] files = Directory.GetFiles(startDir);
                count += files.Length;

                return count;
            }
            catch(Exception ex)
            {
                return count;
            }
        }

        private void SearchFilesByPattern(string startDir, string pattern)
        {
            try
            {
                while (IsSearchPaused)
                {
                    if (IsSearchCanseled)
                    {
                        return;
                    }
                }

                string[] directories = Directory.GetDirectories(startDir);

                directories.ToList().ForEach(x => SearchFilesByPattern(x, pattern));

                while (IsSearchPaused)
                {
                    if (IsSearchCanseled)
                    {
                        return;
                    }
                }

                filesProcessed += Directory.GetFiles(startDir).Length;

                string[] fileInfos = Directory.GetFiles(startDir, pattern);


                fileInfos.ToList().ForEach(x =>
                {
                    filesFound++;
                    SendFileData(startDir, filesCount, filesProcessed);
                    SendFilePath(x);
                });
            }
            catch
            {

            }
        }

    }
}
