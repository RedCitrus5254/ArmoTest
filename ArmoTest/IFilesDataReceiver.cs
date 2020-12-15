using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArmoTest
{
    interface IFilesDataReceiver
    {
        void UpdateCurrentDirData(string currentDir, int filesCount, int currentFileNum);
        void AddNewFilePath(TreeNode node);

    }

}
