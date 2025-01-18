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
using System.Xml.Linq;

namespace DitecFinalProject
{
    public partial class Registration : Form
    {
        SqlConnection con = null;
        public Registration()
        {
            InitializeComponent();
            con = new SqlConnection("Data Source=MSI;Initial Catalog=Student;Integrated Security=True;");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
                    }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {

                con.Open();
                //label4.Text = "Connection Successfull!";
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                string Firstname = firstname.Text;
                string Lastname = lastname.Text;
                string Address = address.Text;
                string mail = Email.Text;
                string phone = phonenumber.Text;
                string home_num = home.Text;
                string parent_name = parentname.Text;
                string parent_nic = NIC.Text;
                string parent_contact = Contactnumber.Text;

                cmd.CommandText = "insert into data (Firstname,Lastname,Address,mail,phone,home_num,parent_name,parent_nic,parent_contact) values ('" + firstname + "', '" + lastname + "','" + address + "','" + Email + "','" + phonenumber + "','" + home + "','" + parentname + "','" + NIC + "','" + Contactnumber + "')";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record has been inserted!");

                firstname.Clear();
                lastname.Clear();
                address.Clear();
                Email.Clear();
                phonenumber.Clear();
                home.Clear();
                parentname.Clear();
                NIC.Clear();
                Contactnumber.Clear();
                //loadtable();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }
    }
}
