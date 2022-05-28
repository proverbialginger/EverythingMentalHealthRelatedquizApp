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

namespace EMHRquizApp
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.Show();
            this.Hide();
        }
          
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            runQuery();
        }

        private void runQuery();
       
    {
         string query = btnSubmit.Text;

                if (Query == "")
                {
                    MessageBox.Show("Please insert some sql query");
                    return;
                 }
                string MySQLConnectionString = "datasource=127.0.0.1;porty=3306;user=root;password='';database=quizapp"

                 MySqlConnection databaseConnection = new MySqlConnection(MySqlConnectionString);
                    
                 MySqlConnection(connectDatabase = new MySqlConnection(Query, databaseConnection);

                commandDatabase.CommandTimeout = 60;

                try 
	{	        
		databaseConnection.Open();

        MySqldatareader myReader = commandDatabase.ExecuteReader();

        if(myReader)
        {
            MessageBox.Show("Ypur Query Generated results, please see the console");

            while (myReeder.read())
	        {
	         Console.WriteLine("myReader.GetString");
	        }
        }else
	{
         MessageBox.Show("Query Succesfully executed");
	}
       
	}
	catch (Exception)
	{
		
		 MessageBox.Show("Query error");
	}

       }
    }
}
