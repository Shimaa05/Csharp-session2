namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank account1 = new Bank();
            Bank account2 = new Bank("Ahmed", "98765432104321", "01122457131", "Cairo", 5000);

            account1.ShowAccountDetails();
            account2.ShowAccountDetails();
        }
    }
}
