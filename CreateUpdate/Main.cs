using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using Dapper;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreateUpdate
{
    public partial class Main : Form
    {
        private string sourceConnectionStringSQLServer = "Server=localhost;Database=iotdb;User Id=sa;Password=12345678;";
        private string sourceConnectionStringPosgres = "Server=localhost;Database=iotdb;User Id=sa;Password=12345678;";
        public Main()
        {
            InitializeComponent();
        }

        private void btnCreateSQL_Click(object sender, EventArgs e)
        {
            string sqlQuery = txtQuerySQL.Text;
            if (string.IsNullOrEmpty(sqlQuery))
            {
                MessageBox.Show("Please enter a SQL query.");
                return;
            }

            try
            {
                using (var sourceConnection = new SqlConnection(sourceConnectionStringSQLServer))
                {
                    sourceConnection.Open();

                    var data = sourceConnection.Query(sqlQuery);
                    string filePath = "insert_commands.txt";

                    using (StreamWriter writer = new StreamWriter(filePath))
                    {
                        foreach (var row in data)
                        {
                            var insertCommand = GenerateInsertCommand("MST_LocaleResource", row);
                            writer.WriteLine(insertCommand);
                            txtReturnSQL.AppendText(insertCommand + Environment.NewLine);
                        }
                    }
                }

                MessageBox.Show("Data synchronization and export completed. The file is saved as insert_commands.txt.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private string GenerateInsertCommand(string tableName, dynamic row)
        {
            var columns = string.Join(", ", ((IDictionary<string, object>)row).Keys);
            var values = string.Join(", ", ((IDictionary<string, object>)row).Values.Select(v => $"'{v}'"));

            return $"INSERT INTO {tableName} ({columns}) VALUES ({values});";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
