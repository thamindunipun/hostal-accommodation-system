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
    public partial class Search : Form
    {
        const string cn = "datasource=localhost; user=root; password=; database=uovd";
        public Search()
        {
            InitializeComponent();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            setData();
          //  label7.Show();
        }

        public void setData()
        { 
            //label 7
            MySqlConnection con = new MySqlConnection(cn);
            MySqlCommand cmd = new MySqlCommand("select name from streg where regno='"+ tx1.Text+ "'", con);
            MySqlDataReader reader1;
            con.Open();
            reader1 = cmd.ExecuteReader();
            if (reader1.Read())
            {
                label7.Text = reader1[0].ToString();
            }
            con.Close();

            //label 8
            MySqlConnection con2 = new MySqlConnection(cn);
            MySqlCommand cmd2 = new MySqlCommand("select sid from streg where regno='" + tx1.Text + "'", con2);
            MySqlDataReader reader2;
            con2.Open();
            reader2 = cmd2.ExecuteReader();
            if (reader2.Read())
            {
                label8.Text = reader2[0].ToString();
            }
            con2.Close();

            //label 9
            MySqlConnection con3 = new MySqlConnection(cn);
            MySqlCommand cmd3 = new MySqlCommand("select mobno from streg where regno='" + tx1.Text + "'", con3);
            MySqlDataReader reader3;
            con3.Open();
            reader3 = cmd3.ExecuteReader();
            if (reader3.Read())
            {
                label9.Text = reader3[0].ToString();
            }
            con3.Close();

            //label 10

            MySqlConnection con4 = new MySqlConnection(cn);
            MySqlCommand cmd4 = new MySqlCommand("select address from streg where regno='" + tx1.Text + "'", con4);
            MySqlDataReader reader4;
            con4.Open();
            reader4 = cmd4.ExecuteReader();
            if (reader4.Read())
            {
                label10.Text = reader4[0].ToString();
            }
            con4.Close();

            //lebal 11

            MySqlConnection con5 = new MySqlConnection(cn);
            MySqlCommand cmd5 = new MySqlCommand("select gender from streg where regno='" + tx1.Text + "'", con5);
            MySqlDataReader reader5;
            con5.Open();
            reader5 = cmd5.ExecuteReader();
            if (reader5.Read())
            {
                label11.Text = reader5[0].ToString();
            }
            con5.Close();
           

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            new Home().Show();
            this.Hide();
        }

        private void Search_Load(object sender, EventArgs e)
        {
          /*  string ID="";
            MySqlConnection con = new MySqlConnection(cn);
            MySqlCommand cmd=new MySqlCommand("select * from [streg] where ( sid= '"+ ID + "')",con);
            MySqlDataReader reader;
            con.Open();
            reader = cmd.ExecuteReader();
            if(reader.Read())
            {
                ID = reader[0].ToString();
            }
            con.Close();
           */
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
