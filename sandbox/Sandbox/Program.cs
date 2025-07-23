using System;
class Program
{
    static void Main(string[] args)
    {
        Account savings = new Account();
        savings._balance = 1000;
        savings.Deposit(500);
    }
}
