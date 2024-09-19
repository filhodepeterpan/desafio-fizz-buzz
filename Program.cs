using System;

class Program{
    static void Main(){
        string saida = "";
        int fizz = 0;
        int buzz = 0;
        int fizzBuzz = 0;
        int apenasFizz = 0;
        int apenasBuzz = 0;

        for (int i = 1; i<=100; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                saida = "FizzBuzz";
                fizzBuzz++;
                fizz++;
                buzz++;
            }

            else if (i % 3 == 0 || i % 5 == 0)
            {
                saida = i % 3 == 0 ? "Fizz": "Buzz";

                fizz += i % 3 == 0 ? 1 : 0;
                buzz += i % 5 == 0 ? 1 : 0;
                apenasFizz += (i % 3 == 0 && i % 5 != 0) ? 1 : 0;
                apenasBuzz += (i % 5 == 0 && i % 3 != 0) ? 1 : 0;
            }

            else
            {
                saida = "";
            }

            string hifen = saida != "" ? "-": "";

            Console.WriteLine($"{i} {hifen} {saida}\n");
        }

        Console.Write("\n");
        Console.WriteLine($@"Contando de 1 a 100, temos:

        - {fizz} números divisíveis por 3 ao todo e {apenasFizz} números que são divisíveis APENAS por 3.
        - {buzz} números divisíveis por 5 ao todo e {apenasBuzz} números que são divisíveis APENAS por 5.
        - {fizzBuzz} números divisíveis  tanto por 3 quanto por 5.
        ");
    }
}
