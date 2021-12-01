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
    public partial class AdminHome : Form
    {
        //properties
        String selectedCid = "";
        Customer cust = new Customer();
        Address custAddy = new Address();
        public AdminHome()
        {
            InitializeComponent();
        }
        /***
        * adminSelect
        * displays customer info on form
        * *****************/
        private void btn_AdminSelect_Click(object sender, EventArgs e)
        {
            //select
            selectedCid = nbx_Cid.Value.ToString();
            cust.SelectDB(selectedCid);
            custAddy = cust.getAddress();
            tbx_AdminFname.Text = cust.getFirstName();
            tbx_AdminLname.Text = cust.getLastName();
            tbx_AdminStreet.Text = custAddy.getStreet();
            tbx_AdminCity.Text = custAddy.getCity();
            tbx_AdminState.Text = custAddy.getState();
            nbx_AdminZip.Text = custAddy.getZip().ToString();
            tbx_AdminEmail.Text = cust.getEmail();
            System.Diagnostics.Debug.WriteLine(cust.getFirstName());
        }
        /***
         * adminAdd
         * adds new customer
         * *****************/
        private void btn_AdminAdd_Click(object sender, EventArgs e)
        {
            //insert
            selectedCid = nbx_Cid.Value.ToString();
            Address iaddress = new Address(tbx_AdminStreet.Text, tbx_AdminCity.Text, tbx_AdminState.Text, Convert.ToInt32(nbx_AdminZip.Text));
            Customer icustomer = new Customer(selectedCid, tbx_AdminLname.Text + Person.generatePw(), tbx_AdminFname.Text, tbx_AdminLname.Text, iaddress, tbx_AdminEmail.Text);
            icustomer.InsertDB();
            MessageBox.Show(selectedCid + " successfully added.");
        }
        /***
        * adminUpdate
        * updates customer
        * *****************/
        private void btn_AdminUpdate_Click(object sender, EventArgs e)
        {
            //update
            selectedCid = nbx_Cid.Value.ToString();
            cust.SelectDB(selectedCid);
            custAddy = cust.getAddress();
            cust.setFirstName(tbx_AdminFname.Text);
            cust.setLastName(tbx_AdminLname.Text);
            custAddy.setStreet(tbx_AdminStreet.Text);
            custAddy.setCity(tbx_AdminCity.Text);
            custAddy.setState(tbx_AdminState.Text);
            custAddy.setZip(Convert.ToInt32(nbx_AdminZip.Text));
            cust.setEmail(tbx_AdminEmail.Text);
            cust.UpdateDB();
            MessageBox.Show(selectedCid + " successfully updated.");
        }
        /***
        * adminDelete
        * deletes customer
        * *****************/
        private void btn_AdminDelete_Click(object sender, EventArgs e)
        {
            //delete
            selectedCid = nbx_Cid.Value.ToString();
            cust.SelectDB(selectedCid);
            cust.DeleteDB();
            MessageBox.Show(selectedCid + " successfully deleted.");
        }
        /***
        * resetPw
        * automatically generates new password based on customer lastname on click
        * *****************/
        private void btn_ResetPw_Click(object sender, EventArgs e)
        {
            selectedCid = nbx_Cid.Value.ToString();
            cust.SelectDB(selectedCid);
            cust.setCustPw(tbx_AdminLname.Text + Person.generatePw());
            cust.UpdateDB();
            MessageBox.Show(selectedCid + " password reset");
        }
        //nav
        private void amenu_Logout_Click(object sender, EventArgs e)
        {
            LoginForm nav_Login = new LoginForm();
            nav_Login.Show();
            this.Hide();
        }//end nav
    }
}
