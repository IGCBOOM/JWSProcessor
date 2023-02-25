namespace JWSProcessorGUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.FileList = new System.Windows.Forms.ListBox();
            this.ChannelNumberBox = new System.Windows.Forms.TextBox();
            this.ChannelLabel = new System.Windows.Forms.Label();
            this.ExportButton = new System.Windows.Forms.Button();
            this.RemoveFileButton = new System.Windows.Forms.Button();
            this.AddFileButton = new System.Windows.Forms.Button();
            this.DestinationLabel = new System.Windows.Forms.Label();
            this.DestinationFolderBox = new System.Windows.Forms.TextBox();
            this.DestinationFolderButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FileList
            // 
            this.FileList.FormattingEnabled = true;
            this.FileList.HorizontalScrollbar = true;
            this.FileList.ItemHeight = 15;
            this.FileList.Location = new System.Drawing.Point(12, 12);
            this.FileList.Name = "FileList";
            this.FileList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.FileList.Size = new System.Drawing.Size(200, 319);
            this.FileList.TabIndex = 0;
            this.FileList.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // ChannelNumberBox
            // 
            this.ChannelNumberBox.Location = new System.Drawing.Point(227, 33);
            this.ChannelNumberBox.Name = "ChannelNumberBox";
            this.ChannelNumberBox.Size = new System.Drawing.Size(102, 23);
            this.ChannelNumberBox.TabIndex = 1;
            this.ChannelNumberBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ChannelLabel
            // 
            this.ChannelLabel.AutoSize = true;
            this.ChannelLabel.Location = new System.Drawing.Point(218, 15);
            this.ChannelLabel.Name = "ChannelLabel";
            this.ChannelLabel.Size = new System.Drawing.Size(120, 15);
            this.ChannelLabel.TabIndex = 2;
            this.ChannelLabel.Text = " Number of Channels";
            this.ChannelLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // ExportButton
            // 
            this.ExportButton.Location = new System.Drawing.Point(376, 296);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(110, 34);
            this.ExportButton.TabIndex = 3;
            this.ExportButton.Text = "Export File(s)";
            this.ExportButton.UseVisualStyleBackColor = true;
            this.ExportButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // RemoveFileButton
            // 
            this.RemoveFileButton.Location = new System.Drawing.Point(227, 296);
            this.RemoveFileButton.Name = "RemoveFileButton";
            this.RemoveFileButton.Size = new System.Drawing.Size(111, 35);
            this.RemoveFileButton.TabIndex = 4;
            this.RemoveFileButton.Text = "Remove File(s)";
            this.RemoveFileButton.UseVisualStyleBackColor = true;
            this.RemoveFileButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // AddFileButton
            // 
            this.AddFileButton.Location = new System.Drawing.Point(227, 255);
            this.AddFileButton.Name = "AddFileButton";
            this.AddFileButton.Size = new System.Drawing.Size(111, 35);
            this.AddFileButton.TabIndex = 5;
            this.AddFileButton.Text = "Add File(s)";
            this.AddFileButton.UseVisualStyleBackColor = true;
            this.AddFileButton.Click += new System.EventHandler(this.AddFileButton_Click);
            // 
            // DestinationLabel
            // 
            this.DestinationLabel.AutoSize = true;
            this.DestinationLabel.Location = new System.Drawing.Point(257, 104);
            this.DestinationLabel.Name = "DestinationLabel";
            this.DestinationLabel.Size = new System.Drawing.Size(103, 15);
            this.DestinationLabel.TabIndex = 6;
            this.DestinationLabel.Text = "Destination Folder";
            this.DestinationLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // DestinationFolderBox
            // 
            this.DestinationFolderBox.Location = new System.Drawing.Point(227, 122);
            this.DestinationFolderBox.Name = "DestinationFolderBox";
            this.DestinationFolderBox.Size = new System.Drawing.Size(168, 23);
            this.DestinationFolderBox.TabIndex = 7;
            this.DestinationFolderBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // DestinationFolderButton
            // 
            this.DestinationFolderButton.Location = new System.Drawing.Point(227, 151);
            this.DestinationFolderButton.Name = "DestinationFolderButton";
            this.DestinationFolderButton.Size = new System.Drawing.Size(111, 35);
            this.DestinationFolderButton.TabIndex = 8;
            this.DestinationFolderButton.Text = "Select Folder";
            this.DestinationFolderButton.UseVisualStyleBackColor = true;
            this.DestinationFolderButton.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 346);
            this.Controls.Add(this.DestinationFolderButton);
            this.Controls.Add(this.DestinationFolderBox);
            this.Controls.Add(this.DestinationLabel);
            this.Controls.Add(this.AddFileButton);
            this.Controls.Add(this.RemoveFileButton);
            this.Controls.Add(this.ExportButton);
            this.Controls.Add(this.ChannelLabel);
            this.Controls.Add(this.ChannelNumberBox);
            this.Controls.Add(this.FileList);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox FileList;
        private TextBox ChannelNumberBox;
        private Label ChannelLabel;
        private Button ExportButton;
        private Button RemoveFileButton;
        private Button AddFileButton;
        private Label DestinationLabel;
        private TextBox DestinationFolderBox;
        private Button DestinationFolderButton;
    }
}