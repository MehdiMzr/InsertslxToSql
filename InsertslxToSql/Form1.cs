using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace InsertslxToSql
{
    public partial class Form1 : Form
    {
        OleDbConnection _excellConnection;
        SqlConnection _connection;

        string ExcelString, Query, ConnectionString;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {

          
                OpenFileD.Title = "انتخاب فایل";
                OpenFileD.FileName = "";
                OpenFileD.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
                DialogResult result = OpenFileD.ShowDialog();
                if (result == DialogResult.OK)
                {
                    lblPath.Text = OpenFileD.FileName;
                }
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            InsertToDatabase(lblPath.Text);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var connection = @"Data Source=.;Initial Catalog=uni;integrated security=true;";

            UpdateGrid(connection);

        }

        private void InsertToDatabase(string FilePath)
        {
            ExcelString =
                string.Format(
                    @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=""Excel 12.0 Xml;HDR=YES;""",
                    FilePath);
            _excellConnection = new OleDbConnection(ExcelString);


            Query = string.Format("Select [ID],[Name],[Family] FROM [{0}]", "Sheet1$");
            OleDbCommand Ecom = new OleDbCommand(Query, _excellConnection);
            _excellConnection.Open();


            DataSet dataSet = new DataSet();
            OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(Query, _excellConnection);
            _excellConnection.Close();



            oleDbDataAdapter.Fill(dataSet);
            DataTable excellDataSet = dataSet.Tables[0];

            ConnectionString = @"Data Source=.;Initial Catalog=uni;integrated security=true;";
            _connection = new SqlConnection(ConnectionString);

            SqlBulkCopy sqlBulkCopy = new SqlBulkCopy(_connection);



            sqlBulkCopy.DestinationTableName = "People";
            sqlBulkCopy.ColumnMappings.Add("ID", "ID");
            sqlBulkCopy.ColumnMappings.Add("Name", "Name");
            sqlBulkCopy.ColumnMappings.Add("Family", "Family");



            _connection.Open();
            sqlBulkCopy.WriteToServer(excellDataSet);

            _connection.Close();

            UpdateGrid(ConnectionString);

        }

        private void UpdateGrid(string cnn)
        {


            using (SqlConnection connection =
                   new SqlConnection(cnn))
            {
                string queryString =
                    "SELECT Id, Name, Family from dbo.People";

                SqlCommand command = new SqlCommand(queryString, connection);

                try
                {
                    var persons = new List<Person>();
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                   
                    foreach (var item in reader)
                    {

                        var person = new Person()
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Family = reader.GetString(2),
                        };
                        persons.Add(person);
                    }
                    dgvPerson.DataSource = persons;

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }

        }


        private class Person
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Family { get; set; }
        }
    }
}

