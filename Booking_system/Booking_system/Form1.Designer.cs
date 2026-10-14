namespace Booking_system
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtnight = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtGuest = new System.Windows.Forms.TextBox();
            this.lblnumbertguest = new System.Windows.Forms.Label();
            this.lblnumbernight = new System.Windows.Forms.Label();
            this.lblguestage = new System.Windows.Forms.Label();
            this.lblguestname = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonhight = new System.Windows.Forms.RadioButton();
            this.radioButtonnormal = new System.Windows.Forms.RadioButton();
            this.radioButtonstandrad = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBoxbreakfast = new System.Windows.Forms.CheckBox();
            this.btncalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.listBoxdisplay = new System.Windows.Forms.ListBox();
            this.lblbookingsystem = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txtnight);
            this.groupBox1.Controls.Add(this.txtAge);
            this.groupBox1.Controls.Add(this.txtGuest);
            this.groupBox1.Controls.Add(this.lblnumbertguest);
            this.groupBox1.Controls.Add(this.lblnumbernight);
            this.groupBox1.Controls.Add(this.lblguestage);
            this.groupBox1.Controls.Add(this.lblguestname);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(438, 254);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal Information";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(189, 44);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(178, 35);
            this.txtName.TabIndex = 0;
            // 
            // txtnight
            // 
            this.txtnight.Location = new System.Drawing.Point(189, 126);
            this.txtnight.Name = "txtnight";
            this.txtnight.Size = new System.Drawing.Size(178, 35);
            this.txtnight.TabIndex = 2;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(189, 85);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(178, 35);
            this.txtAge.TabIndex = 1;
            // 
            // txtGuest
            // 
            this.txtGuest.Location = new System.Drawing.Point(189, 166);
            this.txtGuest.Name = "txtGuest";
            this.txtGuest.Size = new System.Drawing.Size(178, 35);
            this.txtGuest.TabIndex = 3;
            // 
            // lblnumbertguest
            // 
            this.lblnumbertguest.AutoSize = true;
            this.lblnumbertguest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumbertguest.Location = new System.Drawing.Point(20, 166);
            this.lblnumbertguest.Name = "lblnumbertguest";
            this.lblnumbertguest.Size = new System.Drawing.Size(167, 22);
            this.lblnumbertguest.TabIndex = 3;
            this.lblnumbertguest.Text = "Number of Guest:";
            // 
            // lblnumbernight
            // 
            this.lblnumbernight.AutoSize = true;
            this.lblnumbernight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumbernight.Location = new System.Drawing.Point(20, 122);
            this.lblnumbernight.Name = "lblnumbernight";
            this.lblnumbernight.Size = new System.Drawing.Size(165, 22);
            this.lblnumbernight.TabIndex = 2;
            this.lblnumbernight.Text = "Number of Nights";
            // 
            // lblguestage
            // 
            this.lblguestage.AutoSize = true;
            this.lblguestage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblguestage.Location = new System.Drawing.Point(17, 85);
            this.lblguestage.Name = "lblguestage";
            this.lblguestage.Size = new System.Drawing.Size(110, 22);
            this.lblguestage.TabIndex = 1;
            this.lblguestage.Text = "Guest Age:";
            // 
            // lblguestname
            // 
            this.lblguestname.AutoSize = true;
            this.lblguestname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblguestname.Location = new System.Drawing.Point(15, 47);
            this.lblguestname.Name = "lblguestname";
            this.lblguestname.Size = new System.Drawing.Size(126, 22);
            this.lblguestname.TabIndex = 0;
            this.lblguestname.Text = "Guest Name:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonhight);
            this.groupBox2.Controls.Add(this.radioButtonnormal);
            this.groupBox2.Controls.Add(this.radioButtonstandrad);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 328);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(377, 129);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Room Type";
            // 
            // radioButtonhight
            // 
            this.radioButtonhight.AutoSize = true;
            this.radioButtonhight.Location = new System.Drawing.Point(264, 52);
            this.radioButtonhight.Name = "radioButtonhight";
            this.radioButtonhight.Size = new System.Drawing.Size(87, 29);
            this.radioButtonhight.TabIndex = 2;
            this.radioButtonhight.TabStop = true;
            this.radioButtonhight.Text = "Hight";
            this.radioButtonhight.UseVisualStyleBackColor = true;
            // 
            // radioButtonnormal
            // 
            this.radioButtonnormal.AutoSize = true;
            this.radioButtonnormal.Location = new System.Drawing.Point(125, 52);
            this.radioButtonnormal.Name = "radioButtonnormal";
            this.radioButtonnormal.Size = new System.Drawing.Size(105, 29);
            this.radioButtonnormal.TabIndex = 1;
            this.radioButtonnormal.TabStop = true;
            this.radioButtonnormal.Text = "Normal";
            this.radioButtonnormal.UseVisualStyleBackColor = true;
            // 
            // radioButtonstandrad
            // 
            this.radioButtonstandrad.AutoSize = true;
            this.radioButtonstandrad.Location = new System.Drawing.Point(5, 52);
            this.radioButtonstandrad.Name = "radioButtonstandrad";
            this.radioButtonstandrad.Size = new System.Drawing.Size(125, 29);
            this.radioButtonstandrad.TabIndex = 0;
            this.radioButtonstandrad.TabStop = true;
            this.radioButtonstandrad.Text = "Standard";
            this.radioButtonstandrad.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBoxbreakfast);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 500);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(322, 100);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Addition Option";
            // 
            // checkBoxbreakfast
            // 
            this.checkBoxbreakfast.AutoSize = true;
            this.checkBoxbreakfast.Location = new System.Drawing.Point(7, 37);
            this.checkBoxbreakfast.Name = "checkBoxbreakfast";
            this.checkBoxbreakfast.Size = new System.Drawing.Size(313, 24);
            this.checkBoxbreakfast.TabIndex = 0;
            this.checkBoxbreakfast.Text = "BreakFast(10 per Guest per Night)";
            this.checkBoxbreakfast.UseVisualStyleBackColor = true;
            // 
            // btncalculate
            // 
            this.btncalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalculate.Location = new System.Drawing.Point(78, 622);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(116, 38);
            this.btncalculate.TabIndex = 10;
            this.btncalculate.Text = "Calculate";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(262, 622);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(112, 39);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click_1);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(449, 630);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(107, 31);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // listBoxdisplay
            // 
            this.listBoxdisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxdisplay.FormattingEnabled = true;
            this.listBoxdisplay.ItemHeight = 22;
            this.listBoxdisplay.Items.AddRange(new object[] {
            "BOOKING DETALIS"});
            this.listBoxdisplay.Location = new System.Drawing.Point(490, 53);
            this.listBoxdisplay.Name = "listBoxdisplay";
            this.listBoxdisplay.Size = new System.Drawing.Size(338, 466);
            this.listBoxdisplay.TabIndex = 2;
            // 
            // lblbookingsystem
            // 
            this.lblbookingsystem.BackColor = System.Drawing.Color.DarkOrchid;
            this.lblbookingsystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbookingsystem.Location = new System.Drawing.Point(3, 1);
            this.lblbookingsystem.Name = "lblbookingsystem";
            this.lblbookingsystem.Size = new System.Drawing.Size(795, 40);
            this.lblbookingsystem.TabIndex = 14;
            this.lblbookingsystem.Text = "Hotel  Room Booking  System";
            this.lblbookingsystem.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(880, 694);
            this.Controls.Add(this.lblbookingsystem);
            this.Controls.Add(this.listBoxdisplay);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtnight;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtGuest;
        private System.Windows.Forms.Label lblnumbertguest;
        private System.Windows.Forms.Label lblnumbernight;
        private System.Windows.Forms.Label lblguestage;
        private System.Windows.Forms.Label lblguestname;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButtonhight;
        private System.Windows.Forms.RadioButton radioButtonnormal;
        private System.Windows.Forms.RadioButton radioButtonstandrad;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkBoxbreakfast;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListBox listBoxdisplay;
        private System.Windows.Forms.Label lblbookingsystem;
    }
}

