namespace Example_nasted_loops
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
            this.lblSalary = new System.Windows.Forms.Label();
            this.lblyears = new System.Windows.Forms.Label();
            this.lblDecision = new System.Windows.Forms.Label();
            this.lbloutput = new System.Windows.Forms.Label();
            this.txtslary = new System.Windows.Forms.TextBox();
            this.txtyears = new System.Windows.Forms.TextBox();
            this.btnCheckqultifiction = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalary.Location = new System.Drawing.Point(205, 65);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(191, 29);
            this.lblSalary.TabIndex = 0;
            this.lblSalary.Text = "Enter your salary";
            // 
            // lblyears
            // 
            this.lblyears.AutoSize = true;
            this.lblyears.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblyears.Location = new System.Drawing.Point(206, 112);
            this.lblyears.Name = "lblyears";
            this.lblyears.Size = new System.Drawing.Size(190, 29);
            this.lblyears.TabIndex = 1;
            this.lblyears.Text = "Enter Years exp:";
            // 
            // lblDecision
            // 
            this.lblDecision.AutoSize = true;
            this.lblDecision.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDecision.Location = new System.Drawing.Point(209, 193);
            this.lblDecision.Name = "lblDecision";
            this.lblDecision.Size = new System.Drawing.Size(188, 29);
            this.lblDecision.TabIndex = 2;
            this.lblDecision.Text = "Descion Ruesult";
            // 
            // lbloutput
            // 
            this.lbloutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbloutput.Location = new System.Drawing.Point(12, 276);
            this.lbloutput.Name = "lbloutput";
            this.lbloutput.Size = new System.Drawing.Size(737, 45);
            this.lbloutput.TabIndex = 2;
            // 
            // txtslary
            // 
            this.txtslary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtslary.Location = new System.Drawing.Point(454, 69);
            this.txtslary.Name = "txtslary";
            this.txtslary.Size = new System.Drawing.Size(260, 35);
            this.txtslary.TabIndex = 0;
            this.txtslary.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtyears
            // 
            this.txtyears.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtyears.Location = new System.Drawing.Point(454, 116);
            this.txtyears.Name = "txtyears";
            this.txtyears.Size = new System.Drawing.Size(260, 35);
            this.txtyears.TabIndex = 1;
            // 
            // btnCheckqultifiction
            // 
            this.btnCheckqultifiction.Location = new System.Drawing.Point(131, 373);
            this.btnCheckqultifiction.Name = "btnCheckqultifiction";
            this.btnCheckqultifiction.Size = new System.Drawing.Size(122, 39);
            this.btnCheckqultifiction.TabIndex = 3;
            this.btnCheckqultifiction.Text = "&Qulitifiction";
            this.btnCheckqultifiction.UseVisualStyleBackColor = true;
            this.btnCheckqultifiction.Click += new System.EventHandler(this.btnCheckqultifiction_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(331, 375);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 34);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(477, 375);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(112, 34);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCheckqultifiction);
            this.Controls.Add(this.txtyears);
            this.Controls.Add(this.txtslary);
            this.Controls.Add(this.lbloutput);
            this.Controls.Add(this.lblDecision);
            this.Controls.Add(this.lblyears);
            this.Controls.Add(this.lblSalary);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Label lblyears;
        private System.Windows.Forms.Label lblDecision;
        private System.Windows.Forms.Label lbloutput;
        private System.Windows.Forms.TextBox txtslary;
        private System.Windows.Forms.TextBox txtyears;
        private System.Windows.Forms.Button btnCheckqultifiction;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

