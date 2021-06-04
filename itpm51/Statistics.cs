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
    public partial class Statistics : Form
    {
        MySqlConnection con = null;
        public Statistics()
        {
            InitializeComponent();
            con = DBConnect.ConnectDB();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Home Home = new Home();
            Home.Show();
            this.Hide();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                string qu = "SELECT COUNT(EmpID) FROM addlecture";
                MySqlCommand cm = new MySqlCommand(qu, con);
                Int32 rcount = Convert.ToInt32(cm.ExecuteScalar());
                cm.Dispose();

                lblRegLecture.Text = rcount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            con.Open();
            try
            {
                string qu = "SELECT COUNT(SubjectTagCode) FROM addtag";
                MySqlCommand cm = new MySqlCommand(qu, con);
                Int32 rcount = Convert.ToInt32(cm.ExecuteScalar());
                cm.Dispose();

                lblRegStd.Text = rcount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            con.Open();
            try
            {
                string qu = "SELECT COUNT(SubjectCode) FROM addsubject";
                MySqlCommand cm = new MySqlCommand(qu, con);
                Int32 rcount = Convert.ToInt32(cm.ExecuteScalar());
                cm.Dispose();

                lblRegSubject.Text = rcount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            con.Open();
            try
            {
                string qu = "SELECT COUNT(roomName) FROM addlocation";
                MySqlCommand cm = new MySqlCommand(qu, con);
                Int32 rcount = Convert.ToInt32(cm.ExecuteScalar());
                cm.Dispose();

                lblRegRooms.Text = rcount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            con.Open();
            try
            {
                string qu = "SELECT `LecName` FROM `addlecture` ORDER BY `EmpID` DESC LIMIT 1;";
                MySqlCommand mcm = new MySqlCommand(qu, con);
                MySqlDataReader sdr = mcm.ExecuteReader();
                while (sdr.Read())
                {
                    txtLecName.Text = sdr.GetValue(0).ToString();
                }
                //mcm.ExecuteNonQuery();
                //MessageBox.Show("Insert successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            con.Open();
            try
            {
                string qu = "SELECT `GrpID` FROM `addstudentgrp` ORDER BY `GrpID` DESC LIMIT 1;";
                MySqlCommand mcm = new MySqlCommand(qu, con);
                MySqlDataReader sdr = mcm.ExecuteReader();
                while (sdr.Read())
                {
                    txtLgrp.Text = sdr.GetValue(0).ToString();
                }
                //mcm.ExecuteNonQuery();
                //MessageBox.Show("Insert successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            con.Open();
            try
            {
                string qu = "SELECT `SubjectName` FROM `addsubject` ORDER BY `SubjectCode` DESC LIMIT 1;";
                MySqlCommand mcm = new MySqlCommand(qu, con);
                MySqlDataReader sdr = mcm.ExecuteReader();
                while (sdr.Read())
                {
                    txtLSubject.Text = sdr.GetValue(0).ToString();
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
    }
}
