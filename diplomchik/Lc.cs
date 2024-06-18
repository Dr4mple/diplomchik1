using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diplomchik
{
    public partial class Lc : Form
    {
        DB baza = new DB(); 
        
        public int UserId { get; set; }
      


        public Lc()
        {
            InitializeComponent();
        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void Lc_Load(object sender, EventArgs e)
        {

            String login = "12";
            String password = "12";

            LoadData(login,password);
                


            
        }

        private void LoadData(String login, String password)
        {
            Client client = new Client();
            bool dataLoaded = client.SetPersonalData(login, password); // Replace with actual login and password

            if (dataLoaded)
            {
                guna2TextBox1.Text = client.name;
                guna2TextBox2.Text = client.Familiy;
                guna2TextBox3.Text = client.firstname;
                guna2TextBox4.Text = client.date;
                guna2TextBox5.Text = client.mobile;
                guna2TextBox6.Text = client.lic_schet;
            }
            else
            {
                MessageBox.Show("Failed to load client data.");
            }
        }
    
        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
