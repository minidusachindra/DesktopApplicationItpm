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
    public partial class ManageTag : Form
    {
        MySqlConnection con = null;
        MySqlConnection con2 = null;
        public ManageTag()
        {
            InitializeComponent();
            con = DBConnect.ConnectDB();
            con2 = DBConnect.ConnectDB();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home Home = new Home();
            Home.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TagDash TagDash = new TagDash();
            TagDash.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            con2.Open();
            try
            {
                string qu = "SELECT `SubjectTagName` as TAGNAME , `SubjectTagCode` as TAGCODE ,`RelatedTag` as TAG FROM `addtag` WHERE SubjectTagCode = '" + txtSubCodeSearch.Text + "'";
                MySqlCommand mcm = new MySqlCommand(qu, con2);
                MySqlDataReader sdr = mcm.ExecuteReader();
                while (sdr.Read())
                {
                    txtSubjectTagName.Text = sdr.GetValue(0).ToString();
                    txtSubjectTagCode.Text = sdr.GetValue(1).ToString();
                    cmbRelatedTag.Text = sdr.GetValue(2).ToString();
                   
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con2.Close();
        }

        private void buttonview_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                string qu = "SELECT `SubjectTagName` as TAGNAME , `SubjectTagCode` as TAGCODE ,`RelatedTag` as TAG FROM `addtag`";
                MySqlCommand cm = new MySqlCommand(qu, con);
                MySqlDataAdapter da = new MySqlDataAdapter(cm);

                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvMgTag.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                string qu = "DELETE FROM `addtag` WHERE SubjectTagCode = '" + txtSubjectTagCode.Text + "'";
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

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                string qu = "UPDATE `addtag` SET `SubjectTagName`='" + txtSubjectTagName.Text + "',`SubjectTagCode`='" + txtSubjectTagCode.Text + "',`RelatedTag`='" + cmbRelatedTag.Text + "' WHERE SubjectTagCode = '" + txtSubjectTagCode.Text + "'";
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

        private void button2_Click(object sender, EventArgs e)
        {
            txtSubjectTagName.Clear();
            txtSubjectTagCode.Clear();
            cmbRelatedTag.Text = string.Empty;
        }
    }
}
