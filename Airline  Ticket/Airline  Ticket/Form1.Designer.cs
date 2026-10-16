namespace Airline__Ticket
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
            this.lblticketsystem = new System.Windows.Forms.Label();
            this.groupBoxpersonal = new System.Windows.Forms.GroupBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtBaggage = new System.Windows.Forms.TextBox();
            this.txtTickets = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbltickets = new System.Windows.Forms.Label();
            this.lblage = new System.Windows.Forms.Label();
            this.lblpessangername = new System.Windows.Forms.Label();
            this.travel = new System.Windows.Forms.GroupBox();
            this.radioButtonBusiness = new System.Windows.Forms.RadioButton();
            this.radioButtonnormalclass = new System.Windows.Forms.RadioButton();
            this.radioButtonfirstclass = new System.Windows.Forms.RadioButton();
            this.additionaloption = new System.Windows.Forms.GroupBox();
            this.checkBoxtravelinsurance = new System.Windows.Forms.CheckBox();
            this.listBoxdisplay = new System.Windows.Forms.ListBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBoxpersonal.SuspendLayout();
            this.travel.SuspendLayout();
            this.additionaloption.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblticketsystem
            // 
            this.lblticketsystem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lblticketsystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblticketsystem.ForeColor = System.Drawing.Color.White;
            this.lblticketsystem.Location = new System.Drawing.Point(1, 0);
            this.lblticketsystem.Name = "lblticketsystem";
            this.lblticketsystem.Size = new System.Drawing.Size(897, 47);
            this.lblticketsystem.TabIndex = 0;
            this.lblticketsystem.Text = "Airline Ticket Booking System";
            this.lblticketsystem.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBoxpersonal
            // 
            this.groupBoxpersonal.BackColor = System.Drawing.Color.Silver;
            this.groupBoxpersonal.Controls.Add(this.txtAge);
            this.groupBoxpersonal.Controls.Add(this.txtBaggage);
            this.groupBoxpersonal.Controls.Add(this.txtTickets);
            this.groupBoxpersonal.Controls.Add(this.txtName);
            this.groupBoxpersonal.Controls.Add(this.label4);
            this.groupBoxpersonal.Controls.Add(this.lbltickets);
            this.groupBoxpersonal.Controls.Add(this.lblage);
            this.groupBoxpersonal.Controls.Add(this.lblpessangername);
            this.groupBoxpersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxpersonal.Location = new System.Drawing.Point(-3, 50);
            this.groupBoxpersonal.Name = "groupBoxpersonal";
            this.groupBoxpersonal.Size = new System.Drawing.Size(523, 317);
            this.groupBoxpersonal.TabIndex = 1;
            this.groupBoxpersonal.TabStop = false;
            this.groupBoxpersonal.Text = "Personal Information";
            this.groupBoxpersonal.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtAge
            // 
            this.txtAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAge.Location = new System.Drawing.Point(231, 80);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(208, 30);
            this.txtAge.TabIndex = 1;
            // 
            // txtBaggage
            // 
            this.txtBaggage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBaggage.Location = new System.Drawing.Point(231, 154);
            this.txtBaggage.Name = "txtBaggage";
            this.txtBaggage.Size = new System.Drawing.Size(208, 30);
            this.txtBaggage.TabIndex = 3;
            // 
            // txtTickets
            // 
            this.txtTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTickets.Location = new System.Drawing.Point(231, 118);
            this.txtTickets.Name = "txtTickets";
            this.txtTickets.Size = new System.Drawing.Size(208, 30);
            this.txtTickets.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(231, 44);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(208, 30);
            this.txtName.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(224, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Baggage Weight (kg):";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // lbltickets
            // 
            this.lbltickets.AutoSize = true;
            this.lbltickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltickets.Location = new System.Drawing.Point(20, 118);
            this.lbltickets.Name = "lbltickets";
            this.lbltickets.Size = new System.Drawing.Size(187, 25);
            this.lbltickets.TabIndex = 7;
            this.lbltickets.Text = "Number of Tickets";
            // 
            // lblage
            // 
            this.lblage.AutoSize = true;
            this.lblage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblage.Location = new System.Drawing.Point(30, 80);
            this.lblage.Name = "lblage";
            this.lblage.Size = new System.Drawing.Size(167, 25);
            this.lblage.TabIndex = 6;
            this.lblage.Text = "Passenger Age:";
            // 
            // lblpessangername
            // 
            this.lblpessangername.AutoSize = true;
            this.lblpessangername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpessangername.Location = new System.Drawing.Point(21, 43);
            this.lblpessangername.Name = "lblpessangername";
            this.lblpessangername.Size = new System.Drawing.Size(184, 25);
            this.lblpessangername.TabIndex = 5;
            this.lblpessangername.Text = "Passenger Name:";
            // 
            // travel
            // 
            this.travel.Controls.Add(this.radioButtonBusiness);
            this.travel.Controls.Add(this.radioButtonnormalclass);
            this.travel.Controls.Add(this.radioButtonfirstclass);
            this.travel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.travel.Location = new System.Drawing.Point(3, 373);
            this.travel.Name = "travel";
            this.travel.Size = new System.Drawing.Size(538, 103);
            this.travel.TabIndex = 2;
            this.travel.TabStop = false;
            this.travel.Text = "Travel Class";
            this.travel.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // radioButtonBusiness
            // 
            this.radioButtonBusiness.AutoSize = true;
            this.radioButtonBusiness.Location = new System.Drawing.Point(346, 47);
            this.radioButtonBusiness.Name = "radioButtonBusiness";
            this.radioButtonBusiness.Size = new System.Drawing.Size(186, 29);
            this.radioButtonBusiness.TabIndex = 2;
            this.radioButtonBusiness.TabStop = true;
            this.radioButtonBusiness.Text = "Business Class";
            this.radioButtonBusiness.UseVisualStyleBackColor = true;
            // 
            // radioButtonnormalclass
            // 
            this.radioButtonnormalclass.AutoSize = true;
            this.radioButtonnormalclass.Location = new System.Drawing.Point(160, 47);
            this.radioButtonnormalclass.Name = "radioButtonnormalclass";
            this.radioButtonnormalclass.Size = new System.Drawing.Size(166, 29);
            this.radioButtonnormalclass.TabIndex = 1;
            this.radioButtonnormalclass.TabStop = true;
            this.radioButtonnormalclass.Text = "Normal Class";
            this.radioButtonnormalclass.UseVisualStyleBackColor = true;
            // 
            // radioButtonfirstclass
            // 
            this.radioButtonfirstclass.AutoSize = true;
            this.radioButtonfirstclass.Location = new System.Drawing.Point(14, 47);
            this.radioButtonfirstclass.Name = "radioButtonfirstclass";
            this.radioButtonfirstclass.Size = new System.Drawing.Size(140, 29);
            this.radioButtonfirstclass.TabIndex = 0;
            this.radioButtonfirstclass.TabStop = true;
            this.radioButtonfirstclass.Text = "First Class";
            this.radioButtonfirstclass.UseVisualStyleBackColor = true;
            // 
            // additionaloption
            // 
            this.additionaloption.Controls.Add(this.checkBoxtravelinsurance);
            this.additionaloption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.additionaloption.Location = new System.Drawing.Point(3, 483);
            this.additionaloption.Name = "additionaloption";
            this.additionaloption.Size = new System.Drawing.Size(421, 86);
            this.additionaloption.TabIndex = 3;
            this.additionaloption.TabStop = false;
            this.additionaloption.Text = "Additional Options";
            // 
            // checkBoxtravelinsurance
            // 
            this.checkBoxtravelinsurance.AutoSize = true;
            this.checkBoxtravelinsurance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxtravelinsurance.Location = new System.Drawing.Point(7, 51);
            this.checkBoxtravelinsurance.Name = "checkBoxtravelinsurance";
            this.checkBoxtravelinsurance.Size = new System.Drawing.Size(408, 29);
            this.checkBoxtravelinsurance.TabIndex = 0;
            this.checkBoxtravelinsurance.Text = "Add Travel Insurance ($25 per tickets)";
            this.checkBoxtravelinsurance.UseVisualStyleBackColor = true;
            // 
            // listBoxdisplay
            // 
            this.listBoxdisplay.FormattingEnabled = true;
            this.listBoxdisplay.ItemHeight = 20;
            this.listBoxdisplay.Items.AddRange(new object[] {
            "Airline Booking Datails"});
            this.listBoxdisplay.Location = new System.Drawing.Point(556, 50);
            this.listBoxdisplay.Name = "listBoxdisplay";
            this.listBoxdisplay.Size = new System.Drawing.Size(342, 464);
            this.listBoxdisplay.TabIndex = 4;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(27, 604);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(139, 51);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(213, 607);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(116, 44);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(362, 607);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(112, 44);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(895, 716);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.listBoxdisplay);
            this.Controls.Add(this.additionaloption);
            this.Controls.Add(this.travel);
            this.Controls.Add(this.groupBoxpersonal);
            this.Controls.Add(this.lblticketsystem);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxpersonal.ResumeLayout(false);
            this.groupBoxpersonal.PerformLayout();
            this.travel.ResumeLayout(false);
            this.travel.PerformLayout();
            this.additionaloption.ResumeLayout(false);
            this.additionaloption.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblticketsystem;
        private System.Windows.Forms.GroupBox groupBoxpersonal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbltickets;
        private System.Windows.Forms.Label lblage;
        private System.Windows.Forms.Label lblpessangername;
        private System.Windows.Forms.GroupBox travel;
        private System.Windows.Forms.GroupBox additionaloption;
        private System.Windows.Forms.ListBox listBoxdisplay;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtBaggage;
        private System.Windows.Forms.TextBox txtTickets;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.RadioButton radioButtonfirstclass;
        private System.Windows.Forms.RadioButton radioButtonBusiness;
        private System.Windows.Forms.RadioButton radioButtonnormalclass;
        private System.Windows.Forms.CheckBox checkBoxtravelinsurance;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

