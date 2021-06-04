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
    public partial class NotAvailableTime : Form
    {
        MySqlConnection con = null;
        MySqlConnection con2 = null;
        public NotAvailableTime()
        {
            InitializeComponent();
            con = DBConnect.ConnectDB();
            con2 = DBConnect.ConnectDB();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            SessionDash SessionDash = new SessionDash();
            SessionDash.Show();
            this.Hide();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Home Home = new Home();
            Home.Show();
            this.Hide();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                string qu = "INSERT INTO `nottime`(`Lname`, `Ngroup`, `Sugrop`,`Lroom`,`time`,`day` ) VALUES ('" + cmb1Lec.Text + "','" + cmbGrop.Text + "','" + cmbSuGrp.Text + "','" + cmbLecr.Text + "','" + textTime.Text + "','" + cmbDay.Text + "')";
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

        private void btnView_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                string qu = "SELECT `Lname` as LECTURENAME , `Ngroup` as STUDENTGROUP , `Sugrop` as SUBGROUP ,`Lroom` as LECTUREHALL ,`time` as TIME ,`day` as DAY FROM `nottime`";
                MySqlCommand cm = new MySqlCommand(qu, con);
                MySqlDataAdapter da = new MySqlDataAdapter(cm);

                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvMngeNt.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                string qu = "UPDATE `nottime` SET `Lname`='" + cmb1Lec.Text + "',`Ngroup`='" + cmbGrop.Text + "',`Sugrop`='" + cmbSuGrp.Text + "',`Lroom`='" + cmbLecr.Text + "',`time`='" + textTime.Text + "',`day`='" + cmbDay.Text + "' WHERE day = '" + cmbDay.Text + "'";
                MySqlCommand cm = new MySqlCommand(qu, con);
                cm.ExecuteNonQuery();
                MessageBox.Show("Update succesfully");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            con2.Open();
            try
            {
                string qu = "SELECT `Lname`, `Ngroup`, `Sugrop`,`Lroom` ,`time` ,`day` FROM `nottime` WHERE day = '" + cmbSrch.Text + "'";
                MySqlCommand mcm = new MySqlCommand(qu, con2);
                MySqlDataReader sdr = mcm.ExecuteReader();
                while (sdr.Read())
                {
                    cmb1Lec.Text = sdr.GetValue(0).ToString();
                    cmbGrop.Text = sdr.GetValue(1).ToString();
                    cmbSuGrp.Text = sdr.GetValue(2).ToString();
                    cmbLecr.Text = sdr.GetValue(3).ToString();
                    textTime.Text = sdr.GetValue(4).ToString();
                    cmbDay.Text = sdr.GetValue(5).ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con2.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cmb1Lec.Text = string.Empty;
            cmbGrop.Text = string.Empty;
            cmbSuGrp.Text = string.Empty;
            cmbLecr.Text = string.Empty;
            textTime.Clear();

            cmbDay.Text = string.Empty;
            cmbSrch.Text = string.Empty;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                string qu = "DELETE FROM `nottime` WHERE day = '" + cmbSrch.Text + "'";
                MySqlCommand cm = new MySqlCommand(qu, con);
                cm.ExecuteNonQuery();
                MessageBox.Show("Deleted succesfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }
    }
    }
