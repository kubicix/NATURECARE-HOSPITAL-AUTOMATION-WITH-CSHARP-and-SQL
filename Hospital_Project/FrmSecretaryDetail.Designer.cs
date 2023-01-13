namespace Hospital_Project
{
    partial class FrmSecretaryDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSecretaryDetail));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTC = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCreateAnnounce = new System.Windows.Forms.Button();
            this.rchAnnouncement = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.chkStatus = new System.Windows.Forms.CheckBox();
            this.mskTc = new System.Windows.Forms.MaskedTextBox();
            this.cmbDoctor = new System.Windows.Forms.ComboBox();
            this.cmbBranch = new System.Windows.Forms.ComboBox();
            this.mskHour = new System.Windows.Forms.MaskedTextBox();
            this.mskDate = new System.Windows.Forms.MaskedTextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnAppointmentlist = new System.Windows.Forms.Button();
            this.btnBranchpanel = new System.Windows.Forms.Button();
            this.btnDoctorpanel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblTC);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 127);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Secretary Information";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblName.Location = new System.Drawing.Point(89, 83);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(70, 23);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "null null";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Location = new System.Drawing.Point(21, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "Name:";
            // 
            // lblTC
            // 
            this.lblTC.AutoSize = true;
            this.lblTC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblTC.Location = new System.Drawing.Point(89, 47);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(120, 23);
            this.lblTC.TabIndex = 9;
            this.lblTC.Text = "00000000000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(15, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "T.C No:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.groupBox2.Controls.Add(this.btnCreateAnnounce);
            this.groupBox2.Controls.Add(this.rchAnnouncement);
            this.groupBox2.Location = new System.Drawing.Point(12, 145);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(307, 298);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Create Announcement";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnCreateAnnounce
            // 
            this.btnCreateAnnounce.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCreateAnnounce.Location = new System.Drawing.Point(6, 246);
            this.btnCreateAnnounce.Name = "btnCreateAnnounce";
            this.btnCreateAnnounce.Size = new System.Drawing.Size(295, 36);
            this.btnCreateAnnounce.TabIndex = 1;
            this.btnCreateAnnounce.Text = "Create";
            this.btnCreateAnnounce.UseVisualStyleBackColor = false;
            // 
            // rchAnnouncement
            // 
            this.rchAnnouncement.Font = new System.Drawing.Font("Corbel", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rchAnnouncement.Location = new System.Drawing.Point(6, 27);
            this.rchAnnouncement.Name = "rchAnnouncement";
            this.rchAnnouncement.Size = new System.Drawing.Size(295, 213);
            this.rchAnnouncement.TabIndex = 0;
            this.rchAnnouncement.Text = "Enter Announcement Here..";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.LightSeaGreen;
            this.groupBox3.Controls.Add(this.btnUpdate);
            this.groupBox3.Controls.Add(this.btnSave);
            this.groupBox3.Controls.Add(this.chkStatus);
            this.groupBox3.Controls.Add(this.mskTc);
            this.groupBox3.Controls.Add(this.cmbDoctor);
            this.groupBox3.Controls.Add(this.cmbBranch);
            this.groupBox3.Controls.Add(this.mskHour);
            this.groupBox3.Controls.Add(this.mskDate);
            this.groupBox3.Controls.Add(this.txtId);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(325, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(339, 431);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Secretary Information";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnUpdate.Location = new System.Drawing.Point(121, 355);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(191, 36);
            this.btnUpdate.TabIndex = 25;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSave.Location = new System.Drawing.Point(120, 313);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(191, 36);
            this.btnSave.TabIndex = 24;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // chkStatus
            // 
            this.chkStatus.AutoSize = true;
            this.chkStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.chkStatus.Location = new System.Drawing.Point(190, 265);
            this.chkStatus.Name = "chkStatus";
            this.chkStatus.Size = new System.Drawing.Size(80, 27);
            this.chkStatus.TabIndex = 23;
            this.chkStatus.Text = "Status";
            this.chkStatus.UseVisualStyleBackColor = false;
            // 
            // mskTc
            // 
            this.mskTc.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskTc.Location = new System.Drawing.Point(190, 233);
            this.mskTc.Mask = "00000000000";
            this.mskTc.Name = "mskTc";
            this.mskTc.Size = new System.Drawing.Size(120, 27);
            this.mskTc.TabIndex = 22;
            // 
            // cmbDoctor
            // 
            this.cmbDoctor.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbDoctor.FormattingEnabled = true;
            this.cmbDoctor.Location = new System.Drawing.Point(189, 199);
            this.cmbDoctor.Name = "cmbDoctor";
            this.cmbDoctor.Size = new System.Drawing.Size(121, 27);
            this.cmbDoctor.TabIndex = 21;
            // 
            // cmbBranch
            // 
            this.cmbBranch.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbBranch.FormattingEnabled = true;
            this.cmbBranch.Location = new System.Drawing.Point(190, 163);
            this.cmbBranch.Name = "cmbBranch";
            this.cmbBranch.Size = new System.Drawing.Size(121, 27);
            this.cmbBranch.TabIndex = 20;
            this.cmbBranch.SelectedIndexChanged += new System.EventHandler(this.cmbBranch_SelectedIndexChanged);
            // 
            // mskHour
            // 
            this.mskHour.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskHour.Location = new System.Drawing.Point(190, 131);
            this.mskHour.Mask = "00:00";
            this.mskHour.Name = "mskHour";
            this.mskHour.Size = new System.Drawing.Size(50, 27);
            this.mskHour.TabIndex = 19;
            this.mskHour.ValidatingType = typeof(System.DateTime);
            // 
            // mskDate
            // 
            this.mskDate.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskDate.Location = new System.Drawing.Point(190, 98);
            this.mskDate.Mask = "00/00/0000";
            this.mskDate.Name = "mskDate";
            this.mskDate.Size = new System.Drawing.Size(87, 27);
            this.mskDate.TabIndex = 18;
            this.mskDate.ValidatingType = typeof(System.DateTime);
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtId.Location = new System.Drawing.Point(190, 62);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(87, 27);
            this.txtId.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label8.Location = new System.Drawing.Point(22, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(163, 23);
            this.label8.TabIndex = 14;
            this.label8.Text = "Appointment Time:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label7.Location = new System.Drawing.Point(116, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 23);
            this.label7.TabIndex = 13;
            this.label7.Text = "Branch:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label5.Location = new System.Drawing.Point(64, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "Doctor Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(42, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "Appointment ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.Location = new System.Drawing.Point(22, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Appointment Date:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label6.Location = new System.Drawing.Point(117, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 23);
            this.label6.TabIndex = 7;
            this.label6.Text = "T.C No:";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.LightSeaGreen;
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(670, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(493, 312);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Branches";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(487, 282);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.LightSeaGreen;
            this.groupBox5.Controls.Add(this.dataGridView2);
            this.groupBox5.Location = new System.Drawing.Point(673, 330);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(493, 312);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Doctors";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 27);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(487, 282);
            this.dataGridView2.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.LightSeaGreen;
            this.groupBox6.Controls.Add(this.btnAppointmentlist);
            this.groupBox6.Controls.Add(this.btnBranchpanel);
            this.groupBox6.Controls.Add(this.btnDoctorpanel);
            this.groupBox6.Location = new System.Drawing.Point(12, 449);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(652, 189);
            this.groupBox6.TabIndex = 13;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Secretary Information";
            // 
            // btnAppointmentlist
            // 
            this.btnAppointmentlist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAppointmentlist.Location = new System.Drawing.Point(428, 59);
            this.btnAppointmentlist.Name = "btnAppointmentlist";
            this.btnAppointmentlist.Size = new System.Drawing.Size(191, 84);
            this.btnAppointmentlist.TabIndex = 27;
            this.btnAppointmentlist.Text = "Appointment List";
            this.btnAppointmentlist.UseVisualStyleBackColor = false;
            // 
            // btnBranchpanel
            // 
            this.btnBranchpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnBranchpanel.Location = new System.Drawing.Point(231, 59);
            this.btnBranchpanel.Name = "btnBranchpanel";
            this.btnBranchpanel.Size = new System.Drawing.Size(191, 84);
            this.btnBranchpanel.TabIndex = 26;
            this.btnBranchpanel.Text = "Branch Panel";
            this.btnBranchpanel.UseVisualStyleBackColor = false;
            // 
            // btnDoctorpanel
            // 
            this.btnDoctorpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnDoctorpanel.Location = new System.Drawing.Point(34, 59);
            this.btnDoctorpanel.Name = "btnDoctorpanel";
            this.btnDoctorpanel.Size = new System.Drawing.Size(191, 84);
            this.btnDoctorpanel.TabIndex = 25;
            this.btnDoctorpanel.Text = "Doctor Panel";
            this.btnDoctorpanel.UseVisualStyleBackColor = false;
            // 
            // FrmSecretaryDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1175, 650);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmSecretaryDetail";
            this.Text = "FrmSecretaryDetail";
            this.Load += new System.EventHandler(this.FrmSecretaryDetail_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCreateAnnounce;
        private System.Windows.Forms.RichTextBox rchAnnouncement;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.MaskedTextBox mskHour;
        private System.Windows.Forms.MaskedTextBox mskDate;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox chkStatus;
        private System.Windows.Forms.MaskedTextBox mskTc;
        private System.Windows.Forms.ComboBox cmbDoctor;
        private System.Windows.Forms.ComboBox cmbBranch;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnAppointmentlist;
        private System.Windows.Forms.Button btnBranchpanel;
        private System.Windows.Forms.Button btnDoctorpanel;
    }
}