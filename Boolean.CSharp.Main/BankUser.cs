﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Boolean.CSharp.Main;


namespace Boolean.CSharp.Main
{
    public class BankUser
    {
        public List<Account> Accounts { get; set; } = new List<Account>();
        public BankUser() 
        {
            List<Account> Accounts = new List<Account>();
        }

        public bool CreateSavingsAccount()
        {
            
            return true;
        }

        public bool CreateCurrentAccount()
        {
           
            return true;
        }
    }
}
