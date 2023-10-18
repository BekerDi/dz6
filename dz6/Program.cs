using System;
using System;

public enum AccountType
{
    Checking,
    Savings
}

public class BankAccount
{
    private static int accountNumberCounter;

    public int AccountNumber { get; }
    public decimal Balance { get; private set; }
    public AccountType Type { get; }

    public BankAccount(AccountType type)
    {
        AccountNumber = GenerateAccountNumber();
        Balance = 0;
        Type = type;
    }

    private static int GenerateAccountNumber()
    {
        return ++accountNumberCounter;
    }

    public void Deposit(decimal amount)
    {
        Balance += amount;
        Console.WriteLine($"Текущий баланс: {amount} нa {AccountNumber}.");
    }

    public void Withdraw(decimal amount)
    {
        if (Balance >= amount)
        {
            Balance -= amount;
            Console.WriteLine($"Снято {amount} со счета {AccountNumber}. Новый баланс: {Balance}");
        }
        else
        {
            Console.WriteLine($"Недостаточно средств на счете {AccountNumber}. Невозможно снять {amount}");
        }
    }

    public void DepositFromUser()
    {
        Console.Write($"Введите сумму для внесения на счет {AccountNumber}: ");
        decimal depositAmount;

        while (!decimal.TryParse(Console.ReadLine(), out depositAmount))
        {
            Console.WriteLine("Некорректный ввод. Попробуйте еще раз.");
            Console.Write($"Введите сумму для внесения на счет {AccountNumber}: ");
        }

        Deposit(depositAmount);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        BankAccount account1 = new BankAccount(AccountType.Checking);
        BankAccount account2 = new BankAccount(AccountType.Savings);

        account1.Deposit(10000000);

        Console.Write("Введите сумму для снятия со счета 1: ");
        decimal withdrawalAmount1;

        while (!decimal.TryParse(Console.ReadLine(), out withdrawalAmount1))
        {
            Console.WriteLine("Некорректный ввод. Попробуйте еще раз.");
            Console.Write("Введите сумму для снятия со счета 1: ");
        }

        account1.Withdraw(withdrawalAmount1);

        account2.Deposit(2000000);

        Console.Write("Введите сумму для снятия со счета 2: ");
        decimal withdrawalAmount2;

        while (!decimal.TryParse(Console.ReadLine(), out withdrawalAmount2))
        {
            Console.WriteLine("Некорректный ввод. Попробуйте еще раз.");
            Console.Write("Введите сумму для снятия со счета 2: ");
        }

        account2.Withdraw(withdrawalAmount2);

        account1.DepositFromUser();
        account2.DepositFromUser();
        Console.ReadKey();
    }
}


