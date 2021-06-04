using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeTableM
{
    public partial class TagDash : Form
    {
        public TagDash()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home Home = new Home();
            Home.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddTag AddTag = new AddTag();
            AddTag.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ManageTag ManageTag = new ManageTag();
            ManageTag.Show();
            this.Hide();
        }
    }
}
