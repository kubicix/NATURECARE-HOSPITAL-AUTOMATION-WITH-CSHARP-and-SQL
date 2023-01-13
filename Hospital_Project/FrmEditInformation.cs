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
    public partial class FrmEditInformation : Form
    {
        public FrmEditInformation()
        {
            InitializeComponent();
        }

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
        public string tcno;
        sqlconnection bgl = new sqlconnection();
        private void FrmEditInformation_Load(object sender, EventArgs e)
        {
            mskdTcno.Text= tcno;
            SqlCommand cmd = new SqlCommand("Select * from tbl_patients where patienttc=@p1",bgl.connection());
            cmd.Parameters.AddWithValue("@p1",mskdTcno.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                txtName.Text = dr[1].ToString();
                txtSurname.Text = dr[2].ToString(); 
                mskdPhone.Text = dr[4].ToString();
                txtPassword.Text = dr[5].ToString();
                cmbGender.Text= dr[6].ToString();
            }
        }

        private void btnEditInformation_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd2 = new SqlCommand("update tbl_patients set patientname=@p1,patientsurname=@p2,patientphone=@p3,patientpassword=@p4,patientgender=@p5 where patienttc=@p6", bgl.connection());
                cmd2.Parameters.AddWithValue("@p1", txtName.Text);
                cmd2.Parameters.AddWithValue("@p2", txtSurname.Text);
                cmd2.Parameters.AddWithValue("@p3", mskdPhone.Text);
                cmd2.Parameters.AddWithValue("@p4", txtPassword.Text);
                cmd2.Parameters.AddWithValue("@p5", cmbGender.Text);
                cmd2.Parameters.AddWithValue("@p6", mskdTcno.Text);
                cmd2.ExecuteNonQuery();
                MessageBox.Show("Your information updated succesfuly.");


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            bgl.connection().Close();
            


        }
    }
}
