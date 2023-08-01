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
    public partial class Empr : Form
    {
        const string cn = "datasource=localhost; user=root; password=; database=uovd";

        public Empr()
        {
            InitializeComponent();
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

      /*  private void bunifuThinButton23_Click(object sender, EventArgs e)
        {

            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();

                openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";
                openFileDialog.Multiselect = false;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Rt4.Image = new Bitmap(openFileDialog.FileName);
                }
            }
            
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }
      */

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            saveData();
            MessageBox.Show("Query Ok");
            new Employee().Show();
            this.Hide();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            //clear all text 
            Rt1.Clear();
            Rt2.Clear();
            Rt3.Clear();
            Rt5.Clear();
            Rt1.Focus();
        }
        private void saveData()
        {
            try
            {
                MySqlConnection con = new MySqlConnection(cn);
                //  MySql.Data.MySqlClient.MySqlCommand con = new MySql.Data.MySqlClient.MySqlCommand(cn);
                MySqlCommand cmd = new MySqlCommand("insert into ereg(ename,eaddress,eid,designation,gender,mob) values('" + Rt1.Text + "','" + Rt2.Text + "','" + Rt3.Text + "' ,'" + Rt5.Text + "' ,'" + Rc2.Text + "','" + rt.Text + "')", con);
                con.Open();
                cmd.ExecuteReader();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Rt1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
