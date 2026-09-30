namespace food
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
            this.lblfood1 = new System.Windows.Forms.Label();
            this.txtFood1 = new System.Windows.Forms.TextBox();
            this.btncalculate = new System.Windows.Forms.Button();
            this.lblprice1 = new System.Windows.Forms.Label();
            this.lblfood2 = new System.Windows.Forms.Label();
            this.lblprice2 = new System.Windows.Forms.Label();
            this.llbamount = new System.Windows.Forms.Label();
            this.lblsales = new System.Windows.Forms.Label();
            this.lblamount = new System.Windows.Forms.Label();
            this.txtprice2 = new System.Windows.Forms.TextBox();
            this.txtFood2 = new System.Windows.Forms.TextBox();
            this.txtprice1 = new System.Windows.Forms.TextBox();
            this.lblouputsales = new System.Windows.Forms.Label();
            this.lbloutputtips = new System.Windows.Forms.Label();
            this.lbloutputtotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblfood1
            // 
            this.lblfood1.AutoSize = true;
            this.lblfood1.Location = new System.Drawing.Point(212, 67);
            this.lblfood1.Name = "lblfood1";
            this.lblfood1.Size = new System.Drawing.Size(168, 20);
            this.lblfood1.TabIndex = 0;
            this.lblfood1.Text = "Enter name of Food 1:";
            this.lblfood1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtFood1
            // 
            this.txtFood1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFood1.Location = new System.Drawing.Point(408, 61);
            this.txtFood1.Name = "txtFood1";
            this.txtFood1.Size = new System.Drawing.Size(177, 35);
            this.txtFood1.TabIndex = 1;
            // 
            // btncalculate
            // 
            this.btncalculate.Location = new System.Drawing.Point(302, 253);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(185, 41);
            this.btncalculate.TabIndex = 2;
            this.btncalculate.Text = "Calculate The price";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // lblprice1
            // 
            this.lblprice1.AutoSize = true;
            this.lblprice1.Location = new System.Drawing.Point(212, 106);
            this.lblprice1.Name = "lblprice1";
            this.lblprice1.Size = new System.Drawing.Size(131, 20);
            this.lblprice1.TabIndex = 3;
            this.lblprice1.Text = "Enter price food1";
            // 
            // lblfood2
            // 
            this.lblfood2.AutoSize = true;
            this.lblfood2.Location = new System.Drawing.Point(212, 147);
            this.lblfood2.Name = "lblfood2";
            this.lblfood2.Size = new System.Drawing.Size(167, 20);
            this.lblfood2.TabIndex = 4;
            this.lblfood2.Text = "Enter name of food 2 :";
            // 
            // lblprice2
            // 
            this.lblprice2.AutoSize = true;
            this.lblprice2.Location = new System.Drawing.Point(212, 183);
            this.lblprice2.Name = "lblprice2";
            this.lblprice2.Size = new System.Drawing.Size(139, 20);
            this.lblprice2.TabIndex = 5;
            this.lblprice2.Text = "Enter price  food 2";
            // 
            // llbamount
            // 
            this.llbamount.AutoSize = true;
            this.llbamount.Location = new System.Drawing.Point(240, 352);
            this.llbamount.Name = "llbamount";
            this.llbamount.Size = new System.Drawing.Size(111, 20);
            this.llbamount.TabIndex = 6;
            this.llbamount.Text = "Tips amount is";
            // 
            // lblsales
            // 
            this.lblsales.AutoSize = true;
            this.lblsales.Location = new System.Drawing.Point(240, 310);
            this.lblsales.Name = "lblsales";
            this.lblsales.Size = new System.Drawing.Size(95, 20);
            this.lblsales.TabIndex = 7;
            this.lblsales.Text = "sales Text is";
            // 
            // lblamount
            // 
            this.lblamount.AutoSize = true;
            this.lblamount.Location = new System.Drawing.Point(240, 400);
            this.lblamount.Name = "lblamount";
            this.lblamount.Size = new System.Drawing.Size(102, 20);
            this.lblamount.TabIndex = 8;
            this.lblamount.Text = "Total amount";
            // 
            // txtprice2
            // 
            this.txtprice2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprice2.Location = new System.Drawing.Point(392, 212);
            this.txtprice2.Name = "txtprice2";
            this.txtprice2.Size = new System.Drawing.Size(177, 35);
            this.txtprice2.TabIndex = 9;
            // 
            // txtFood2
            // 
            this.txtFood2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFood2.Location = new System.Drawing.Point(408, 159);
            this.txtFood2.Name = "txtFood2";
            this.txtFood2.Size = new System.Drawing.Size(177, 35);
            this.txtFood2.TabIndex = 10;
            this.txtFood2.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtprice1
            // 
            this.txtprice1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprice1.Location = new System.Drawing.Point(408, 106);
            this.txtprice1.Name = "txtprice1";
            this.txtprice1.Size = new System.Drawing.Size(177, 35);
            this.txtprice1.TabIndex = 11;
            // 
            // lblouputsales
            // 
            this.lblouputsales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblouputsales.Location = new System.Drawing.Point(392, 310);
            this.lblouputsales.Name = "lblouputsales";
            this.lblouputsales.Size = new System.Drawing.Size(154, 31);
            this.lblouputsales.TabIndex = 13;
            this.lblouputsales.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // lbloutputtips
            // 
            this.lbloutputtips.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbloutputtips.Location = new System.Drawing.Point(392, 352);
            this.lbloutputtips.Name = "lbloutputtips";
            this.lbloutputtips.Size = new System.Drawing.Size(168, 31);
            this.lbloutputtips.TabIndex = 14;
            // 
            // lbloutputtotal
            // 
            this.lbloutputtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbloutputtotal.Location = new System.Drawing.Point(392, 400);
            this.lbloutputtotal.Name = "lbloutputtotal";
            this.lbloutputtotal.Size = new System.Drawing.Size(177, 30);
            this.lbloutputtotal.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbloutputtotal);
            this.Controls.Add(this.lbloutputtips);
            this.Controls.Add(this.lblouputsales);
            this.Controls.Add(this.txtprice1);
            this.Controls.Add(this.txtFood2);
            this.Controls.Add(this.txtprice2);
            this.Controls.Add(this.lblamount);
            this.Controls.Add(this.lblsales);
            this.Controls.Add(this.llbamount);
            this.Controls.Add(this.lblprice2);
            this.Controls.Add(this.lblfood2);
            this.Controls.Add(this.lblprice1);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.txtFood1);
            this.Controls.Add(this.lblfood1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblfood1;
        private System.Windows.Forms.TextBox txtFood1;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.Label lblprice1;
        private System.Windows.Forms.Label lblfood2;
        private System.Windows.Forms.Label lblprice2;
        private System.Windows.Forms.Label llbamount;
        private System.Windows.Forms.Label lblsales;
        private System.Windows.Forms.Label lblamount;
        private System.Windows.Forms.TextBox txtprice2;
        private System.Windows.Forms.TextBox txtFood2;
        private System.Windows.Forms.TextBox txtprice1;
        private System.Windows.Forms.Label lblouputsales;
        private System.Windows.Forms.Label lbloutputtips;
        private System.Windows.Forms.Label lbloutputtotal;
    }
}

