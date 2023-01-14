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
    public partial class FrmSecretaryDetail : Form
    {
        public FrmSecretaryDetail()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        public string tc;
        sqlconnection con =new sqlconnection();
        private void FrmSecretaryDetail_Load(object sender, EventArgs e)
        {
            lblTC.Text = tc;
            //getting name
            SqlCommand cmd = new SqlCommand("Select * from tbl_secretary where secretarytc=" + tc, con.connection());
            SqlDataReader dr=cmd.ExecuteReader();
            while(dr.Read())
            {
                lblName.Text = dr[1].ToString();
            }
            con.connection().Close();

            //getting branches to datagridview
            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select branchname from tbl_branches",con.connection());
            da.Fill(dt1);
            dataGridView1.DataSource= dt1;
            
            con.connection().Close();

            //getting doctor details
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select (doctorname+' '+ doctorsurname) as 'Doctor Name',doctorbranch from tbl_doctors", con.connection());
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;

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

        private void btnSave_Click(object sender, EventArgs e)
        {
            try { 
            SqlCommand cmdsave = new SqlCommand("insert into tbl_appointments (appointmentdate,appointmenttime,appointmentbranch,appointmentdoctor) values (@r1,@r2,@r3,@r4)",con.connection());
            cmdsave.Parameters.AddWithValue("@r1", mskDate.Text);
            cmdsave.Parameters.AddWithValue("@r2", mskHour.Text);
            cmdsave.Parameters.AddWithValue("@r3", cmbBranch.Text);
            cmdsave.Parameters.AddWithValue("@r4", cmbDoctor.Text);
            cmdsave.ExecuteNonQuery();
            
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.connection().Close();
            MessageBox.Show("Appointment created.");

        }

        private void cmbBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDoctor.Items.Clear();
            //getting doctor names to combobox
            SqlCommand cmddoc = new SqlCommand("Select (doctorname+' '+doctorsurname) from tbl_doctors where doctorbranch=@b1", con.connection());
            cmddoc.Parameters.AddWithValue("@b1", cmbBranch.Text);
            SqlDataReader drd = cmddoc.ExecuteReader();
            while (drd.Read())
            {
                cmbDoctor.Items.Add(drd[0]);
            }
            con.connection().Close();
        }

        private void btnCreateAnnounce_Click(object sender, EventArgs e)
        {
            rchAnnouncement.Clear();
            SqlCommand cmd = new SqlCommand("insert into tbl_announcements (announcement) values (@p1)", con.connection());
            cmd.Parameters.AddWithValue("@p1",rchAnnouncement.Text);
            cmd.ExecuteNonQuery();
            con.connection().Close();
            MessageBox.Show("Announcement created.");
        }

        private void btnDoctorpanel_Click(object sender, EventArgs e)
        {
            FrmDoctorPanel frm = new FrmDoctorPanel();
            frm.Show();
            this.Hide();
        }
    }
}
