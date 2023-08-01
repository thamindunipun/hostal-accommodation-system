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

namespace UOV.Forms
{
    public partial class Medical : Form
    {
        const string cn = "datasource=localhost; user=root; password=; database=uovd";
        public Medical()
        {
            InitializeComponent();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            saveData();
            MessageBox.Show("Query ok");
            new Student().Show();
            this.Hide();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Mtx1.Clear();
            Mtx2.Clear();
            Mtx1.Focus();
        }
        private void saveData()
        {
            try
            {
                MySqlConnection con = new MySqlConnection(cn);
                //  MySql.Data.MySqlClient.MySqlCommand con = new MySql.Data.MySqlClient.MySqlCommand(cn);
                MySqlCommand cmd = new MySqlCommand("insert into smedi(regno,mrec) values('" + Mtx1.Text + "','" + Mtx2.Text + "')", con);
                con.Open();
                cmd.ExecuteReader();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
