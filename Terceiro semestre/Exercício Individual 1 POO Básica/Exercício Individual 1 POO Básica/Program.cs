namespace Exercício_Individual_1_POO_Básica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(32711, 200);

            account.withdraw(300);
            account.deposit(100);
            account.withdraw(50);
            account.withdraw(10);
            account.deposit(100);
            account.deposit(500);
            account.deposit(500);
            account.withdraw(600);
            account.withdraw(100);
            account.deposit(100);
            account.deposit(300);
            account.impressão();
        }
    }
}
