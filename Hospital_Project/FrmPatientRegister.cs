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
    public partial class FrmPatientRegister : Form
    {
        public FrmPatientRegister()
        {
            InitializeComponent();
        }

        sqlconnection bgl = new sqlconnection();
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '●';
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void cmbGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void mskdPhone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtSurname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into tbl_patients (patientname,patientsurname,patientTC,patientphone,patientpassword,patientgender) values (@p1,@p2,@p3,@p4,@p5,@p6) ", bgl.connection());
            cmd.Parameters.AddWithValue("@p1",txtName.Text);
            cmd.Parameters.AddWithValue("@p2",txtSurname.Text);
            cmd.Parameters.AddWithValue("@p3",mskdTcno.Text);
            cmd.Parameters.AddWithValue("@p4",mskdPhone.Text);
            cmd.Parameters.AddWithValue("@p5",txtPassword.Text);
            cmd.Parameters.AddWithValue("@p6", cmbGender.Text);
            cmd.ExecuteNonQuery();
            bgl.connection().Close();
            MessageBox.Show("Patient Succesfuly added.","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void mskdTcno_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
