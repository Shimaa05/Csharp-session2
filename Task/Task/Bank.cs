using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    class Bank
    {
        public const string BankCode = "BNK001";
        public readonly DateTime CreateDate;

        private int _accountNumber;
        private string _fullName;
        private string _nationalID;
        private string _phoneNumber;
        private string _address;
        private decimal _balance;

        public string FullName
        {
            get
            {
                return _fullName;
            }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("invalid format");
                }
                else
                {
                    _fullName = value;
                }
            }
        }

        public string NationalID
        {
            get
            {
                return _nationalID;
            }
            set
            {
                if (value.Length == 14)
                {
                    Console.WriteLine("valid");
                }
                else
                {
                    Console.WriteLine("invalid");
                }
            }
        }

        public string PhoneNumber
        {
            get
            {
                return _phoneNumber;
            }
            set
            {
                if (value.Length == 11 && value.StartsWith("01"))
                {
                    _phoneNumber = value;
                }
                else
                {
                    Console.WriteLine("invalid");
                }
            }
        }

        public decimal Balance
        {
            get
            {
                return _balance;
            }
            set
            {
                if(value >= 0 )
                {
                    _balance = value;
                }
                else
                {
                    Console.WriteLine("invalid");
                }
            }
        }

        public string Address
        {
            get
            {
                return _address;
            }
            set
            {
                _address = value;
            }
        }

        public Bank()
        {
            _accountNumber = 1;
            _fullName = "Shimaa";
            _nationalID = "12345678901234";
            _phoneNumber = "01287531141";
            _address = "Benha";
            _balance = 4000;
            CreateDate = DateTime.Now;
        }

        public Bank(string fullname, string nationalID, string phoneNumber, string address, decimal balance)
        {
            _fullName = fullname;
            _nationalID = nationalID;
            _phoneNumber = phoneNumber;
            _address = address;
            _balance = balance;
            CreateDate = DateTime.Now;
        }

        public Bank(string fullname, string nationalID, string phoneNumber, string address) :this(fullname, nationalID, phoneNumber, address, 0)
        {
        }

        public void ShowAccountDetails()
        {
            Console.WriteLine($"BankCode : {BankCode}");
            Console.WriteLine($"CreateDate : {CreateDate}");
            Console.WriteLine($"FullName : {_fullName}");
            Console.WriteLine($"National ID : {_nationalID}");
            Console.WriteLine($"Phone Number : {_phoneNumber}");
            Console.WriteLine($"Address : {_address}");
            Console.WriteLine($"Balance : {_balance}");
            Console.WriteLine("----------------------------------");
        }

        public bool IsValidNationalID()
        {
            return _nationalID != null && _nationalID.Length == 14;
        }

        public bool IsValidPhoneNumber()
        {
            return _phoneNumber.Length == 11 && _phoneNumber.StartsWith("01");
        }


    }
}
