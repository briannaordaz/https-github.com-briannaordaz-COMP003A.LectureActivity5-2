namespace COMP003A.LectureActivity5_2;

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        internal class BankAccount
        {
            //Fields
            private string _accountNumber;
            private double _balance;
            
            //Properties
            ///<summary>
            /// Gets the account number.
            /// </summary>

            public string AccountNumber
            {
                get { return _accountNumber; }
            }

            ///<summary>
            /// Gets or sets the account balance with validation.
            /// </summary>

            public double Balance
            {
                get { return _balance; }
                set
                {
                    if (value >= 0)
                        _balance = value;
                }
            }

            /// <summary>
            /// Initializes a new instance of BankAccount with an account number adn initial balance.
            /// </summary>

            public BankAccount(string accountNumber, double initialBalance)
            {
                //Set the account number and initial balance
                _accountNumber = accountNumber;
                //Validate the initial balance
                Balance = initialBalance;
            }
        }
    }