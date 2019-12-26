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

namespace Database_Manipulation
{
    public partial class Form1 : Form
    {

        SqlConnection con = new SqlConnection();
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable dt = new DataTable();

        public Form1()
        {
            InitializeComponent();
        }

        private void view_Click(object sender, EventArgs e)
        {

        }

        private void form_activated(object sender, EventArgs e)
        {
 
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            //var x = dataGridView1.Width;
            //var y = dataGridView1.Height;

            //dataGridView1.Scale(new SizeF(x, y));

            //x++;
            //y++;

            //   float fontSize = dataGridView1.DefaultCellStyle.Font.Size;
            var fontSize = dataGridView1.DefaultCellStyle.Font.Size;

            var headers = dataGridView1.ColumnHeadersDefaultCellStyle;
            var colmuns = dataGridView1.DefaultCellStyle;


            headers.Font = new Font("Calibri", fontSize + 2, FontStyle.Regular);
            colmuns.Font = new Font("Calibri", fontSize + 2, FontStyle.Regular);



        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {

            var fontSize = dataGridView1.DefaultCellStyle.Font.Size;

            var headers = dataGridView1.ColumnHeadersDefaultCellStyle;
            var colmuns = dataGridView1.DefaultCellStyle;


            headers.Font = new Font("Calibri", fontSize - 2, FontStyle.Regular);
            colmuns.Font = new Font("Calibri", fontSize - 2, FontStyle.Regular);

            //var x = dataGridView1.Width;
            //var y = dataGridView1.Height;

            //dataGridView1.Scale(new SizeF(x, y));

            //x--;
            //y--;
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Normal;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            Form form_add = new Form2();
            
            bunifuTransition1.ShowSync(form_add);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            con.ConnectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=c:\users\dell\source\repos\Database-Manipulation\Database-Manipulation\Database1.mdf;Integrated Security=True");

            var sql = "SELECT product_id, title, owner, category, price, rate FROM product";
            adapter = new SqlDataAdapter(sql, con);
            adapter.Fill(dt);


            dt.Columns["product_id"].ColumnName = "الرقم التسلسلي";
            dt.Columns["title"].ColumnName = "العنوان";
            dt.Columns["owner"].ColumnName = "المالك";
            dt.Columns["category"].ColumnName = "الفئة";
            dt.Columns["price"].ColumnName = "السعر";
            dt.Columns["rate"].ColumnName = "التقييم";


            dataGridView1.DataSource = dt;
        }
    }
}
