using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/***
 * Rene Lisasi
 * Chattbank
 * Nov 2,2021
 * I wrote this
 * *****************/
namespace ChattBank
{
    public partial class Profile : Form
    {
        Customer custProfile = new Customer();
        Address custProfAddy = new Address();
        public Profile()
        {
            InitializeComponent();
            //get data
            custProfile.SelectDB(LoginForm.selectedId);
            custProfAddy = custProfile.getAddress();
            //assign retrieved data to labels
            lbl_StudentId.Text = custProfile.getCustId().ToString();
            tbx_Password.Text = custProfile.getCustPw();
            lbl_StudentFirstName.Text = custProfile.getFirstName();
            lbl_StudentLastName.Text = custProfile.getLastName();
            tbx_Street.Text = custProfAddy.getStreet();
            tbx_City.Text = custProfAddy.getCity();
            tbx_State.Text = custProfAddy.getState();
            nbx_Zip.Text = custProfAddy.getZip().ToString();
            lbl_Email.Text = custProfile.getEmail();
        }
        /***
        * update
        * collects data from textboxes and updates customer info
        * *****************/
        private void btn_Update_Click(object sender, EventArgs e)
        {
            //set the address to the textbox value
            if (!tbx_Password.Text.Equals(null)) { 
            custProfile.setCustPw(tbx_Password.Text); }
            custProfAddy.setStreet(tbx_Street.Text);
            custProfAddy.setCity(tbx_City.Text);
            custProfAddy.setState(tbx_State.Text);
            custProfAddy.setZip(Int32.Parse(nbx_Zip.Text));
            custProfile.UpdateDB();
            MessageBox.Show("Data Updated", "Success");
        }
        //nav
        private void menu_Profile_Click(object sender, EventArgs e)
        {
            Profile nav_Profile = new Profile();
            nav_Profile.Show();
            this.Hide();
        }

        private void menu_Logout_Click(object sender, EventArgs e)
        {
            LoginForm nav_Login = new LoginForm();
            nav_Login.Show();
            this.Hide();
        }

        private void menu_Home_Click(object sender, EventArgs e)
        {
            CustomerHome nav_Home = new CustomerHome();
            nav_Home.Show();
            this.Hide();
        }
        //end nav
    }
}
