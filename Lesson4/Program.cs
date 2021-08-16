using System;

namespace Lesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Введите текст");
            //string text = Console.ReadLine();

            string text = "GJdfbhsd8d 009098b sdsdg809df. 0df9? 0 d09fJHKP0...809d8f098g  0df9g8 d0/*-+9 dfg df0g0dfg809d" +
                " f d0fg98 d09   d0,9f8g 0d98fg d9" +
                "8089df0g89 dfKOJ0g98d? f0gd09f8.g 0d9fg80?9d8fg908 0, -0d0f8g09df809-0d980d80. 9000000 " +
                "fdgdsfgsdfg f gd fg dfsgh fh nhsdfg";

            Console.WriteLine(text);
            

            string wordWithNum = null;
            int countNum = 0;
            int maxCountNum = 0;
           

            string[] textMass = text.Split(' ');

            for (int j = 0; j < textMass[j].Length; j++)
            {
                for (int i = 0; i < textMass[j].Length; i++)
                {

                    if (Char.IsDigit(textMass[j], i))
                    {
                        countNum++;
                        
                    }

                    if (maxCountNum < countNum)
                    {
                        maxCountNum = countNum;
                        wordWithNum = textMass[j];
                        
                    }
                }                
            }
            Console.WriteLine("кол-во цифр в слове" + maxCountNum);
            Console.WriteLine("слово с макс цифр" + wordWithNum);

            
        }
    }
}
