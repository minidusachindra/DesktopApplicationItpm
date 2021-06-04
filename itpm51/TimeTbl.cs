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
    public partial class TimeTbl : Form
    {
        MySqlConnection con = null;
        public TimeTbl()
        {
            InitializeComponent();
            con = DBConnect.ConnectDB();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                string qu = "SELECT `AllDetails`, `room` FROM `addsesstion` WHERE `grp` = '" + cmbGrp.Text + "' AND `day` = 'Monday' AND `time` = '8.00 AM to 12.00 PM'";
                MySqlCommand cm = new MySqlCommand(qu, con);
                string rcount = Convert.ToString(cm.ExecuteScalar());
                cm.Dispose();

                txtMonMor.Text = rcount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            con.Open();
            try
            {
                string qu = "SELECT `AllDetails`, `room` FROM `addsesstion` WHERE `grp` = '" + cmbGrp.Text + "' AND `day` = 'Tuesday' AND `time` = '8.00 AM to 12.00 PM'";
                MySqlCommand cm = new MySqlCommand(qu, con);
                string rcount = Convert.ToString(cm.ExecuteScalar());
                cm.Dispose();

                txtTheMor.Text = rcount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            con.Open();
            try
            {
                string qu = "SELECT `AllDetails`, `room` FROM `addsesstion` WHERE `grp` = '" + cmbGrp.Text + "' AND `day` = 'Wednesday' AND `time` = '8.00 AM to 12.00 PM'";
                MySqlCommand cm = new MySqlCommand(qu, con);
                string rcount = Convert.ToString(cm.ExecuteScalar());
                cm.Dispose();

                txtWedMor.Text = rcount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            con.Open();
            try
            {
                string qu = "SELECT `AllDetails`, `room` FROM `addsesstion` WHERE `grp` = '" + cmbGrp.Text + "' AND `day` = 'Thursday' AND `time` = '8.00 AM to 12.00 PM'";
                MySqlCommand cm = new MySqlCommand(qu, con);
                string rcount = Convert.ToString(cm.ExecuteScalar());
                cm.Dispose();

                txtThuMor.Text = rcount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            con.Open();
            try
            {
                string qu = "SELECT `AllDetails`, `room` FROM `addsesstion` WHERE `grp` = '" + cmbGrp.Text + "' AND `day` = 'Friday' AND `time` = '8.00 AM to 12.00 PM'";
                MySqlCommand cm = new MySqlCommand(qu, con);
                string rcount = Convert.ToString(cm.ExecuteScalar());
                cm.Dispose();

                txtFriMor.Text = rcount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            con.Open();
            try
            {
                string qu = "SELECT `AllDetails`, `room` FROM `addsesstion` WHERE `grp` = '" + cmbGrp.Text + "' AND `day` = 'Saturday' AND `time` = '8.00 AM to 12.00 PM'";
                MySqlCommand cm = new MySqlCommand(qu, con);
                string rcount = Convert.ToString(cm.ExecuteScalar());
                cm.Dispose();

                txtSatMor.Text = rcount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            con.Open();
            try
            {
                string qu = "SELECT `AllDetails`, `room` FROM `addsesstion` WHERE `grp` = '" + cmbGrp.Text + "' AND `day` = 'Sunday' AND `time` = '8.00 AM to 12.00 PM'";
                MySqlCommand cm = new MySqlCommand(qu, con);
                string rcount = Convert.ToString(cm.ExecuteScalar());
                cm.Dispose();

                txtSunMor.Text = rcount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            //Evening
            con.Open();
            try
            {
                string qu = "SELECT `AllDetails`, `room` FROM `addsesstion` WHERE `grp` = '" + cmbGrp.Text + "' AND `day` = 'Monday' AND `time` = '1.00 PM to 5.00 PM'";
                MySqlCommand cm = new MySqlCommand(qu, con);
                string rcount = Convert.ToString(cm.ExecuteScalar());
                cm.Dispose();

                txtMonEve.Text = rcount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            con.Open();
            try
            {
                string qu = "SELECT `AllDetails`, `room` FROM `addsesstion` WHERE `grp` = '" + cmbGrp.Text + "' AND `day` = 'Tuesday' AND `time` = '1.00 PM to 5.00 PM'";
                MySqlCommand cm = new MySqlCommand(qu, con);
                string rcount = Convert.ToString(cm.ExecuteScalar());
                cm.Dispose();

                txtTheEve.Text = rcount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            con.Open();
            try
            {
                string qu = "SELECT `AllDetails`, `room` FROM `addsesstion` WHERE `grp` = '" + cmbGrp.Text + "' AND `day` = 'Wednesday' AND `time` = '1.00 PM to 5.00 PM'";
                MySqlCommand cm = new MySqlCommand(qu, con);
                string rcount = Convert.ToString(cm.ExecuteScalar());
                cm.Dispose();

                txtWedEve.Text = rcount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            con.Open();
            try
            {
                string qu = "SELECT `AllDetails`, `room` FROM `addsesstion` WHERE `grp` = '" + cmbGrp.Text + "' AND `day` = 'Thursday' AND `time` = '1.00 PM to 5.00 PM'";
                MySqlCommand cm = new MySqlCommand(qu, con);
                string rcount = Convert.ToString(cm.ExecuteScalar());
                cm.Dispose();

                txtThuEve.Text = rcount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            con.Open();
            try
            {
                string qu = "SELECT `AllDetails`, `room` FROM `addsesstion` WHERE `grp` = '" + cmbGrp.Text + "' AND `day` = 'Friday' AND `time` = '1.00 PM to 5.00 PM'";
                MySqlCommand cm = new MySqlCommand(qu, con);
                string rcount = Convert.ToString(cm.ExecuteScalar());
                cm.Dispose();

                txtFriEve.Text = rcount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            con.Open();
            try
            {
                string qu = "SELECT `AllDetails`, `room` FROM `addsesstion` WHERE `grp` = '" + cmbGrp.Text + "' AND `day` = 'Saturday' AND `time` = '1.00 PM to 5.00 PM'";
                MySqlCommand cm = new MySqlCommand(qu, con);
                string rcount = Convert.ToString(cm.ExecuteScalar());
                cm.Dispose();

                txtSatEve.Text = rcount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            con.Open();
            try
            {
                string qu = "SELECT `AllDetails`, `room` FROM `addsesstion` WHERE `grp` = '" + cmbGrp.Text + "' AND `day` = 'Sunday' AND `time` = '1.00 PM to 5.00 PM'";
                MySqlCommand cm = new MySqlCommand(qu, con);
                string rcount = Convert.ToString(cm.ExecuteScalar());
                cm.Dispose();

                txtSunEve.Text = rcount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void btnLecGenerate_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                string qu = "SELECT `AllDetails`, `room` FROM `addsesstion` WHERE `firstLec` = '" + cmb1Lec.Text + "' AND `secondLec` = '" + cmb2Lec.Text + "' AND `day` = 'Monday' AND `time` = '8.00 AM to 12.00 PM'";
                MySqlCommand cm = new MySqlCommand(qu, con);
                string rcount = Convert.ToString(cm.ExecuteScalar());
                cm.Dispose();

                txtMonLecMor.Text = rcount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            con.Open();
            try
            {
                string qu = "SELECT `AllDetails`, `room` FROM `addsesstion` WHERE `firstLec` = '" + cmb1Lec.Text + "' AND `secondLec` = '" + cmb2Lec.Text + "' AND `day` = 'Tuesday' AND `time` = '8.00 AM to 12.00 PM'";
                MySqlCommand cm = new MySqlCommand(qu, con);
                string rcount = Convert.ToString(cm.ExecuteScalar());
                cm.Dispose();

                txtTheLecMor.Text = rcount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            con.Open();
            try
            {
                string qu = "SELECT `AllDetails`, `room` FROM `addsesstion` WHERE `firstLec` = '" + cmb1Lec.Text + "' AND `secondLec` = '" + cmb2Lec.Text + "' AND `day` = 'Wednesday' AND `time` = '8.00 AM to 12.00 PM'";
                MySqlCommand cm = new MySqlCommand(qu, con);
                string rcount = Convert.ToString(cm.ExecuteScalar());
                cm.Dispose();

                txtWedLecMor.Text = rcount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            con.Open();
            try
            {
                string qu = "SELECT `AllDetails`, `room` FROM `addsesstion` WHERE `firstLec` = '" + cmb1Lec.Text + "' AND `secondLec` = '" + cmb2Lec.Text + "' AND `day` = 'Thursday' AND `time` = '8.00 AM to 12.00 PM'";
                MySqlCommand cm = new MySqlCommand(qu, con);
                string rcount = Convert.ToString(cm.ExecuteScalar());
                cm.Dispose();

                txtThuLecMor.Text = rcount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            con.Open();
            try
            {
                string qu = "SELECT `AllDetails`, `room` FROM `addsesstion` WHERE `firstLec` = '" + cmb1Lec.Text + "' AND `secondLec` = '" + cmb2Lec.Text + "' AND `day` = 'Friday' AND `time` = '8.00 AM to 12.00 PM'";
                MySqlCommand cm = new MySqlCommand(qu, con);
                string rcount = Convert.ToString(cm.ExecuteScalar());
                cm.Dispose();

                txtFriLecMor.Text = rcount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            con.Open();
            try
            {
                string qu = "SELECT `AllDetails`, `room` FROM `addsesstion` WHERE `firstLec` = '" + cmb1Lec.Text + "' AND `secondLec` = '" + cmb2Lec.Text + "' AND `day` = 'Saturday' AND `time` = '8.00 AM to 12.00 PM'";
                MySqlCommand cm = new MySqlCommand(qu, con);
                string rcount = Convert.ToString(cm.ExecuteScalar());
                cm.Dispose();

                txtSatLecMor.Text = rcount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            con.Open();
            try
            {
                string qu = "SELECT `AllDetails`, `room` FROM `addsesstion` WHERE `firstLec` = '" + cmb1Lec.Text + "' AND `secondLec` = '" + cmb2Lec.Text + "' AND `day` = 'Sunday' AND `time` = '8.00 AM to 12.00 PM'";
                MySqlCommand cm = new MySqlCommand(qu, con);
                string rcount = Convert.ToString(cm.ExecuteScalar());
                cm.Dispose();

                txtSunLecMor.Text = rcount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            //Evening

            con.Open();
            try
            {
                string qu = "SELECT `AllDetails`, `room` FROM `addsesstion` WHERE `firstLec` = '" + cmb1Lec.Text + "' AND `secondLec` = '" + cmb2Lec.Text + "' AND `day` = 'Monday' AND `time` = '1.00 PM to 5.00 PM'";
                MySqlCommand cm = new MySqlCommand(qu, con);
                string rcount = Convert.ToString(cm.ExecuteScalar());
                cm.Dispose();

                txtMonLecEve.Text = rcount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            con.Open();
            try
            {
                string qu = "SELECT `AllDetails`, `room` FROM `addsesstion` WHERE `firstLec` = '" + cmb1Lec.Text + "' AND `secondLec` = '" + cmb2Lec.Text + "' AND `day` = 'Tuesday' AND `time` = '1.00 PM to 5.00 PM'";
                MySqlCommand cm = new MySqlCommand(qu, con);
                string rcount = Convert.ToString(cm.ExecuteScalar());
                cm.Dispose();

                txtTheLecEve.Text = rcount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            con.Open();
            try
            {
                string qu = "SELECT `AllDetails`, `room` FROM `addsesstion` WHERE `firstLec` = '" + cmb1Lec.Text + "' AND `secondLec` = '" + cmb2Lec.Text + "' AND `day` = 'Wednesday' AND `time` = '1.00 PM to 5.00 PM'";
                MySqlCommand cm = new MySqlCommand(qu, con);
                string rcount = Convert.ToString(cm.ExecuteScalar());
                cm.Dispose();

                txtWedLecEve.Text = rcount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            con.Open();
            try
            {
                string qu = "SELECT `AllDetails`, `room` FROM `addsesstion` WHERE `firstLec` = '" + cmb1Lec.Text + "' AND `secondLec` = '" + cmb2Lec.Text + "' AND `day` = 'Thursday' AND `time` = '1.00 PM to 5.00 PM'";
                MySqlCommand cm = new MySqlCommand(qu, con);
                string rcount = Convert.ToString(cm.ExecuteScalar());
                cm.Dispose();

                txtThuLecEve.Text = rcount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            con.Open();
            try
            {
                string qu = "SELECT `AllDetails`, `room` FROM `addsesstion` WHERE `firstLec` = '" + cmb1Lec.Text + "' AND `secondLec` = '" + cmb2Lec.Text + "' AND `day` = 'Friday' AND `time` = '1.00 PM to 5.00 PM'";
                MySqlCommand cm = new MySqlCommand(qu, con);
                string rcount = Convert.ToString(cm.ExecuteScalar());
                cm.Dispose();

                txtFriLecEve.Text = rcount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            con.Open();
            try
            {
                string qu = "SELECT `AllDetails`, `room` FROM `addsesstion` WHERE `firstLec` = '" + cmb1Lec.Text + "' AND `secondLec` = '" + cmb2Lec.Text + "' AND `day` = 'Saturday' AND `time` = '1.00 PM to 5.00 PM'";
                MySqlCommand cm = new MySqlCommand(qu, con);
                string rcount = Convert.ToString(cm.ExecuteScalar());
                cm.Dispose();

                txtSatLecEve.Text = rcount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            con.Open();
            try
            {
                string qu = "SELECT `AllDetails`, `room` FROM `addsesstion` WHERE `firstLec` = '" + cmb1Lec.Text + "' AND `secondLec` = '" + cmb2Lec.Text + "' AND `day` = 'Sunday' AND `time` = '1.00 PM to 5.00 PM'";
                MySqlCommand cm = new MySqlCommand(qu, con);
                string rcount = Convert.ToString(cm.ExecuteScalar());
                cm.Dispose();

                txtSunLecEve.Text = rcount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void btnLocGenerate_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                string qu = "SELECT `AllDetails`, `room` FROM `addsesstion` WHERE `room` = '" + cmbLocation.Text + "' AND `day` = 'Monday' AND `time` = '8.00 AM to 12.00 PM'";
                MySqlCommand cm = new MySqlCommand(qu, con);
                string rcount = Convert.ToString(cm.ExecuteScalar());
                cm.Dispose();

                richTextBox14.Text = rcount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            con.Open();
            try
            {
                string qu = "SELECT `AllDetails`, `room` FROM `addsesstion` WHERE `room` = '" + cmbLocation.Text + "' AND `day` = 'Tuesday' AND `time` = '8.00 AM to 12.00 PM'";
                MySqlCommand cm = new MySqlCommand(qu, con);
                string rcount = Convert.ToString(cm.ExecuteScalar());
                cm.Dispose();

                richTextBox13.Text = rcount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            con.Open();
            try
            {
                string qu = "SELECT `AllDetails`, `room` FROM `addsesstion` WHERE `room` = '" + cmbLocation.Text + "' AND `day` = 'Wednesday' AND `time` = '8.00 AM to 12.00 PM'";
                MySqlCommand cm = new MySqlCommand(qu, con);
                string rcount = Convert.ToString(cm.ExecuteScalar());
                cm.Dispose();

                richTextBox12.Text = rcount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            con.Open();
            try
            {
                string qu = "SELECT `AllDetails`, `room` FROM `addsesstion` WHERE `room` = '" + cmbLocation.Text + "' AND `day` = 'Thursday' AND `time` = '8.00 AM to 12.00 PM'";
                MySqlCommand cm = new MySqlCommand(qu, con);
                string rcount = Convert.ToString(cm.ExecuteScalar());
                cm.Dispose();

                richTextBox11.Text = rcount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            con.Open();
            try
            {
                string qu = "SELECT `AllDetails`, `room` FROM `addsesstion` WHERE `room` = '" + cmbLocation.Text + "' AND `day` = 'Friday' AND `time` = '8.00 AM to 12.00 PM'";
                MySqlCommand cm = new MySqlCommand(qu, con);
                string rcount = Convert.ToString(cm.ExecuteScalar());
                cm.Dispose();

                richTextBox10.Text = rcount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            con.Open();
            try
            {
                string qu = "SELECT `AllDetails`, `room` FROM `addsesstion` WHERE `room` = '" + cmbLocation.Text + "' AND `day` = 'Saturday' AND `time` = '8.00 AM to 12.00 PM'";
                MySqlCommand cm = new MySqlCommand(qu, con);
                string rcount = Convert.ToString(cm.ExecuteScalar());
                cm.Dispose();

                richTextBox9.Text = rcount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            con.Open();
            try
            {
                string qu = "SELECT `AllDetails`, `room` FROM `addsesstion` WHERE `room` = '" + cmbLocation.Text + "' AND `day` = 'Sunday' AND `time` = '8.00 AM to 12.00 PM'";
                MySqlCommand cm = new MySqlCommand(qu, con);
                string rcount = Convert.ToString(cm.ExecuteScalar());
                cm.Dispose();

                richTextBox8.Text = rcount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            //Evening

            con.Open();
            try
            {
                string qu = "SELECT `AllDetails`, `room` FROM `addsesstion` WHERE `room` = '" + cmbLocation.Text + "' AND `day` = 'Monday' AND `time` = '1.00 PM to 5.00 PM'";
                MySqlCommand cm = new MySqlCommand(qu, con);
                string rcount = Convert.ToString(cm.ExecuteScalar());
                cm.Dispose();

                richTextBox7.Text = rcount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            con.Open();
            try
            {
                string qu = "SELECT `AllDetails`, `room` FROM `addsesstion` WHERE `room` = '" + cmbLocation.Text + "' AND `day` = 'Tuesday' AND `time` = '1.00 PM to 5.00 PM'";
                MySqlCommand cm = new MySqlCommand(qu, con);
                string rcount = Convert.ToString(cm.ExecuteScalar());
                cm.Dispose();

                richTextBox6.Text = rcount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            con.Open();
            try
            {
                string qu = "SELECT `AllDetails`, `room` FROM `addsesstion` WHERE `room` = '" + cmbLocation.Text + "' AND `day` = 'Wednesday' AND `time` = '1.00 PM to 5.00 PM'";
                MySqlCommand cm = new MySqlCommand(qu, con);
                string rcount = Convert.ToString(cm.ExecuteScalar());
                cm.Dispose();

                richTextBox5.Text = rcount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            con.Open();
            try
            {
                string qu = "SELECT `AllDetails`, `room` FROM `addsesstion` WHERE `room` = '" + cmbLocation.Text + "' AND `day` = 'Thursday' AND `time` = '1.00 PM to 5.00 PM'";
                MySqlCommand cm = new MySqlCommand(qu, con);
                string rcount = Convert.ToString(cm.ExecuteScalar());
                cm.Dispose();

                richTextBox4.Text = rcount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            con.Open();
            try
            {
                string qu = "SELECT `AllDetails`, `room` FROM `addsesstion` WHERE `room` = '" + cmbLocation.Text + "' AND `day` = 'Friday' AND `time` = '1.00 PM to 5.00 PM'";
                MySqlCommand cm = new MySqlCommand(qu, con);
                string rcount = Convert.ToString(cm.ExecuteScalar());
                cm.Dispose();

                richTextBox3.Text = rcount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            con.Open();
            try
            {
                string qu = "SELECT `AllDetails`, `room` FROM `addsesstion` WHERE `room` = '" + cmbLocation.Text + "' AND `day` = 'Saturday' AND `time` = '1.00 PM to 5.00 PM'";
                MySqlCommand cm = new MySqlCommand(qu, con);
                string rcount = Convert.ToString(cm.ExecuteScalar());
                cm.Dispose();

                richTextBox2.Text = rcount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            con.Open();
            try
            {
                string qu = "SELECT `AllDetails`, `room` FROM `addsesstion` WHERE `room` = '" + cmbLocation.Text + "' AND `day` = 'Sunday' AND `time` = '1.00 PM to 5.00 PM'";
                MySqlCommand cm = new MySqlCommand(qu, con);
                string rcount = Convert.ToString(cm.ExecuteScalar());
                cm.Dispose();

                richTextBox1.Text = rcount.ToString();
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

        private void cmb1Lec_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                cmb1Lec.Items.Clear();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT LecName FROM addlecture";
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
                cmd.CommandText = "SELECT LecName FROM addlecture";
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

        private void cmbLocation_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                cmbLocation.Items.Clear();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT room FROM addsesstion";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    cmbLocation.Items.Add(dr["room"].ToString());
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Home Home = new Home();
            Home.Show();
            this.Hide();
        }
    }
}
