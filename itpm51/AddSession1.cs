using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TimeTableM
{
    public partial class AddSession1 : Form
    {
        MySqlConnection con = null;
        public AddSession1()
        {
            InitializeComponent();
            con = DBConnect.ConnectDB();
            
        }
        string timee;

        private void button5_Click(object sender, EventArgs e)
        {
            SessionDash SessionDash = new SessionDash();
            SessionDash.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home Home = new Home();
            Home.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string Lec1 = cmb1Lec.Text;
            string Lec2 = cmb2Lec.Text;
            string Grp = cmbGrp.Text;
            string Subject = comboBox3.Text;
            string Tag = cmbTimeSlot.Text;
            string TagType = txtShowTag.Text;
            string Day = cmbDay.Text;
            string NoOfStd = txtNoOfStd.Text;
            lblAllDetails.Text = Lec1 + "," + Lec2 + "," + Grp + "," + Subject + "," + Tag + "," + TagType + "," + NoOfStd;
            //lblAllDetails;
            con.Open();
            try
            {
                string qu = "INSERT INTO addSesstion (`firstLec`, `secondLec`, `tag`, `tagType`, `grp`, `subject`, `noOfStd`, `day`, `room`, `time`, `AllDetails`) VALUES ('" + cmb1Lec.Text + "','" + cmb2Lec.Text + "','" + cmbTimeSlot.Text + "','" + txtShowTag.Text + "','" + cmbGrp.Text + "','" + comboBox3.Text + "','" + txtNoOfStd.Text + "','" + cmbDay.Text + "','NULL','" + timee + "','" + lblAllDetails.Text + "')";
                MySqlCommand cm = new MySqlCommand(qu, con);
                cm.ExecuteNonQuery();
                MessageBox.Show("Insert successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void cmb1Lec_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                string qu = "SELECT  Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday, WrkTimePerDay FROM workingdays WHERE EmpID = (SELECT EmpID FROM addlecture WHERE LecName = '" + cmb1Lec.Text + "')";
                MySqlCommand cm = new MySqlCommand(qu, con);
                MySqlDataAdapter da = new MySqlDataAdapter(cm);

                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvLec1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void cmb1Lec_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                cmb1Lec.Items.Clear();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT LecName FROM addlecture WHERE Department = '" + cmbDepartment.Text + "' AND Center = '" + cmbCenter.Text + "' AND Faculty = '" + cmbFaculty.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    cmb1Lec.Items.Add(dr["LecName"].ToString());
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void cmb2Lec_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                cmb2Lec.Items.Clear();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT LecName FROM addlecture WHERE Department = '" + cmbDepartment.Text + "' AND Center = '" + cmbCenter.Text + "' AND Faculty = '" + cmbFaculty.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    cmb2Lec.Items.Add(dr["LecName"].ToString());
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void cmbTimeSlot_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                cmbTimeSlot.Items.Clear();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT SubjectTagCode FROM addtag";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    cmbTimeSlot.Items.Add(dr["SubjectTagCode"].ToString());
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void cmbGrp_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                cmbGrp.Items.Clear();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT GrpID FROM addstudentgrp";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    cmbGrp.Items.Add(dr["GrpID"].ToString());
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void comboBox3_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                comboBox3.Items.Clear();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT SubjectName FROM addsubject";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    comboBox3.Items.Add(dr["SubjectName"].ToString());
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNoOfStd.Clear();
            
            timee = string.Empty;
            cmbDay.Text = string.Empty;
            cmbTimeSlot.Text = string.Empty;
            cmb1Lec.Text = string.Empty;
            cmb2Lec.Text = string.Empty;
            cmbTimeSlot.Text = string.Empty;
            cmbGrp.Text = string.Empty;
            comboBox3.Text = string.Empty;
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void btnShowTag_Click(object sender, EventArgs e)
        {
           
        }

        private void cmb2Lec_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                string qu = "SELECT  Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday, WrkTimePerDay FROM workingdays WHERE EmpID = (SELECT EmpID FROM addlecture WHERE LecName = '" + cmb2Lec.Text + "')";
                MySqlCommand cm = new MySqlCommand(qu, con);
                MySqlDataAdapter da = new MySqlDataAdapter(cm);

                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvLec2.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void cmbTimeSlot_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                string qu = "SELECT RelatedTag FROM addtag WHERE SubjectTagCode = '" + cmbTimeSlot.Text + "'";
                MySqlCommand mcm = new MySqlCommand(qu, con);
                MySqlDataReader sdr = mcm.ExecuteReader();
                while (sdr.Read())
                {
                    txtShowTag.Text = sdr.GetValue(0).ToString();
                }
                //mcm.ExecuteNonQuery();
                //MessageBox.Show("Insert successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        

        private void cmbFaculty_Click(object sender, EventArgs e)
        {
            
        }

        private void cmbFaculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            string fac = this.cmbFaculty.SelectedItem.ToString();
            if (fac == "Computing")
            {
                cmbDepartment.Items.Add("Computer Sciance");
                cmbDepartment.Items.Add("Software engneering");
                cmbDepartment.Items.Add("Business studies and software engneering");
                cmbDepartment.Items.Add("Information systems");
            }
            else if (fac == "Engineering")
            {
                cmbDepartment.Items.Add("Civil Engneering");
                cmbDepartment.Items.Add("Electrical and electronic engneering");
                cmbDepartment.Items.Add("Megatronic engneering");
            }
            else if (fac == "Business")
            {
                cmbDepartment.Items.Add("Business studies and analysis");
                cmbDepartment.Items.Add("Business studies");
            }
            else if (fac == "Sciences")
            {
                cmbDepartment.Items.Add("Medicine");
                cmbDepartment.Items.Add("Vetnory");
                cmbDepartment.Items.Add("Dental Surgen");
            }
        }

        private void cmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtShowTag_TextChanged(object sender, EventArgs e)
        {

        }

        private void rbnMorning_CheckedChanged(object sender, EventArgs e)
        {
           timee = "8.00 AM to 12.00 PM";
        }

        private void rbnEvening_CheckedChanged(object sender, EventArgs e)
        {
            timee = "1.00 PM to 5.00 PM";
        }

        private void cmbGrp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
