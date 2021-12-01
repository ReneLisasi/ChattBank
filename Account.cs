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
    class Account
    {
        //Properties
        String acctNo, cid;
        String type;
        double balance;


        //Constructor that passes no arguments
        public Account()
        {
            acctNo = cid = "";
            type = "";
            balance = 0;
        }

        //Constructor that passes all arguments
        public Account(String acno, String id, String typ, double bal)
        {
            acctNo = acno;
            cid = id;
            type = typ;
            balance = bal;
        }

        //selectDB
        public void selectDB(String i)
        {
            acctNo = i;
            //++++++++++++++++++++++++++  SELECT +++++++++++++++++++++++++
            DBSetup();
            cmd = "Select * from Accounts where AcctNo= '" + i + "'";
            OleDbDataAdapter2.SelectCommand.CommandText = cmd;
            OleDbDataAdapter2.SelectCommand.Connection = OleDbConnection2;
            Console.WriteLine(cmd);
            try
            {
                OleDbConnection2.Open();
                System.Data.OleDb.OleDbDataReader dr;
                dr = OleDbDataAdapter2.SelectCommand.ExecuteReader();

                dr.Read();
                acctNo = i;
                cid = dr.GetValue(1) + "";
                type = (dr.GetValue(2) + "");
                balance = (Double.Parse(dr.GetValue(3) + ""));
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
        public void insertDB()
        {
            // +++++++++++++++++++++++++++  INSERT +++++++++++++++++++++++++++++++

            DBSetup();
            cmd = "INSERT into Accounts values('" + getAcctNo() + "'," +
                                              "" + getCid() + "," +
                                              "'" + getType() + "'," +
                                                getBalance() + ")";

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

        public void updateDB()
        {
            //++++++++++++++++++++++++++  UPDATE  +++++++++++++++++++++++++

            cmd = "Update Accounts set Cid = '" + getCid() + "'," +
                         "Type= '" + getType() + "', " +
                         "Balance = " + getBalance() +
                         " where AcctNo = '" + getAcctNo() + "'";

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
        public void deleteDB()
        {
            //++++++++++++++++++++++++++  DELETE  +++++++++++++++++++++++++

            cmd = "Delete from Accounts where acctNo = '" + getAcctNo() + "'";
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

        //display method
        public void displayAccount()
        {
            System.Diagnostics.Debug.WriteLine("Account Number: " + acctNo + " Cid: " + cid
                    + " Type: " + type + " Balance: " + balance);
        }
        /***
        * displayAccount2()
        * returns a string perfectly alligned to display on the form
        * containing account info
        * *****************/
        public String displayAccount2()
        {
            return acctNo + "                                       "+ cid
                    + "                                         " + type + "                                       $" + balance;
        }

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

        //getters and setters
        public String getAcctNo() { return acctNo; }
        public void setAcctNo(String acctNo) { this.acctNo = acctNo; }
        public String getCid() { return cid; }
        public void setCid(String cid) { this.cid = cid; }
        public String getType() { return type; }
        public void setType(String type) { this.type = type; }
        public double getBalance() { return balance; }
        public void setBalance(double balance) { this.balance = balance; }
    }
}
