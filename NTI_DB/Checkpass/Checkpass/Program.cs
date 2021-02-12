using System;
using System.Linq;


public class Program
{
    static void Main(string[] args)
    {

        string newPass = CreatePasswors();
        Console.WriteLine($"Надёжность пароля: {GetRatePassInPoints(newPass)}.");
        Console.WriteLine();

    }

    static string CreatePasswors()
    {
        while (true)
        {
            Console.Write("Введите ваш пароль, не менее 8-ти символов: ");
            string pass = Console.ReadLine();
            if (pass.Length < 8)
            {
                Console.Write("Слишком мало символов, попробуйте ещё раз, нажмите 'Enter'");
                Console.ReadLine();
                Console.Clear();
            }
            else return pass;
        }
    }

    static string GetRatePassInPoints(string pass)
    {

        int points = 0;

        if (pass.Length > 8)
        {
            string mess1 = "-> больше 8-ми символов +1"; points++;
        }
        if (pass.Any(c => char.IsUpper(c)))
        {
            string mess2 = "-> есть заглавные буквы +1"; points++;
        }
        if (pass.Any(c => char.IsDigit(c)))
        {
            string mess3 = "-> есть цифры +1"; points++;
        }
        if (pass.Any(c => char.IsPunctuation(c)))
        {
            string mess4 = "-> есть знаки препинания +1"; points++;
        }

       
        string rule ="Пароль должен включать в себя заглавную буку, знаки пунктуации и числа";
        string[] rates = new string[] { "надёжность пароля очень низкая", "Низкая", "Средняя", "Высокая", "Очень высокая" };
        return rates[points];
        
        
    }
}