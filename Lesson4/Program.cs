using System;

namespace Lesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string text = Console.ReadLine();

            Console.WriteLine("Выберите действие:");

            string[] wordWithNum = null;
            int countNum = 0;
            int maxCountNum = 0;

            string[] textMass = text.Split(' ');

            for (int i = 0; i <= 9; i++)
            {
                for (int j = 0; j < textMass[j].Length; j++)
                {
                   
                    if (Char.IsDigit(textMass[j], i))
                    {
                        countNum++;
                    }                    

                    if (maxCountNum < countNum)
                    {
                        maxCountNum = countNum;                       
                    }

                }
            }



            Console.WriteLine();
                
        }
    }
}
