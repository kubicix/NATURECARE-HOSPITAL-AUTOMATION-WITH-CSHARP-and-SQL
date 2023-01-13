namespace Hospital_Project
{
    partial class FrmDoctorEdit
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.mskdTcno = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbBranch = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEditInformation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtName.Location = new System.Drawing.Point(126, 33);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(136, 27);
            this.txtName.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label5.Location = new System.Drawing.Point(52, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 23);
            this.label5.TabIndex = 40;
            this.label5.Text = "Name:";
            // 
            // txtSurname
            // 
            this.txtSurname.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSurname.Location = new System.Drawing.Point(126, 66);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(136, 27);
            this.txtSurname.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(29, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 23);
            this.label1.TabIndex = 38;
            this.label1.Text = "Surname:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.checkBox1.Location = new System.Drawing.Point(268, 167);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(73, 27);
            this.checkBox1.TabIndex = 37;
            this.checkBox1.Text = "Show";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPassword.Location = new System.Drawing.Point(126, 168);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.Size = new System.Drawing.Size(136, 27);
            this.txtPassword.TabIndex = 36;
            // 
            // mskdTcno
            // 
            this.mskdTcno.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskdTcno.Location = new System.Drawing.Point(126, 100);
            this.mskdTcno.Mask = "00000000000";
            this.mskdTcno.Name = "mskdTcno";
            this.mskdTcno.Size = new System.Drawing.Size(136, 27);
            this.mskdTcno.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Location = new System.Drawing.Point(23, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 23);
            this.label3.TabIndex = 34;
            this.label3.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(46, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 23);
            this.label2.TabIndex = 33;
            this.label2.Text = "T.C No:";
            // 
            // cmbBranch
            // 
            this.cmbBranch.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbBranch.FormattingEnabled = true;
            this.cmbBranch.Location = new System.Drawing.Point(126, 135);
            this.cmbBranch.Name = "cmbBranch";
            this.cmbBranch.Size = new System.Drawing.Size(136, 27);
            this.cmbBranch.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.Location = new System.Drawing.Point(45, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 23);
            this.label4.TabIndex = 43;
            this.label4.Text = "Branch:";
            // 
            // btnEditInformation
            // 
            this.btnEditInformation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnEditInformation.Location = new System.Drawing.Point(126, 201);
            this.btnEditInformation.Name = "btnEditInformation";
            this.btnEditInformation.Size = new System.Drawing.Size(136, 33);
            this.btnEditInformation.TabIndex = 44;
            this.btnEditInformation.Text = "Update";
            this.btnEditInformation.UseVisualStyleBackColor = false;
            // 
            // FrmDoctorEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(356, 266);
            this.Controls.Add(this.btnEditInformation);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbBranch);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.mskdTcno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "FrmDoctorEdit";
            this.Text = "FrmDoctorEdit";
            this.Load += new System.EventHandler(this.FrmDoctorEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.MaskedTextBox mskdTcno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbBranch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEditInformation;
    }
}