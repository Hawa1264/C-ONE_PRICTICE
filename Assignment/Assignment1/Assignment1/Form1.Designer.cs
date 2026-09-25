namespace Assignment1
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
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtdepatment = new System.Windows.Forms.TextBox();
            this.txtstudentid = new System.Windows.Forms.TextBox();
            this.txtsemester = new System.Windows.Forms.TextBox();
            this.btnShowinfo = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.lbloutput = new System.Windows.Forms.Label();
            this.lbstdentinformation = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.lbldeparment = new System.Windows.Forms.Label();
            this.lblstdentid = new System.Windows.Forms.Label();
            this.lblsemester = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(399, 119);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(262, 39);
            this.txtname.TabIndex = 3;
            // 
            // txtdepatment
            // 
            this.txtdepatment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdepatment.Location = new System.Drawing.Point(399, 246);
            this.txtdepatment.Name = "txtdepatment";
            this.txtdepatment.Size = new System.Drawing.Size(262, 39);
            this.txtdepatment.TabIndex = 4;
            // 
            // txtstudentid
            // 
            this.txtstudentid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstudentid.Location = new System.Drawing.Point(399, 182);
            this.txtstudentid.Name = "txtstudentid";
            this.txtstudentid.Size = new System.Drawing.Size(262, 39);
            this.txtstudentid.TabIndex = 5;
            // 
            // txtsemester
            // 
            this.txtsemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsemester.Location = new System.Drawing.Point(399, 310);
            this.txtsemester.Name = "txtsemester";
            this.txtsemester.Size = new System.Drawing.Size(262, 39);
            this.txtsemester.TabIndex = 6;
            // 
            // btnShowinfo
            // 
            this.btnShowinfo.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnShowinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowinfo.Location = new System.Drawing.Point(117, 537);
            this.btnShowinfo.Name = "btnShowinfo";
            this.btnShowinfo.Size = new System.Drawing.Size(172, 54);
            this.btnShowinfo.TabIndex = 8;
            this.btnShowinfo.Text = "Show Information";
            this.btnShowinfo.UseVisualStyleBackColor = false;
            this.btnShowinfo.Click += new System.EventHandler(this.btnShowinfo_);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(561, 548);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(118, 43);
            this.btnexit.TabIndex = 9;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(349, 543);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(118, 43);
            this.btnclear.TabIndex = 10;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // lbloutput
            // 
            this.lbloutput.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbloutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbloutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbloutput.Location = new System.Drawing.Point(186, 398);
            this.lbloutput.Name = "lbloutput";
            this.lbloutput.Size = new System.Drawing.Size(535, 85);
            this.lbloutput.TabIndex = 7;
            // 
            // lbstdentinformation
            // 
            this.lbstdentinformation.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbstdentinformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbstdentinformation.ForeColor = System.Drawing.Color.Navy;
            this.lbstdentinformation.Location = new System.Drawing.Point(164, 24);
            this.lbstdentinformation.Name = "lbstdentinformation";
            this.lbstdentinformation.Size = new System.Drawing.Size(477, 73);
            this.lbstdentinformation.TabIndex = 11;
            this.lbstdentinformation.Text = "STUDENT INFORMATION";
            this.lbstdentinformation.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblname
            // 
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblname.Location = new System.Drawing.Point(96, 128);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(254, 40);
            this.lblname.TabIndex = 12;
            this.lblname.Text = "Enter the  student name";
            this.lblname.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // lbldeparment
            // 
            this.lbldeparment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldeparment.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lbldeparment.Location = new System.Drawing.Point(96, 243);
            this.lbldeparment.Name = "lbldeparment";
            this.lbldeparment.Size = new System.Drawing.Size(254, 40);
            this.lbldeparment.TabIndex = 13;
            this.lbldeparment.Text = "Enter the deparment";
            this.lbldeparment.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblstdentid
            // 
            this.lblstdentid.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstdentid.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblstdentid.Location = new System.Drawing.Point(96, 181);
            this.lblstdentid.Name = "lblstdentid";
            this.lblstdentid.Size = new System.Drawing.Size(254, 40);
            this.lblstdentid.TabIndex = 14;
            this.lblstdentid.Text = "Enter the stdent ID";
            this.lblstdentid.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblsemester
            // 
            this.lblsemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsemester.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblsemester.Location = new System.Drawing.Point(96, 307);
            this.lblsemester.Name = "lblsemester";
            this.lblsemester.Size = new System.Drawing.Size(254, 40);
            this.lblsemester.TabIndex = 15;
            this.lblsemester.Text = "Enter the semester";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 631);
            this.Controls.Add(this.lblsemester);
            this.Controls.Add(this.lblstdentid);
            this.Controls.Add(this.lbldeparment);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.lbstdentinformation);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnShowinfo);
            this.Controls.Add(this.lbloutput);
            this.Controls.Add(this.txtsemester);
            this.Controls.Add(this.txtstudentid);
            this.Controls.Add(this.txtdepatment);
            this.Controls.Add(this.txtname);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtdepatment;
        private System.Windows.Forms.TextBox txtstudentid;
        private System.Windows.Forms.TextBox txtsemester;
        private System.Windows.Forms.Button btnShowinfo;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Label lbloutput;
        private System.Windows.Forms.Label lbstdentinformation;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lbldeparment;
        private System.Windows.Forms.Label lblstdentid;
        private System.Windows.Forms.Label lblsemester;
    }
}

