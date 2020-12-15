namespace ArmoTest
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.FileProcessingProgressBar = new System.Windows.Forms.ProgressBar();
            this.CurrentFileDataLabel = new System.Windows.Forms.Label();
            this.StartDirLabel = new System.Windows.Forms.Label();
            this.StartDirTextBox = new System.Windows.Forms.TextBox();
            this.SearchPatternLabel = new System.Windows.Forms.Label();
            this.SearchPatternTextBox = new System.Windows.Forms.TextBox();
            this.StartSearchButton = new System.Windows.Forms.Button();
            this.PauseSearchButton = new System.Windows.Forms.Button();
            this.ProcessingPanel = new System.Windows.Forms.Panel();
            this.TerminateSearchButton = new System.Windows.Forms.Button();
            this.ChoseDirButton = new System.Windows.Forms.Button();
            this.filesFoundLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timeLabel = new System.Windows.Forms.Label();
            this.FileTreeView = new ArmoTest.DoubleBufferedTreeView();
            this.ProcessingPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // FileProcessingProgressBar
            // 
            this.FileProcessingProgressBar.Location = new System.Drawing.Point(3, 35);
            this.FileProcessingProgressBar.Name = "FileProcessingProgressBar";
            this.FileProcessingProgressBar.Size = new System.Drawing.Size(445, 20);
            this.FileProcessingProgressBar.TabIndex = 1;
            // 
            // CurrentFileDataLabel
            // 
            this.CurrentFileDataLabel.AutoSize = true;
            this.CurrentFileDataLabel.Location = new System.Drawing.Point(12, 9);
            this.CurrentFileDataLabel.Name = "CurrentFileDataLabel";
            this.CurrentFileDataLabel.Size = new System.Drawing.Size(0, 13);
            this.CurrentFileDataLabel.TabIndex = 2;
            // 
            // StartDirLabel
            // 
            this.StartDirLabel.AutoSize = true;
            this.StartDirLabel.Location = new System.Drawing.Point(391, 43);
            this.StartDirLabel.Name = "StartDirLabel";
            this.StartDirLabel.Size = new System.Drawing.Size(122, 13);
            this.StartDirLabel.TabIndex = 3;
            this.StartDirLabel.Text = "Стартовая директория";
            // 
            // StartDirTextBox
            // 
            this.StartDirTextBox.Location = new System.Drawing.Point(385, 59);
            this.StartDirTextBox.Name = "StartDirTextBox";
            this.StartDirTextBox.Size = new System.Drawing.Size(312, 20);
            this.StartDirTextBox.TabIndex = 4;
            this.StartDirTextBox.TextChanged += new System.EventHandler(this.StartDirTextBox_TextChanged);
            // 
            // SearchPatternLabel
            // 
            this.SearchPatternLabel.AutoSize = true;
            this.SearchPatternLabel.Location = new System.Drawing.Point(391, 113);
            this.SearchPatternLabel.Name = "SearchPatternLabel";
            this.SearchPatternLabel.Size = new System.Drawing.Size(85, 13);
            this.SearchPatternLabel.TabIndex = 5;
            this.SearchPatternLabel.Text = "Шаблон поиска";
            // 
            // SearchPatternTextBox
            // 
            this.SearchPatternTextBox.Location = new System.Drawing.Point(385, 129);
            this.SearchPatternTextBox.Name = "SearchPatternTextBox";
            this.SearchPatternTextBox.Size = new System.Drawing.Size(312, 20);
            this.SearchPatternTextBox.TabIndex = 6;
            this.SearchPatternTextBox.TextChanged += new System.EventHandler(this.SearchPatternTextBox_TextChanged);
            // 
            // StartSearchButton
            // 
            this.StartSearchButton.Location = new System.Drawing.Point(780, 126);
            this.StartSearchButton.Name = "StartSearchButton";
            this.StartSearchButton.Size = new System.Drawing.Size(79, 22);
            this.StartSearchButton.TabIndex = 7;
            this.StartSearchButton.Text = "Поиск";
            this.StartSearchButton.UseVisualStyleBackColor = true;
            this.StartSearchButton.Click += new System.EventHandler(this.StartSearchButton_Click);
            // 
            // PauseSearchButton
            // 
            this.PauseSearchButton.Location = new System.Drawing.Point(502, 32);
            this.PauseSearchButton.Name = "PauseSearchButton";
            this.PauseSearchButton.Size = new System.Drawing.Size(75, 23);
            this.PauseSearchButton.TabIndex = 8;
            this.PauseSearchButton.Text = "Пауза";
            this.PauseSearchButton.UseVisualStyleBackColor = true;
            this.PauseSearchButton.Click += new System.EventHandler(this.PauseSearchButton_Click);
            // 
            // ProcessingPanel
            // 
            this.ProcessingPanel.Controls.Add(this.timeLabel);
            this.ProcessingPanel.Controls.Add(this.TerminateSearchButton);
            this.ProcessingPanel.Controls.Add(this.PauseSearchButton);
            this.ProcessingPanel.Controls.Add(this.CurrentFileDataLabel);
            this.ProcessingPanel.Controls.Add(this.FileProcessingProgressBar);
            this.ProcessingPanel.Location = new System.Drawing.Point(385, 491);
            this.ProcessingPanel.Name = "ProcessingPanel";
            this.ProcessingPanel.Size = new System.Drawing.Size(618, 67);
            this.ProcessingPanel.TabIndex = 9;
            this.ProcessingPanel.Visible = false;
            // 
            // TerminateSearchButton
            // 
            this.TerminateSearchButton.Location = new System.Drawing.Point(502, 3);
            this.TerminateSearchButton.Name = "TerminateSearchButton";
            this.TerminateSearchButton.Size = new System.Drawing.Size(74, 23);
            this.TerminateSearchButton.TabIndex = 9;
            this.TerminateSearchButton.Text = "Стоп";
            this.TerminateSearchButton.UseVisualStyleBackColor = true;
            this.TerminateSearchButton.Visible = false;
            this.TerminateSearchButton.Click += new System.EventHandler(this.TerminateSearchButton_Click);
            // 
            // ChoseDirButton
            // 
            this.ChoseDirButton.Location = new System.Drawing.Point(703, 58);
            this.ChoseDirButton.Name = "ChoseDirButton";
            this.ChoseDirButton.Size = new System.Drawing.Size(25, 20);
            this.ChoseDirButton.TabIndex = 10;
            this.ChoseDirButton.Text = "...";
            this.ChoseDirButton.UseVisualStyleBackColor = true;
            this.ChoseDirButton.Click += new System.EventHandler(this.ChoseDirButton_Click);
            // 
            // filesFoundLabel
            // 
            this.filesFoundLabel.AutoSize = true;
            this.filesFoundLabel.Location = new System.Drawing.Point(397, 475);
            this.filesFoundLabel.Name = "filesFoundLabel";
            this.filesFoundLabel.Size = new System.Drawing.Size(0, 13);
            this.filesFoundLabel.TabIndex = 10;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(454, 37);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(0, 13);
            this.timeLabel.TabIndex = 10;
            // 
            // FileTreeView
            // 
            this.FileTreeView.Dock = System.Windows.Forms.DockStyle.Left;
            this.FileTreeView.Location = new System.Drawing.Point(0, 0);
            this.FileTreeView.Name = "FileTreeView";
            this.FileTreeView.Size = new System.Drawing.Size(315, 558);
            this.FileTreeView.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 558);
            this.Controls.Add(this.filesFoundLabel);
            this.Controls.Add(this.ChoseDirButton);
            this.Controls.Add(this.ProcessingPanel);
            this.Controls.Add(this.StartSearchButton);
            this.Controls.Add(this.SearchPatternTextBox);
            this.Controls.Add(this.SearchPatternLabel);
            this.Controls.Add(this.StartDirTextBox);
            this.Controls.Add(this.StartDirLabel);
            this.Controls.Add(this.FileTreeView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ProcessingPanel.ResumeLayout(false);
            this.ProcessingPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DoubleBufferedTreeView FileTreeView;
        private System.Windows.Forms.ProgressBar FileProcessingProgressBar;
        private System.Windows.Forms.Label CurrentFileDataLabel;
        private System.Windows.Forms.Label StartDirLabel;
        private System.Windows.Forms.TextBox StartDirTextBox;
        private System.Windows.Forms.Label SearchPatternLabel;
        private System.Windows.Forms.TextBox SearchPatternTextBox;
        private System.Windows.Forms.Button StartSearchButton;
        private System.Windows.Forms.Button PauseSearchButton;
        private System.Windows.Forms.Panel ProcessingPanel;
        private System.Windows.Forms.Button ChoseDirButton;
        private System.Windows.Forms.Button TerminateSearchButton;
        private System.Windows.Forms.Label filesFoundLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Timer timer1;
    }
}

