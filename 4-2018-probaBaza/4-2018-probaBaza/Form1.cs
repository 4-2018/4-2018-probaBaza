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

namespace _4_2018_probaBaza
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string connectionString = "Data Source=(localdb)\\ProjectsV13;Initial Catalog=FacultyDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        
        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            List<ExerciseResult> rezultati = new List<ExerciseResult>();



            connection.Open();

            SqlCommand command = new SqlCommand();
            command.Connection = connection;

            command.CommandText = "SELECT * FROM ExerciseResults";
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ExerciseResult rezultat = new ExerciseResult(reader.GetInt32(0),
                    reader.GetString(1), reader.GetString(2), reader.GetInt32(3));

                rezultati.Add(rezultat);
            }


            connection.Close();

            foreach (ExerciseResult i in rezultati)
            {
                listBox1gsdsdfg.Items.Add(i.ToString());
            }
        }
    }
}
