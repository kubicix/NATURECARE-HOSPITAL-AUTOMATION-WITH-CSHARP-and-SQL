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
    public partial class FrmDoctorPanel : Form
    {
        public FrmDoctorPanel()
        {
            InitializeComponent();
        }
        sqlconnection con = new sqlconnection();
        private void FrmDoctorPanel_Load(object sender, EventArgs e)
        {
            //getting doctors to table
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select * from tbl_doctors", con.connection());
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;

            con.connection().Close();

            //getting branches to combobox
            SqlCommand cmdb = new SqlCommand("Select branchname from tbl_branches", con.connection());
            SqlDataReader drb = cmdb.ExecuteReader();
            while (drb.Read())
            {
                cmbBranch.Items.Add(drb[0]);
            }
            con.connection().Close();
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //adding doctor
            SqlCommand cmd = new SqlCommand("insert into tbl_doctors (doctorname,doctorsurname,doctorbranch,doctortc,doctorpassword) values(@d1,@d2,@d3,@d4,@d5)",con.connection());
            cmd.Parameters.AddWithValue("@d1",txtName.Text);
            cmd.Parameters.AddWithValue("@d2",txtSurname.Text);
            cmd.Parameters.AddWithValue("@d3",cmbBranch.Text);
            cmd.Parameters.AddWithValue("@d4",mskTc.Text);
            cmd.Parameters.AddWithValue("@d5",txtPassword.Text);
            cmd.ExecuteNonQuery();
            con.connection().Close() ;
            MessageBox.Show("Doctor successfully added to the list.");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int choosen = dataGridView1.SelectedCells[0].RowIndex;
            txtName.Text = dataGridView1.Rows[choosen].Cells[1].Value.ToString();
            txtSurname.Text = dataGridView1.Rows[choosen].Cells[2].Value.ToString();
            cmbBranch.Text = dataGridView1.Rows[choosen].Cells[3].Value.ToString();
            mskTc.Text = dataGridView1.Rows[choosen].Cells[4].Value.ToString();
            txtPassword.Text = dataGridView1.Rows[choosen].Cells[5].Value.ToString();
        }
    }
}
