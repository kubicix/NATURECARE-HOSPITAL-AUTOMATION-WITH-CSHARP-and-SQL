namespace Hospital_Project
{
    partial class FrmLogins
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogins));
            this.btnPatientLogin = new System.Windows.Forms.Button();
            this.btnDoctorLogin = new System.Windows.Forms.Button();
            this.btnSecretaryLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPatientLogin
            // 
            this.btnPatientLogin.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnPatientLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPatientLogin.BackgroundImage")));
            this.btnPatientLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPatientLogin.Location = new System.Drawing.Point(11, 175);
            this.btnPatientLogin.Name = "btnPatientLogin";
            this.btnPatientLogin.Size = new System.Drawing.Size(222, 189);
            this.btnPatientLogin.TabIndex = 0;
            this.btnPatientLogin.UseVisualStyleBackColor = false;
            this.btnPatientLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDoctorLogin
            // 
            this.btnDoctorLogin.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnDoctorLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDoctorLogin.BackgroundImage")));
            this.btnDoctorLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDoctorLogin.Location = new System.Drawing.Point(266, 175);
            this.btnDoctorLogin.Name = "btnDoctorLogin";
            this.btnDoctorLogin.Size = new System.Drawing.Size(222, 189);
            this.btnDoctorLogin.TabIndex = 1;
            this.btnDoctorLogin.UseVisualStyleBackColor = false;
            this.btnDoctorLogin.Click += new System.EventHandler(this.btnDoctorLogin_Click);
            // 
            // btnSecretaryLogin
            // 
            this.btnSecretaryLogin.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnSecretaryLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSecretaryLogin.BackgroundImage")));
            this.btnSecretaryLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSecretaryLogin.Location = new System.Drawing.Point(522, 175);
            this.btnSecretaryLogin.Name = "btnSecretaryLogin";
            this.btnSecretaryLogin.Size = new System.Drawing.Size(222, 189);
            this.btnSecretaryLogin.TabIndex = 2;
            this.btnSecretaryLogin.UseVisualStyleBackColor = false;
            this.btnSecretaryLogin.Click += new System.EventHandler(this.btnSecretaryLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 367);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Patient";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(262, 367);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Doctor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(518, 367);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Secretary";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(577, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Console", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(571, 48);
            this.label4.TabIndex = 7;
            this.label4.Text = "NatureCare Hospital";
            // 
            // FrmLogins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(757, 409);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSecretaryLogin);
            this.Controls.Add(this.btnDoctorLogin);
            this.Controls.Add(this.btnPatientLogin);
            this.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "FrmLogins";
            this.Text = "NatureCare Hospital";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPatientLogin;
        private System.Windows.Forms.Button btnDoctorLogin;
        private System.Windows.Forms.Button btnSecretaryLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
    }
}

