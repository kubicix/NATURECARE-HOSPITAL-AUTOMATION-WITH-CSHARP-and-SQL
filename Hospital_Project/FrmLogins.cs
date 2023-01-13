using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Project
{
    public partial class FrmLogins : Form
    {
        public FrmLogins()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmPatientLogin fr1 = new FrmPatientLogin();
            fr1.Show();
            this.Hide();
        }

        private void btnDoctorLogin_Click(object sender, EventArgs e)
        {
            FrmDoctorLogin fr2 = new FrmDoctorLogin();
            fr2.Show();
            this.Hide();
        }

        private void btnSecretaryLogin_Click(object sender, EventArgs e)
        {
            FrmSecretaryLogin fr3 = new FrmSecretaryLogin();
            fr3.Show();
            this.Hide();
        }
    }
}
