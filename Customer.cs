using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/***
 * Rene Lisasi
 * Chattbank
 * Nov 2,2021
 * I wrote this
 * *****************/
namespace ChattBank
{
    class Customer : Person
    {
        //Properties
        String custId = "";
        String  custPw;
        String custFname, custLname, custEmail;
        Address custAddress = new Address();

        //Array List
        public AccountList aList = new AccountList();

        //Constructor that passes no arguments
        public Customer() : base("","",new Address(),"")
        {
            custId = ""; custPw = null;
            custFname = custLname = custEmail = null;
        }

        //Constructor that passes all arguments
        public Customer(String id, String pw, String fName, String lName, Address address, String email)
            : base(fName, lName, address, email)
        {
            custId = id;
            custPw = pw;
            custFname = fName;
            custLname = lName;
            custAddress = address;
            custEmail = email;
        }
        /***
        * CountAll()
        * returns the number of accounts from the entire database
        * *****************/
        public int CountAll()
        {
            int x = 0;
            DBSetup();
            cmd = "Select count(*) from Accounts";
            OleDbDataAdapter2.SelectCommand.CommandText = cmd;
            OleDbDataAdapter2.SelectCommand.Connection = OleDbConnection2;
            Console.WriteLine(cmd);
            try
            {
                OleDbConnection2.Open();
                System.Data.OleDb.OleDbDataReader dr;
                dr = OleDbDataAdapter2.SelectCommand.ExecuteReader();

                dr.Read();
                x = (Int32.Parse(dr.GetValue(0) + ""));
            }
            catch (Exception ex)
            {
                //Console.WriteLine(ex);
                System.Diagnostics.Debug.WriteLine(ex);
            }
            finally
            {
                OleDbConnection2.Close();
            }
            return x;
        }
        /***
        * getAccounts()
        * assigns accounts to customer object
        * *****************/
        public void getAccounts()
        {
            //Load DB Driver
            DBSetup();
            cmd = "select acctNo from Accounts where cid='" + getCustId() + "'";
            OleDbDataAdapter2.SelectCommand.CommandText = cmd;
            OleDbDataAdapter2.SelectCommand.Connection = OleDbConnection2;
            Console.WriteLine(cmd);
            try
            {
                OleDbConnection2.Open();
                System.Data.OleDb.OleDbDataReader dr;
                dr = OleDbDataAdapter2.SelectCommand.ExecuteReader();
                //Process ResultSet
                String an;
                Account a1;
                while (dr.Read())
                {
                    //dr.Read();
                    an = dr.GetValue(0) + "";
                    a1 = new Account();
                    a1.selectDB(an);
                    aList.addAccount(a1);
                }
            }
            catch (Exception se)
            {
               System.Diagnostics.Debug.WriteLine(se);
            }
        }


        //display method
        public void displayCustomer()
        {
            System.Diagnostics.Debug.WriteLine("ID: " + custId + " PW: " + custPw + " First Name: " + custFname
                    + " Last Name " + custLname + " Address: " + custAddress +
                    " Email: " + custEmail);

            //Array List
            aList.displayList2();

        }
        /***
        * displayCustomer2()
        * returns a string of customer info
        * *****************/
        public String displayCustomer2()
        {
            return ("ID: " + custId + " PW: " + custPw + " First Name: " + custFname
                    + " Last Name " + custLname + " Address: " + custAddress +
                    " Email: " + custEmail);

            //Array List
            aList.displayList2();

        }
        /***
        * selectDB()
        * collects customer info based on id
        * *****************/
        public void SelectDB(String i)
        {
            
            DBSetup();
            cmd = "Select * from Customers where CustID= '" + i + "'";
            OleDbDataAdapter2.SelectCommand.CommandText = cmd;
            OleDbDataAdapter2.SelectCommand.Connection = OleDbConnection2;
            Console.WriteLine(cmd);
            try
            {
                OleDbConnection2.Open();
                System.Data.OleDb.OleDbDataReader dr;
                dr = OleDbDataAdapter2.SelectCommand.ExecuteReader();

                dr.Read();
                custId = i;
                custPw = (dr.GetValue(1) + "");
                FirstName = (dr.GetValue(2) + "");
                LastName = (dr.GetValue(3) + "");
                custAddress.setStreet(dr.GetValue(4) + "");
                custAddress.City = (dr.GetValue(5) + "");
                custAddress.State = (dr.GetValue(6) + "");
                custAddress.Zip = (Int32.Parse(dr.GetValue(7) + ""));
                Email = (dr.GetValue(8) + "");
                getAccounts();
            }
            catch (Exception ex)
            {
                //Console.WriteLine(ex);
                System.Diagnostics.Debug.WriteLine(ex);
            }
            finally
            {
                OleDbConnection2.Close();
            }

        } //end selectDB()

        //insertDB
        public void InsertDB()
        {
            DBSetup();
            cmd = "INSERT into Customers values('" + getCustId() + "'," +
                                              "'" + getCustPw() + "'," +
                                              "'" + getCustFname() + "'," +
                                              "'" + getCustLname() + "'," +
                                              "'" + custAddress.getStreet() + "'," +
                                              "'" + custAddress.getCity() + "'," +
                                              "'" + custAddress.getState() + "'," +
                                              "" + custAddress.getZip() + "," +
                                              "'" + Email + "')";

            OleDbDataAdapter2.InsertCommand.CommandText = cmd;
            OleDbDataAdapter2.InsertCommand.Connection = OleDbConnection2;
            System.Diagnostics.Debug.WriteLine(cmd);
            try
            {
                OleDbConnection2.Open();
                int n = OleDbDataAdapter2.InsertCommand.ExecuteNonQuery();
                if (n == 1)
                    System.Diagnostics.Debug.WriteLine("Data Inserted");
                else
                    System.Diagnostics.Debug.WriteLine("ERROR: Inserting Data");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                OleDbConnection2.Close();
            }
        }

