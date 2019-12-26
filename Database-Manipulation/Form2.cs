using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Timers;


namespace Database_Manipulation
{
    public partial class Form2 : Form
    {

        SqlConnection con = new SqlConnection();
        SqlCommand comm = new SqlCommand();

        public Form2()
        {
            InitializeComponent();
        }

        private void info1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_add_cat_Click(object sender, EventArgs e)
        {
            Form form_cat = new Category();
            bunifuTransition1.ShowSync(form_cat);
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_add_product_Click(object sender, EventArgs e)
        {
        //    if (txt_name.Text != "" || txt_owner.Text != "" || category.Text != "" || txt_price.Text != "")
        //    {

        //        try
        //        {
        //            con.ConnectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=c:\users\dell\source\repos\Database-Manipulation\Database-Manipulation\Database1.mdf;Integrated Security=True");
        //            con.Open();

        //            comm.Connection = con;
        //            comm.CommandText = "INSERT INTO product VALUES (@title, @owner, @category, @img, @date, @price, @rate)";
        //            comm.Parameters.AddWithValue("@title", txt_name.Text);
        //            comm.Parameters.AddWithValue("@owner", txt_name.Text);
        //            comm.Parameters.AddWithValue("@category", category.Text);
        //            comm.Parameters.AddWithValue("@img", "");
        //            comm.Parameters.AddWithValue("@date", date.Value);
        //            comm.Parameters.AddWithValue("@price", txt_price.Text);
        //            comm.Parameters.AddWithValue("@rate", rate.Value);


        //            comm.ExecuteNonQuery();

        //            con.Close();

        //           // timer.Interval = 2000;
        //           //    timer.Enabled = true;
        //            MessageBox.Show("Inserted into database");

        //        }
        //        catch
        //        {
        //            MessageBox.Show("Oops... something went rong!");
        //        }




        //    }
        //    else
        //    {
        //        MessageBox.Show("Please enter category");
        //    }
        }
    }
}
