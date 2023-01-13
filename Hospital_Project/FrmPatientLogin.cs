using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hospital_Project
{
    public partial class FrmPatientLogin : Form
    {
        public FrmPatientLogin()
        {
            InitializeComponent();
        }

        private void FrmPatientLogin_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked==true)
            {
                textBox1.PasswordChar= '\0';
            }
            else
            {
                textBox1.PasswordChar = '●';
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmPatientRegister fr = new FrmPatientRegister();
            fr.Show();
            
        }
        sqlconnection bgl = new sqlconnection();
        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * from tbl_patients where patientTC=@p1 and patientpassword=@p2",bgl.connection());
            cmd.Parameters.AddWithValue("@p1", maskedTextBox1.Text);
            cmd.Parameters.AddWithValue("@p2", textBox1.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                FrmPatientDetail fr = new FrmPatientDetail();
                fr.tc = maskedTextBox1.Text;
                fr.Show();
                this.Hide();
                
            }
            else
            {
                MessageBox.Show("Wrong TC no or Password.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            bgl.connection().Close();
            
        }
    }
}
