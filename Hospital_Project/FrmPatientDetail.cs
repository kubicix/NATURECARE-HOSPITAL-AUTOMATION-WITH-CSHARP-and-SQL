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
    public partial class FrmPatientDetail : Form
    {
        public FrmPatientDetail()
        {
            InitializeComponent();
        }
        public string tc;
        sqlconnection bgl = new sqlconnection();
        private void FrmPatientDetail_Load(object sender, EventArgs e)
        {
            lblTC.Text = tc;
            //getting names with TC
            SqlCommand cmd = new SqlCommand("Select patientname,patientsurname from tbl_patients where patienttc=@p1", bgl.connection());
            cmd.Parameters.AddWithValue("@p1", lblTC.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lblName.Text = dr[0] + " " + dr[1];
            }
            bgl.connection().Close();
            try
            {
                //appointment history
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("Select * from tbl_appointments where patienttc=" + tc, bgl.connection());
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                //pulling branches from sql
                SqlCommand cmd2 = new SqlCommand("Select branchname from tbl_Branches ", bgl.connection());
                SqlDataReader dr2=cmd2.ExecuteReader();
                while (dr2.Read())
                {
                    cmbBranch.Items.Add(dr2[0]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            bgl.connection().Close();

        }

        private void cmbBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDoctor.Items.Clear();
            try
            {
                SqlCommand cmd3 = new SqlCommand("Select doctorname,doctorsurname from tbl_doctors where doctorbranch=@p1",bgl.connection());
                cmd3.Parameters.AddWithValue("@p1",cmbBranch.Text);
                SqlDataReader dr3 =cmd3.ExecuteReader();
                while(dr3.Read())
                {
                    cmbDoctor.Items.Add(dr3[0]+" " + dr3[1]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            bgl.connection().Close();
            
        }

        private void cmbDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from tbl_appointments where appointmentbranch='"+cmbBranch.Text+"'",bgl.connection());
            da.Fill(dt);
            dataGridView2.DataSource= dt;
        }

        private void lnkEditInformation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmEditInformation fr = new FrmEditInformation();
            fr.tcno = tc;
            fr.Show();
            
        }
    }
}
