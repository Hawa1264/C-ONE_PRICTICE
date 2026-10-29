namespace Regerstion_form_system
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
            this.y = new System.Windows.Forms.GroupBox();
            this.lblSummary = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.groupBoxTransport = new System.Windows.Forms.GroupBox();
            this.rdnTransNo = new System.Windows.Forms.RadioButton();
            this.rdnTransYes = new System.Windows.Forms.RadioButton();
            this.groupBoxAccommodation = new System.Windows.Forms.GroupBox();
            this.rdnAccNo = new System.Windows.Forms.RadioButton();
            this.rdnAccYes = new System.Windows.Forms.RadioButton();
            this.txtCourses = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblcourse = new System.Windows.Forms.Label();
            this.lblstudey = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.listBoxLevel = new System.Windows.Forms.ListBox();
            this.y.SuspendLayout();
            this.groupBoxTransport.SuspendLayout();
            this.groupBoxAccommodation.SuspendLayout();
            this.SuspendLayout();
            // 
            // y
            // 
            this.y.Controls.Add(this.listBoxLevel);
            this.y.Controls.Add(this.lblSummary);
            this.y.Controls.Add(this.btnExit);
            this.y.Controls.Add(this.btnClear);
            this.y.Controls.Add(this.btnCalculate);
            this.y.Controls.Add(this.groupBoxTransport);
            this.y.Controls.Add(this.groupBoxAccommodation);
            this.y.Controls.Add(this.txtCourses);
            this.y.Controls.Add(this.txtID);
            this.y.Controls.Add(this.txtName);
            this.y.Controls.Add(this.lblcourse);
            this.y.Controls.Add(this.lblstudey);
            this.y.Controls.Add(this.lblID);
            this.y.Controls.Add(this.lblname);
            this.y.Location = new System.Drawing.Point(13, 12);
            this.y.Name = "y";
            this.y.Size = new System.Drawing.Size(704, 698);
            this.y.TabIndex = 0;
            this.y.TabStop = false;
            this.y.Text = "groupBox1";
            this.y.Enter += new System.EventHandler(this.y_Enter);
            // 
            // lblSummary
            // 
            this.lblSummary.BackColor = System.Drawing.Color.White;
            this.lblSummary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSummary.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.lblSummary.Location = new System.Drawing.Point(10, 431);
            this.lblSummary.Name = "lblSummary";
            this.lblSummary.Size = new System.Drawing.Size(281, 264);
            this.lblSummary.TabIndex = 11;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(444, 376);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(138, 39);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(255, 376);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(125, 39);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(81, 376);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(139, 39);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // groupBoxTransport
            // 
            this.groupBoxTransport.Controls.Add(this.rdnTransNo);
            this.groupBoxTransport.Controls.Add(this.rdnTransYes);
            this.groupBoxTransport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTransport.Location = new System.Drawing.Point(373, 246);
            this.groupBoxTransport.Name = "groupBoxTransport";
            this.groupBoxTransport.Size = new System.Drawing.Size(254, 100);
            this.groupBoxTransport.TabIndex = 8;
            this.groupBoxTransport.TabStop = false;
            this.groupBoxTransport.Text = "Transport";
            // 
            // rdnTransNo
            // 
            this.rdnTransNo.AutoSize = true;
            this.rdnTransNo.Location = new System.Drawing.Point(122, 25);
            this.rdnTransNo.Name = "rdnTransNo";
            this.rdnTransNo.Size = new System.Drawing.Size(56, 24);
            this.rdnTransNo.TabIndex = 2;
            this.rdnTransNo.TabStop = true;
            this.rdnTransNo.Text = "No";
            this.rdnTransNo.UseVisualStyleBackColor = true;
            // 
            // rdnTransYes
            // 
            this.rdnTransYes.AutoSize = true;
            this.rdnTransYes.Location = new System.Drawing.Point(6, 25);
            this.rdnTransYes.Name = "rdnTransYes";
            this.rdnTransYes.Size = new System.Drawing.Size(65, 24);
            this.rdnTransYes.TabIndex = 1;
            this.rdnTransYes.TabStop = true;
            this.rdnTransYes.Text = "Yes";
            this.rdnTransYes.UseVisualStyleBackColor = true;
            // 
            // groupBoxAccommodation
            // 
            this.groupBoxAccommodation.Controls.Add(this.rdnAccNo);
            this.groupBoxAccommodation.Controls.Add(this.rdnAccYes);
            this.groupBoxAccommodation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxAccommodation.Location = new System.Drawing.Point(0, 246);
            this.groupBoxAccommodation.Name = "groupBoxAccommodation";
            this.groupBoxAccommodation.Size = new System.Drawing.Size(254, 100);
            this.groupBoxAccommodation.TabIndex = 7;
            this.groupBoxAccommodation.TabStop = false;
            this.groupBoxAccommodation.Text = "Accommodation";
            // 
            // rdnAccNo
            // 
            this.rdnAccNo.AutoSize = true;
            this.rdnAccNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdnAccNo.Location = new System.Drawing.Point(128, 25);
            this.rdnAccNo.Name = "rdnAccNo";
            this.rdnAccNo.Size = new System.Drawing.Size(64, 29);
            this.rdnAccNo.TabIndex = 1;
            this.rdnAccNo.TabStop = true;
            this.rdnAccNo.Text = "No";
            this.rdnAccNo.UseVisualStyleBackColor = true;
            // 
            // rdnAccYes
            // 
            this.rdnAccYes.AutoSize = true;
            this.rdnAccYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdnAccYes.Location = new System.Drawing.Point(3, 22);
            this.rdnAccYes.Name = "rdnAccYes";
            this.rdnAccYes.Size = new System.Drawing.Size(65, 24);
            this.rdnAccYes.TabIndex = 0;
            this.rdnAccYes.TabStop = true;
            this.rdnAccYes.Text = "Yes";
            this.rdnAccYes.UseVisualStyleBackColor = true;
            // 
            // txtCourses
            // 
            this.txtCourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCourses.Location = new System.Drawing.Point(200, 106);
            this.txtCourses.Name = "txtCourses";
            this.txtCourses.Size = new System.Drawing.Size(161, 30);
            this.txtCourses.TabIndex = 6;
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(200, 69);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(161, 30);
            this.txtID.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(200, 30);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(161, 30);
            this.txtName.TabIndex = 4;
            // 
            // lblcourse
            // 
            this.lblcourse.AutoSize = true;
            this.lblcourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcourse.Location = new System.Drawing.Point(6, 114);
            this.lblcourse.Name = "lblcourse";
            this.lblcourse.Size = new System.Drawing.Size(188, 22);
            this.lblcourse.TabIndex = 3;
            this.lblcourse.Text = "Number of Courses:";
            // 
            // lblstudey
            // 
            this.lblstudey.AutoSize = true;
            this.lblstudey.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstudey.Location = new System.Drawing.Point(23, 167);
            this.lblstudey.Name = "lblstudey";
            this.lblstudey.Size = new System.Drawing.Size(121, 22);
            this.lblstudey.TabIndex = 2;
            this.lblstudey.Text = "Study Level:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(27, 74);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(110, 22);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "Student ID:";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(23, 35);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(142, 22);
            this.lblname.TabIndex = 0;
            this.lblname.Text = "Student Name:";
            this.lblname.Click += new System.EventHandler(this.label1_Click);
            // 
            // listBoxLevel
            // 
            this.listBoxLevel.FormattingEnabled = true;
            this.listBoxLevel.ItemHeight = 20;
            this.listBoxLevel.Items.AddRange(new object[] {
            "Year 1",
            "Year 2",
            "Year 3",
            "Year 4"});
            this.listBoxLevel.Location = new System.Drawing.Point(168, 167);
            this.listBoxLevel.Name = "listBoxLevel";
            this.listBoxLevel.Size = new System.Drawing.Size(150, 24);
            this.listBoxLevel.TabIndex = 2;
            this.listBoxLevel.SelectedIndexChanged += new System.EventHandler(this.listBoxLevel_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1236, 722);
            this.Controls.Add(this.y);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.y.ResumeLayout(false);
            this.y.PerformLayout();
            this.groupBoxTransport.ResumeLayout(false);
            this.groupBoxTransport.PerformLayout();
            this.groupBoxAccommodation.ResumeLayout(false);
            this.groupBoxAccommodation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox y;
        private System.Windows.Forms.GroupBox groupBoxTransport;
        private System.Windows.Forms.RadioButton rdnTransNo;
        private System.Windows.Forms.RadioButton rdnTransYes;
        private System.Windows.Forms.GroupBox groupBoxAccommodation;
        private System.Windows.Forms.RadioButton rdnAccNo;
        private System.Windows.Forms.RadioButton rdnAccYes;
        private System.Windows.Forms.TextBox txtCourses;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblcourse;
        private System.Windows.Forms.Label lblstudey;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblSummary;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.ListBox listBoxLevel;
    }
}

