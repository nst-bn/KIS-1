using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            LoadSalesReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void LoadSalesReport()
        {
            chart1.Titles.Add("Отчет по ценам");    
            string connectString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=KIS;Integrated Security=True;Pooling=False";

            SqlConnection myConnection = new SqlConnection(connectString);
            int n = 0;
            myConnection.Open();

            string query = "SELECT * FROM SalesRreportTable ";

            SqlCommand command = new SqlCommand(query, myConnection);

            SqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[4]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                n++;
            }

            reader.Close();

            myConnection.Close();

            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);
            
            for (int i = 0; i < n; ++i)
            {
                chart1.Series[0].Points.AddY(data[i][2]);
                chart1.Series[0].Points[i].LegendText = data[i][1];
            }
        }
    }
}
