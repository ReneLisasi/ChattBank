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
    public partial class CustomerHome : Form
    {
        Customer customer = new Customer();
        Address addy = new Address();
        AccountList bList = new AccountList();
        Account[] account = new Account[100];
        int listSize = 0;
        String[] array = new String[100];
        String[] accountNumbers = new string[100];
        Account selectedAcc = new Account();
        public CustomerHome()
        {
            InitializeComponent();
            refreshAccounts();
        }

        /***
        * refreshAccounts()
        * collects list of customer accounts and displays them
        * *****************/
        public void refreshAccounts()
        {
            customer.SelectDB(LoginForm.selectedId);
            addy = customer.getAddress();
            bList = customer.aList;
            listSize = bList.getCount();
            account = bList.accArr;
            for (int x = 0; x < listSize; x++)
            {
                array[x] = account[x].displayAccount2();//get account objects
                accountNumbers[x] = account[x].getAcctNo().ToString();//get account numbers
                cbx_Deposit.Items.Add(accountNumbers[x]);//populate combo box
                cbx_Withdraw.Items.Add(accountNumbers[x]);//populate combo box
                lbl_Info.Text = string.Join("\n\n", array);   //display accounts
            }
        }

        /***
        * generateAcc()
        * generates account number based on the total number of accounts
        * *****************/
        public String generateAcc()
        {
            int a = 0;
            String b = "";
            a = 90000+customer.CountAll()+1;
            b = a.ToString();
                return b;
        }

        //################################################################## options
        private void btn_AddAcc_Click(object sender, EventArgs e)
        {
            pnl_left.Visible = false;
            pnl_mid.Visible = true;
            pnl_right.Visible = true;
        }

        private void btn_Deposit_Click(object sender, EventArgs e)
        {
            pnl_left.Visible = true;
            pnl_mid.Visible = false;
            pnl_right.Visible = true;
        }

        private void btn_Draw_Click(object sender, EventArgs e)
        {
            pnl_left.Visible = true;
            pnl_right.Visible = false;
            pnl_mid.Visible = true;
        }
        //&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&  confirmations
        /***
        * confirmAdd
        * create new account and generates account number
        * *****************/
        private void btn_ConfirmAdd_Click(object sender, EventArgs e)
        {
            String s = cbx_Type.Text;
            Account a1 = new Account();
            a1.setAcctNo(generateAcc());
            a1.setCid(customer.getCustId());
            a1.setType(s);
            a1.setBalance(0);
            a1.insertDB();
            //refreshAccounts
            CustomerHome nav_Home = new CustomerHome();
            nav_Home.Show();
            this.Hide();  
        }
        /***
        * confirmDep
        * deposits amount to an account
        * *****************/
        private void btn_ConfirmDep_Click(object sender, EventArgs e)
        {
            String s = cbx_Deposit.Text;
            selectedAcc.selectDB(s);
            selectedAcc.setBalance(selectedAcc.getBalance() + Convert.ToDouble(nbx_Dep.Value));
            selectedAcc.updateDB();

            //refresh
            CustomerHome nav_Home = new CustomerHome();
            nav_Home.Show();
            this.Hide();
        }
        /***
        * confirmDraw
        * withdraws amount from account
        * *****************/
        private void btn_ConfirmDraw_Click(object sender, EventArgs e)
        {
            String s = cbx_Withdraw.Text;
            selectedAcc.selectDB(s);
            if (Convert.ToInt32(nbx_Draw.Value) > selectedAcc.getBalance())
            {
                MessageBox.Show("insufficient Balance for withdrawal"); 
            }
            else
            {
                selectedAcc.setBalance(selectedAcc.getBalance() - Convert.ToDouble(nbx_Draw.Value));
                selectedAcc.updateDB();
                //refresh
                CustomerHome nav_Home = new CustomerHome();
                nav_Home.Show();
                this.Hide();
            }

        }
        //nav
        private void menu_Logout_Click(object sender, EventArgs e)
        {
            LoginForm nav_Login = new LoginForm();
            nav_Login.Show();
            this.Hide();
        }

        private void menu_Prof_Click(object sender, EventArgs e)
        {
            //send to next page
            Profile nav_Profile = new Profile();
            nav_Profile.Show();
            this.Hide();
        }

        private void menu_Home_Click(object sender, EventArgs e)
        {
            //send to next page
            CustomerHome nav_Home = new CustomerHome();
            nav_Home.Show();
            this.Hide();
        }
    }
}
