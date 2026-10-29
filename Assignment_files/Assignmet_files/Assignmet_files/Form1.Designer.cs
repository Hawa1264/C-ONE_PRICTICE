namespace Assignmet_files
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnReadLines = new System.Windows.Forms.Button();
            this.btnReadAllBytes = new System.Windows.Forms.Button();
            this.btnReadBlock = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnDirectoryDelete = new System.Windows.Forms.Button();
            this.btnFileInfoDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(28, 29);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(174, 95);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Creating Files";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(297, 306);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(165, 89);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Deleting";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(518, 29);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(362, 504);
            this.listBox1.TabIndex = 3;
            // 
            // btnReadLines
            // 
            this.btnReadLines.Location = new System.Drawing.Point(28, 158);
            this.btnReadLines.Name = "btnReadLines";
            this.btnReadLines.Size = new System.Drawing.Size(174, 96);
            this.btnReadLines.TabIndex = 4;
            this.btnReadLines.Text = "Readlines";
            this.btnReadLines.UseVisualStyleBackColor = true;
            this.btnReadLines.Click += new System.EventHandler(this.btnReadLines_Click);
            // 
            // btnReadAllBytes
            // 
            this.btnReadAllBytes.Location = new System.Drawing.Point(12, 290);
            this.btnReadAllBytes.Name = "btnReadAllBytes";
            this.btnReadAllBytes.Size = new System.Drawing.Size(174, 96);
            this.btnReadAllBytes.TabIndex = 5;
            this.btnReadAllBytes.Text = "ReadAllBytes";
            this.btnReadAllBytes.UseVisualStyleBackColor = true;
            this.btnReadAllBytes.Click += new System.EventHandler(this.btnReadAllBytes_Click);
            // 
            // btnReadBlock
            // 
            this.btnReadBlock.Location = new System.Drawing.Point(297, 169);
            this.btnReadBlock.Name = "btnReadBlock";
            this.btnReadBlock.Size = new System.Drawing.Size(174, 96);
            this.btnReadBlock.TabIndex = 6;
            this.btnReadBlock.Text = "ReadBlock";
            this.btnReadBlock.UseVisualStyleBackColor = true;
            this.btnReadBlock.Click += new System.EventHandler(this.btnReadBlock_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(297, 40);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(174, 96);
            this.btnRead.TabIndex = 7;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnDirectoryDelete
            // 
            this.btnDirectoryDelete.Location = new System.Drawing.Point(12, 420);
            this.btnDirectoryDelete.Name = "btnDirectoryDelete";
            this.btnDirectoryDelete.Size = new System.Drawing.Size(174, 96);
            this.btnDirectoryDelete.TabIndex = 8;
            this.btnDirectoryDelete.Text = "Directory Delete";
            this.btnDirectoryDelete.UseVisualStyleBackColor = true;
            this.btnDirectoryDelete.Click += new System.EventHandler(this.btnDirectoryDelete_Click);
            // 
            // btnFileInfoDelete
            // 
            this.btnFileInfoDelete.Location = new System.Drawing.Point(288, 420);
            this.btnFileInfoDelete.Name = "btnFileInfoDelete";
            this.btnFileInfoDelete.Size = new System.Drawing.Size(174, 96);
            this.btnFileInfoDelete.TabIndex = 9;
            this.btnFileInfoDelete.Text = "FileInfo Delete";
            this.btnFileInfoDelete.UseVisualStyleBackColor = true;
            this.btnFileInfoDelete.Click += new System.EventHandler(this.btnFileInfoDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 648);
            this.Controls.Add(this.btnFileInfoDelete);
            this.Controls.Add(this.btnDirectoryDelete);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnReadBlock);
            this.Controls.Add(this.btnReadAllBytes);
            this.Controls.Add(this.btnReadLines);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCreate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnReadLines;
        private System.Windows.Forms.Button btnReadAllBytes;
        private System.Windows.Forms.Button btnReadBlock;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnDirectoryDelete;
        private System.Windows.Forms.Button btnFileInfoDelete;
    }
}

