namespace Parrel_with_overtime
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
            this.lblHoursework = new System.Windows.Forms.Label();
            this.lblPayrate = new System.Windows.Forms.Label();
            this.lblGros = new System.Windows.Forms.Label();
            this.llboutputGross = new System.Windows.Forms.Label();
            this.btnCalculateGross = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtHoursework = new System.Windows.Forms.TextBox();
            this.txtPayrate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblHoursework
            // 
            this.lblHoursework.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoursework.Location = new System.Drawing.Point(121, 42);
            this.lblHoursework.Name = "lblHoursework";
            this.lblHoursework.Size = new System.Drawing.Size(331, 30);
            this.lblHoursework.TabIndex = 0;
            this.lblHoursework.Text = "Enter Hours Worked: ";
            // 
            // lblPayrate
            // 
            this.lblPayrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayrate.Location = new System.Drawing.Point(136, 83);
            this.lblPayrate.Name = "lblPayrate";
            this.lblPayrate.Size = new System.Drawing.Size(269, 35);
            this.lblPayrate.TabIndex = 1;
            this.lblPayrate.Text = "Enter Pay Rate:  ";
            // 
            // lblGros
            // 
            this.lblGros.AutoSize = true;
            this.lblGros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGros.Location = new System.Drawing.Point(136, 142);
            this.lblGros.Name = "lblGros";
            this.lblGros.Size = new System.Drawing.Size(139, 29);
            this.lblGros.TabIndex = 2;
            this.lblGros.Text = "Gross Pay:";
            // 
            // llboutputGross
            // 
            this.llboutputGross.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.llboutputGross.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llboutputGross.Location = new System.Drawing.Point(287, 142);
            this.llboutputGross.Name = "llboutputGross";
            this.llboutputGross.Size = new System.Drawing.Size(340, 55);
            this.llboutputGross.TabIndex = 2;
            this.llboutputGross.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnCalculateGross
            // 
            this.btnCalculateGross.Location = new System.Drawing.Point(126, 307);
            this.btnCalculateGross.Name = "btnCalculateGross";
            this.btnCalculateGross.Size = new System.Drawing.Size(110, 59);
            this.btnCalculateGross.TabIndex = 3;
            this.btnCalculateGross.Text = "&Calculate  Gross aby";
            this.btnCalculateGross.UseVisualStyleBackColor = true;
            this.btnCalculateGross.Click += new System.EventHandler(this.btnCalculateGross_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(287, 316);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(94, 78);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(437, 323);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(102, 65);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Clo&se";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtHoursework
            // 
            this.txtHoursework.Location = new System.Drawing.Point(497, 46);
            this.txtHoursework.Name = "txtHoursework";
            this.txtHoursework.Size = new System.Drawing.Size(208, 26);
            this.txtHoursework.TabIndex = 0;
            // 
            // txtPayrate
            // 
            this.txtPayrate.Location = new System.Drawing.Point(497, 92);
            this.txtPayrate.Name = "txtPayrate";
            this.txtPayrate.Size = new System.Drawing.Size(208, 26);
            this.txtPayrate.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtPayrate);
            this.Controls.Add(this.txtHoursework);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculateGross);
            this.Controls.Add(this.llboutputGross);
            this.Controls.Add(this.lblGros);
            this.Controls.Add(this.lblPayrate);
            this.Controls.Add(this.lblHoursework);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHoursework;
        private System.Windows.Forms.Label lblPayrate;
        private System.Windows.Forms.Label lblGros;
        private System.Windows.Forms.Label llboutputGross;
        private System.Windows.Forms.Button btnCalculateGross;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtHoursework;
        private System.Windows.Forms.TextBox txtPayrate;
    }
}

