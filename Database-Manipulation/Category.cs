using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Timers;


namespace Database_Manipulation
{
    public partial class Category : Form
    {

        SqlConnection con = new SqlConnection();
        SqlCommand comm = new SqlCommand();

        public Category()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_add_newCat_Click(object sender, EventArgs e)
        {
            if(txt_new_cat.Text != "")
            {

                try
                {
                    con.ConnectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=c:\users\dell\source\repos\Database-Manipulation\Database-Manipulation\Database1.mdf;Integrated Security=True");
                    con.Open();

                    comm.Connection = con;
                    comm.CommandText = "INSERT INTO cat VALUES (@cat)";
                    comm.Parameters.AddWithValue("@cat", txt_new_cat.Text);
                    comm.ExecuteNonQuery();

                    con.Close();

                    timer.Interval = 2000;
                    timer.Enabled = true;
                    MessageBox.Show("Inserted into database");

                }
                catch {
                    MessageBox.Show("Oops... something went rong!");
                }




            }
            else
            {
                MessageBox.Show("Please enter category");
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timer.Enabled = false;
            SendKeys.Send("{ESC}"); 
        }
    }
}
