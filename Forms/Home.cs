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

namespace UOV
{
    public partial class Home : Form
    {
        private Button currentBtn;
        private Form activeForm;
        public Home()
        {
            InitializeComponent();
            //connect with database
            /*string DB = "server=127.0.0.1; user=root; database=hosteldb; password=";
            MySqlConnection mySqlConnection = new MySqlConnection(DB);
            try
            {
                mySqlConnection.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                mySqlConnection.Close();
            }*/
        }
        private void ActiveButton(object btnsender)
        {
            if (btnsender != null)
            {
                if (currentBtn != (Button)btnsender)
                {
                    //Color color = Color.White;
                    DisableButton();
                    currentBtn = (Button)btnsender;
                    currentBtn.BackColor = Color.FromArgb(51, 51, 76);
                  //currentBtn.ForeColor = Color.White;
                    currentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));

                }

            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panel1.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.DimGray;
                    //previousBtn.ForeColor = Color.Black;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));

                }
            }
        }
        public void OpenchildForm(Form childForm, object btnsender)//child form working
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActiveButton(btnsender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.None;
            this.childL.Controls.Add(childForm);
            this.childL.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void Sbtn_Click(object sender, EventArgs e)
        {
             OpenchildForm(new Forms.Student(),sender);
           // ActiveButton(sender);
        }

        private void Rbtn_Click(object sender, EventArgs e)
        {
            OpenchildForm(new Forms.Room(), sender);
          //  ActiveButton(sender);
        }

        private void Hbtn_Click(object sender, EventArgs e)
        {
            OpenchildForm(new Forms.Search(), sender);
        }

        private void Ebtn_Click(object sender, EventArgs e)
        {
            OpenchildForm(new Forms.Employee(), sender);
        }
        //ActiveButton(sender);
    
        private void Cbtn_Click(object sender, EventArgs e)
        {
            OpenchildForm(new Forms.Ca(), sender);
            //ActiveButton(sender);
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
