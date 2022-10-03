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

namespace IlCAts_WiForm
{
    public partial class AddNewModelCar : Form
    {
        Database database = new Database();
        public AddNewModelCar()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            database.OpenConnection();

            var name = textBox_Name.Text;
            var code = textBox_Code.Text;
            var complectation = textBox_Complectation.Text;

            var addCommand = $"" +
                $"INSERT INTO Cars (Name) " +
                $"values ('{name}')" +

                $"INSERT INTO ModelCarType (Code, DateFrom, DateTo, Complectation, ModelCarId)" +
                $"values ('{code}', '{DateTime.Now}', '{DateTime.Now}', '{complectation}', (select top 1 Id from Cars order by Id desc) )";

            var command = new SqlCommand(addCommand, database.GetConnection());
            command.ExecuteNonQuery();

            MessageBox.Show("Sucessed!", "done", MessageBoxButtons.OK, MessageBoxIcon.Information);

            database.CloseConnection();
        }

        private void textBox_Code_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
