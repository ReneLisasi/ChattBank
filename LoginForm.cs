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
    public partial class LoginForm : Form
    {
        public static String selectedId;//used for collecting from forms
        Customer c1 = new Customer();
        public LoginForm()
        {
            InitializeComponent();
        }
        /***
        * Login
        * test customer credentials and navigates to appropriate form
        * *****************/
        private void btn_Login_Click(object sender, EventArgs e)
        {
            //selectedId = Convert.ToInt32(nbx_Customer.Value);
            selectedId = nbx_Customer.Value.ToString();
            c1.SelectDB(selectedId);
            String pw = c1.getCustPw();
            String id = c1.getCustId();
            System.Diagnostics.Debug.WriteLine(selectedId);
            System.Diagnostics.Debug.WriteLine(c1.getCustFname());
            //login credentials test
            if (nbx_Customer.Text.Equals(id) && tbx_Pw.Text.Equals(pw))
            {
                //collect student id and send to new form
               
                CustomerHome nav_Home = new CustomerHome();
                nav_Home.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect password or username");
            }
        }
        /***
        * LoginAdmin
        * test admin credentials
        * *****************/
        private void btn_LoginAdmin_Click(object sender, EventArgs e)
        {
            //login credentials test
            //use "admin" for admin and 123 for password
            if (tbx_Admin.Text.Equals("admin") && tbx_AdminPw.Text.Equals("123"))
            {
                //send to next page
                AdminHome nav_aHome = new AdminHome();
                nav_aHome.Show();
                this.Hide();
            }
            if (!tbx_Admin.Text.Equals("admin") && !tbx_AdminPw.Text.Equals("123"))
            {
                MessageBox.Show("Incorrect password or username");
            }
        }
    }
}
