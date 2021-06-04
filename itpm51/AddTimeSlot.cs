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
    public partial class AddTimeSlot : Form
    {
        MySqlConnection con = null;
        MySqlConnection con2 = null;
        public AddTimeSlot()
        {
            InitializeComponent();
            con = DBConnect.ConnectDB();
            con2 = DBConnect.ConnectDB();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddWorking AddWorking = new AddWorking();
            AddWorking.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home Home = new Home();
            Home.Show();
            this.Hide();
        }

        private void dateTimePicker1_MouseDown(object sender, MouseEventArgs e)
        {
            dateTimePicker1.CustomFormat = "HH:mm";
        }
        private void dateTimePicker1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back)
            {
                dateTimePicker1.CustomFormat = "";
            }
        }

        private void dateTimePicker2_MouseDown(object sender, MouseEventArgs e)
        {
            dateTimePicker2.CustomFormat = "HH:mm";
        }
        private void dateTimePicker2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back)
            {
                dateTimePicker2.CustomFormat = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                string qu = "INSERT INTO `addtime`(`timeID`, `StartTime`, `TimeSlot`, `EndTime`) VALUES ('" + txttimeID.Text + "','" + dateTimePicker1.Text + "','" + cmbTimeSlot.Text + "','" + dateTimePicker2.Text + "')";
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

        private void button6_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                string qu = "SELECT * FROM `addtime`";
                MySqlCommand cm = new MySqlCommand(qu, con);
                MySqlDataAdapter da = new MySqlDataAdapter(cm);

                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvManTime.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txttimeID.Clear();
            dateTimePicker1.Text = string.Empty;
            cmbTimeSlot.Text = string.Empty;
            dateTimePicker2.Text = string.Empty;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                string qu = "DELETE FROM `addtime`";
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
