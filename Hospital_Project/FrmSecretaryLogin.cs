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
    public partial class FrmSecretaryLogin : Form
    {
        public FrmSecretaryLogin()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox1.PasswordChar = '\0';
            }
            else
            {
                textBox1.PasswordChar = '●';
            }
        }
        sqlconnection con = new sqlconnection();
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * from tbl_secretary where secretarytc=@p1 and secretarypassword=@p2",con.connection());
            cmd.Parameters.AddWithValue("@p1", maskedTextBox1.Text);
            cmd.Parameters.AddWithValue("@p2", textBox1.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                FrmSecretaryDetail fr = new FrmSecretaryDetail();
                fr.tc = maskedTextBox1.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong TC or password.");
            }
            con.connection().Close();
        }
    }
}
