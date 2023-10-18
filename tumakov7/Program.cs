


using System;

namespace CasinoInterface
{
    // Абстрактный класс "Игра"
    public abstract class Game
    {
        public string Name { get; }
        public int MinBet { get; }
        public int MaxBet { get; }

        public Game(string name, int minBet, int maxBet)
        {
            Name = name;
            MinBet = minBet;
            MaxBet = maxBet;
        }

        // Абстрактные методы
        public abstract void Play();
        public abstract void Bet(int amount);
        public abstract void Win(int amount);
        public abstract void Lose(int amount);
        public abstract void Quit();
    }

    // Класс "Слот-машина"
    public class SlotMachine : Game
    {
        public int NumOfReels { get; }
        public string Theme { get; }

        public SlotMachine(string name, int minBet, int maxBet, int numOfReels, string theme) : base(name, minBet, maxBet)
        {
            NumOfReels = numOfReels;
            Theme = theme;
        }

        // Методы для слот-машины
        public override void Play()
        {
            Console.WriteLine("Играем на слот-машине");
        }

        public override void Bet(int amount)
        {
            Console.WriteLine($"Ставим {amount} на слот-машину");
        }

        public override void Win(int amount)
        {
            Console.WriteLine($"Выигрыш: {amount}");
        }

        public override void Lose( int amount)
        {
            Console.WriteLine($"Проигрыш: {amount} ");
        }

        public override void Quit()
        {
            Console.WriteLine("Выход из игры на слот-машине");
        }
    }

    // Класс "Покер"
    public class Poker : Game
    {
        public int NumOfPlayers { get; }
        public string DeckType { get; set; }

        public Poker(string name, int minBet, int maxBet, int numOfPlayers, string deckType) : base(name, minBet, maxBet)
        {
            NumOfPlayers = numOfPlayers;
            DeckType = deckType;
        }

        // Методы для покера
        public override void Play()
        {
            Console.WriteLine("Играем в покер");
        }

        public override void Bet(int amount)
        {
            Console.WriteLine($"Ставим {amount} в покере");
        }

        public override void Win(int amount)
        {
            Console.WriteLine($"Выигрыш: {amount}");
        }

        public override void Lose(int amount)
        {
            Console.WriteLine($"Проигрыш: {amount}");
        }

        public override void Quit()
        {
            Console.WriteLine("Выход из игры в покере");
        }
    }

    // Класс "21"
    public class TwentyOne : Game
    {
        public int NumOfDecks { get; }
        public string Variation { get; }

        public TwentyOne(string name, int minBet, int maxBet, int numOfDecks, string variation) : base(name, minBet, maxBet)
        {
            NumOfDecks = numOfDecks;
            Variation = variation;
        }

        // Методы для игры "21"
        public override void Play()
        {
            Console.WriteLine("Играем в 21");
        }

        public override void Bet(int amount)
        {
            Console.WriteLine($"Ставим {amount} в 21");
        }

        public override void Win(int amount)
        {
            Console.WriteLine($"Выигрыш: {amount}");
        }

        public override void Lose(int amount)
        {
            Console.WriteLine($"Проигрыш: {amount}");
        }

        public override void Quit()
        {
            Console.WriteLine("Выход из игры в 21");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Создание объекта слот-машины
            SlotMachine slotMachine = new SlotMachine("Слот-машина", 1, 10, 3, "Фруктовая");
            Console.WriteLine($"Название игры: {slotMachine.Name}");
            Console.WriteLine($"Минимальная ставка: {slotMachine.MinBet}");
            Console.WriteLine($"Максимальная ставка: {slotMachine.MaxBet}");
            Console.WriteLine($"Количество барабанов: {slotMachine.NumOfReels}");
            Console.WriteLine($"Тема: {slotMachine.Theme}");
            slotMachine.Play();
            slotMachine.Bet(5);
            slotMachine.Win(10);
            slotMachine.Lose(1);
            slotMachine.Quit();

            Console.WriteLine();

            // Создание объекта покера
            Poker poker = new Poker("Покер", 10, 100, 4, "Стандартная");
            Console.WriteLine($"Название игры: {poker.Name}");
            Console.WriteLine($"Минимальная ставка: {poker.MinBet}");
            Console.WriteLine($"Максимальная ставка: {poker.MaxBet}");
            Console.WriteLine($"Количество игроков: {poker.NumOfPlayers}");
            Console.WriteLine($"Тип колоды: {poker.DeckType}");

            poker.Play();
            poker.Bet(20);
            poker.Win(78);
            poker.Lose(0);
            poker.Quit();

            Console.WriteLine();

            // Создание объекта "21"
            TwentyOne twentyOne = new TwentyOne("21", 5, 500, 6, "Классическая");
            Console.WriteLine($"Название игры: {twentyOne.Name}");
            Console.WriteLine($"Минимальная ставка: {twentyOne.MinBet}");
            Console.WriteLine($"Максимальная ставка: {twentyOne.MaxBet}");
            Console.WriteLine($"Количество колод: {twentyOne.NumOfDecks}");
            Console.WriteLine($"Вариация: {twentyOne.Variation}");

            twentyOne.Play();
            twentyOne.Bet(50);
            twentyOne.Win(100);
            twentyOne.Lose(15);
            twentyOne.Quit();

            Console.ReadLine();
        }
    }
}