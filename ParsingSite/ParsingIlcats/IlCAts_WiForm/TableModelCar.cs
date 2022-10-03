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
using System.Data.SqlClient;

namespace IlCAts_WiForm
{
    public partial class TableModelCar : Form
    {
        Database database = new Database();
        int selectedRow;

        public TableModelCar()
        {
            InitializeComponent();
        }
        private void CreateColumns ()
        {
            dataGridView1.Columns.Add("Id", "id");
            dataGridView1.Columns.Add("Name", "model name");
        }

        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(
                record.GetInt32(0),
                record.GetString(1)
                );
        }
        private void RefreshDataGridView(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string queryString = $"select * from Cars";

            SqlCommand command = new SqlCommand (queryString, database.GetConnection());
            database.OpenConnection();

            SqlDataReader reader = command.ExecuteReader();
            while(reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGridView(dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            RefreshDataGridView(dataGridView1);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];

                textBox_Name.Text = row.Cells[1].Value.ToString();
                textBox_Id.Text = row.Cells[0].Value.ToString();
               
            }

        }

        private void textBox_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Name_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button_Craete_Click(object sender, EventArgs e)
        {
            AddNewModelCar addForm = new AddNewModelCar();
            addForm.Show();
        }

      
    }
}
