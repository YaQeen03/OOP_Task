using System.Runtime.Intrinsics.X86;

namespace ConsoleApp1
{
    internal class BankAccount
    {
        class BankAccount
        {

            private int AccountNumber;
            private string AccountHolderName;
            private double balance;
            private string AccountType;
            private string BranchName;

            public BankAccount(int AccountNumber, string AccountHolderName, double balance, string AccountType, string BranchName)
            {
                this.AccountNumber = AccountNumber;
                this.AccountHolderName = AccountHolderName;
                this.balance = balance;
                this.AccountType = AccountType;
                this.BranchName = BranchName;
            }
            ~BankAccount()
            {
                Console.WriteLine("object destroyed.");
            }

            public int Account_Number
            {
                get { return AccountNumber; }
                set { AccountNumber = value; }
            }
            public string Account_HolderName
            {
                get { return AccountHolderName; }
                set { AccountHolderName = value; }

            }
            public double Balance
            {
                set
                {
                    if (value >= 0)
                        balance = value;
                    else
                        Console.WriteLine("Error: Balance cannot be negative.");
                }
                get { return balance; }
            }
            public string Account_Type
            {
                get { return AccountType; }
                set { AccountType = value; }

            }
            public string Branch_Name
            {
                set { BranchName = value; }
                get { return BranchName; }

            }
            public void Deposit(double x)
            {
                balance += x;


            }
            public void Withdraw(double w)
            {
                if (w <= balance && w % 5 == 0)
                {
                    balance -= w;
                    Console.WriteLine("The withdrawal was successful.");
                }
                else if (w <= Balance && w % 5 != 0)
                {

                    Console.WriteLine("Error: The requested amount cannot be withdrawn as it does not match the available denominations.");

                }
                else
                {
                    Console.WriteLine(" Error:Insufficient balance");
                }

            }

            public void DisplayInfo()
            {
                Console.WriteLine("Account Number: " + AccountNumber);
                Console.WriteLine("Account Holder: " + AccountHolderName);
                Console.WriteLine("Balance: " + balance.ToString("F2"));
                Console.WriteLine("Account Type: " + AccountType);
                Console.WriteLine("Branch Name: " + BranchName);
            }
            static void Main(string[] args)
            {
                BankAccount account1 = new BankAccount(210, "Yaqeen", 2000, "Salary Account", "Irbid");
                BankAccount account2 = new BankAccount(219, "Faisal", 3000, "Saving Account", "Amman");

                account1.Deposit(50.08);
                account1.Withdraw(1800);
                account1.DisplayInfo();

                account2.Deposit(77.98);
                account2.Withdraw(3090);
                account2.DisplayInfo();

            }
        }
    }
}




