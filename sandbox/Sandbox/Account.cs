public class Account
{
    public int _balance;
    public void Deposit(int amount)
    {
        _balance = _balance + amount;
        Console.WriteLine(_balance);
    }
}