        //updatedb
        public void UpdateDB()
        {
            //++++++++++++++++++++++++++  UPDATE  +++++++++++++++++++++++++

            cmd = "Update Customers set CustPassword ='"+ getCustPw()+"',"+
                         "CustFirstName = '" + getFirstName() + "'," +
                         "CustLastName = '" + getLastName() + "', " +
                         "Street = '" + custAddress.getStreet() + "', " +
                         "City = '" + custAddress.getCity() + "', " +
                         "State = '" + custAddress.getState() + "', " +
                         "Zip = " + custAddress.getZip() + "," +
                         "CustEmail = '" + getEmail() + "'" +
                         " where CustID = '" + getCustId() + "'";

            OleDbDataAdapter2.UpdateCommand.CommandText = cmd;
            OleDbDataAdapter2.UpdateCommand.Connection = OleDbConnection2;
            Console.WriteLine(cmd);
            try
            {
                OleDbConnection2.Open();
                int n = OleDbDataAdapter2.UpdateCommand.ExecuteNonQuery();
                if (n == 1)
                    System.Diagnostics.Debug.WriteLine("Data Updated");
                else
                    System.Diagnostics.Debug.WriteLine("ERROR: Updating Data");
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex);
            }
            finally
            {
                OleDbConnection2.Close();
            }
        }

        //DeleteDB
        public void DeleteDB()
        {
            //++++++++++++++++++++++++++  DELETE  +++++++++++++++++++++++++

            cmd = "Delete from Customers where CustID = '" + getCustId() + "'";
            OleDbDataAdapter2.DeleteCommand.CommandText = cmd;
            OleDbDataAdapter2.DeleteCommand.Connection = OleDbConnection2;
            Console.WriteLine(cmd);
            try
            {
                OleDbConnection2.Open();
                int n = OleDbDataAdapter2.DeleteCommand.ExecuteNonQuery();
                if (n == 1)
                    System.Diagnostics.Debug.WriteLine("Data Deleted");
                else
                    System.Diagnostics.Debug.WriteLine("ERROR: Deleting Data");
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex);
            }
            finally
            {
                OleDbConnection2.Close();
            }

        }



        //getters
        public String getCustId() { return custId; }
        public String getCustPw() { return custPw; }
        public String getCustFname() { return custFname; }
        public String getCustLname() { return custLname; }
        public Address getAddress() { return custAddress; }
        public String getCustEmail() { return custEmail; }

        //Setters
        public void setCustId(String custId) { this.custId = custId; }
        public void setCustPw(String custPw) { this.custPw = custPw; }
        public void setCustFname(String custFname) { this.custFname = custFname; }
        public void setCustLname(String custLname) { this.custLname = custLname; }
        public void setCustAddress(Address custAddress) { this.custAddress = custAddress; }
        public void setCustEmail(String custEmail) { this.custEmail = custEmail; }



        //=============================  BEHAVIORS =========================
        //++++++++++++++++  DATABASE Data Elements +++++++++++++++++
        public System.Data.OleDb.OleDbDataAdapter OleDbDataAdapter2;
        public System.Data.OleDb.OleDbCommand OleDbSelectCommand2;
        public System.Data.OleDb.OleDbCommand OleDbInsertCommand2;
        public System.Data.OleDb.OleDbCommand OleDbUpdateCommand2;
        public System.Data.OleDb.OleDbCommand OleDbDeleteCommand2;
        public System.Data.OleDb.OleDbConnection OleDbConnection2;
        public string cmd;

        public void DBSetup()
        {
            // +++++++++++++++++++++++++++  DBSetup function +++++++++++++++++++++++++++++++
            OleDbDataAdapter2 = new System.Data.OleDb.OleDbDataAdapter();
            OleDbSelectCommand2 = new System.Data.OleDb.OleDbCommand();
            OleDbInsertCommand2 = new System.Data.OleDb.OleDbCommand();
            OleDbUpdateCommand2 = new System.Data.OleDb.OleDbCommand();
            OleDbDeleteCommand2 = new System.Data.OleDb.OleDbCommand();
            OleDbConnection2 = new System.Data.OleDb.OleDbConnection();

            //OleDbDataAdapter1
            OleDbDataAdapter2.DeleteCommand = OleDbDeleteCommand2;
            OleDbDataAdapter2.InsertCommand = OleDbInsertCommand2;
            OleDbDataAdapter2.SelectCommand = OleDbSelectCommand2;
            OleDbDataAdapter2.UpdateCommand = OleDbUpdateCommand2;

            OleDbConnection2.ConnectionString = "Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database L" +
            "ocking Mode=1;Data Source=B:\\OneDrive - Chattahoochee Technical College\\FALL21\\C#2\\DB\\ChattBankACCDB.accdb;J" +
            "et OLEDB:Engine Type=5;Provider=Microsoft.ACE.OLEDB.12.0;Jet OLEDB:System datab" +
            "ase=;Jet OLEDB:SFP=False;persist security info=False;Extended Properties=;Mode=S" +
            "hare Deny None;Jet OLEDB:Encrypt Database=False;Jet OLEDB:Create System Database=False;Jet " +
            "OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repai" +
            "r=False;User ID=Admin;Jet OLEDB:Global Bulk Transactions=1";
        }  //end DBSetup()
    }
}
