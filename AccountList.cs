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
    class AccountList
    {
        //======== Properties =========
        public int count;  //the number of Accounts in the list
        public Account [] accArr = new Account[1000000];   //the list

        public int getCount()
        {
            return count;
        }
        //methods
        public void addAccount(Account a1)
        {
            accArr[count] = a1;
            count++;
        }

        public void displayList()
        {
            for (int x = 0; x < count; x++)
            {
                accArr[x].displayAccount();
            }
        }
        /***
        * displayList2()
        * assigns displayAccount2 to accArr
        * *****************/
        public void displayList2()
        {
            for (int x = 0; x < count; x++)
            {
                accArr[x].displayAccount2();
            }
        }

        //main method
        /*public static void main()
        {
            AccountList alist = new AccountList();

            Account a = new Account("7777", "3001", "SAV", 500);
            Account b = new Account("8888", "3002", "CHK", 700);
            alist.addAccount(a);
            alist.addAccount(b);

            alist.displayList();
        }*/
    }
}
