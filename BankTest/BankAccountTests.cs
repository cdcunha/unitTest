﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankAccountNS;

namespace BankTest
{
    [TestClass]
    public class BankAccountTests
    {
        // unit test code 
        [TestMethod]
        public void Debit_WithValidAmount_UpdatesBalance()
        {
            // arrange 
            double beginningBalance = 11.99;
            double debitAmount = 4.55;
            double expected = 7.44;
            BankAccount account = new BankAccount("Mr. Bryan Walton", beginningBalance);
            // act 
            account.Debit(debitAmount);

            // assert 
            double actual = account.Balance;
            Assert.AreEqual(expected, actual, 0.001, "Account not debited correctly");
        }

        /*
        //unit test method 
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Debit_WhenAmountIsLessThanZero_ShouldThrowArgumentOutOfRange_1()
        {
            // arrange 
            double beginningBalance = 11.99;
            double debitAmount = -100.00;
            BankAccount account = new BankAccount("Mr. Bryan Walton", beginningBalance);
            // act 
            account.Debit(debitAmount);
            // assert is handled by ExpectedException 
        }
        
        [TestMethod]
        public void Debit_WhenAmountIsMoreThanBalance_ShouldThrowArgumentOutOfRange_2()
        {
            // arrange 
            double beginningBalance = 11.99;
            double debitAmount = 20.0;
            BankAccount account = new BankAccount("Mr. Bryan Walton", beginningBalance);

            // act 
            try
            {
                account.Debit(debitAmount);
            }
            catch (ArgumentOutOfRangeException e)
            {
                // assert 
                StringAssert.Contains(e.Message, BankAccount.DebitAmountExceedsBalanceMessage);
            }
        }
        */

        [TestMethod]
        public void Debit_WhenAmountIsMoreThanBalance_ShouldThrowArgumentOutOfRange_3()
        {
            // arrange 
            double beginningBalance = 11.99;
            double debitAmount = 1.99;//20.0;
            BankAccount account = new BankAccount("Mr. Bryan Walton", beginningBalance);
            // act 
            try
            {
                account.Debit(debitAmount);
            }
            catch (ArgumentOutOfRangeException e)
            {
                // assert 
                StringAssert.Contains(e.Message, BankAccount. DebitAmountExceedsBalanceMessage);
                return;
            }
            Assert.Fail("No exception was thrown."); 
        }
        }
}
