using System;
using System.Text.RegularExpressions;

namespace Lesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Введите текст");
            //string text = Console.ReadLine();

            string text = "GJdfbhsd8d 009098b -0d0f8g09df809-0d980d80." +
                " sdsdg809df. 0df9? 0 d09fJHKP0...809d8f098g " +
                " 0df9g8 d0/*-+9 dfg df0g0dfg809d" +
                " f d0fg98 d09?   d0,9f8g 0d98fg d9.!" +
                "8089df0g89 dfKOJ0g98d? f0gd09f8.g! 0d9fg80?9d8fg908 0," +
                " -0d0f8g09df809-0d980d80. 9000000 " +
                "fdgdsfgsdfg f gd fg. dfsgh fh nhsdfg";

            Console.WriteLine(text);
            Console.WriteLine("//////////////////////////////////////////////////////");

            string wordWithNum = null;
            string mostLengthWord = null;
            int operation;
            int countNum = 0;
            int maxCountNum = 0;          
            int numOfLetters = 0;
            int countLongWords = 0;                                    


            Console.WriteLine("Выберите операцию:");
            Console.WriteLine("1 - слово с max количеством цифр");
            Console.WriteLine("2 - самое длинное слово и сколько раз встретилось");
            Console.WriteLine("3 - заменить все цифры словами");

            string choise = Console.ReadLine();

            bool result = int.TryParse(choise, out operation);
            if (result == false)
            {
                Console.WriteLine("Неверный код операции");
            }


            if (operation == 1)
            {
                // разделение текста на отдельные слова
                string[] textMass = text.Split(' ');

                //вывод слова с max содержанием цифр внутри
                for (int j = 0; j < textMass.Length; j++)
                {
                    countNum = 0;
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
                Console.WriteLine("кол-во цифр в слове " + maxCountNum);
                Console.WriteLine("слово с макс цифр " + wordWithNum);
            }

            else if (operation == 2)
            {
                //поиск и вывод самого длинноко слова. +сколько раз оно встречается в тексте.
                string[] textMass = text.Split(' ');

                for (int j = 0; j < textMass.Length; j++)
                {
                    for (int i = 0; i < textMass[j].Length; i++)
                    {
                        if (numOfLetters < textMass[j].Length)
                        {
                            numOfLetters = textMass[j].Length;
                            mostLengthWord = textMass[j];
                        }
                    }
                }
                for (int j = 0; j < textMass.Length; j++)
                {
                    if (mostLengthWord == textMass[j])
                    {
                        countLongWords++;
                    }
                }

                Console.WriteLine("Самое длинное слово - " + mostLengthWord);
                Console.WriteLine(numOfLetters + " символа в слове");
                Console.WriteLine(countLongWords + " раза встретилось в тексте");
            }

            else if (operation == 3)
            {
                text = text.Replace("0", "НОЛЬ");
                text = text.Replace("1", "ОДИН");
                text = text.Replace("2", "ДВА");
                text = text.Replace("3", "ТРИ");
                text = text.Replace("4", "ЧЕТЫРЕ");
                text = text.Replace("5", "ПЯТЬ");
                text = text.Replace("6", "ШЕСТЬ");
                text = text.Replace("7", "СЕМЬ");
                text = text.Replace("8", "ВОСЕМЬ");
                text = text.Replace("9", "ДЕВЯТЬ");

                Console.WriteLine(text);

            }

            else if (operation == 4)
            {
                
                string[] sentences = Regex.Split(text, @"(?<=[\.!\?])\s+");

                for (int i = 0; i < sentences.Length; i++)
                {
                    if (sentences[i].EndsWith("?"))
                    {
                        int z = i;
                        while (z > 0 && sentences[z-1].EndsWith("?"))
                        {
                            string cons = sentences[z - 1];
                            sentences[z - 1] = sentences[z];
                            sentences[z] = cons;
                            z--;
                        }
                    }
                }

                for (int i = 0; i < sentences.Length; i++)
                { 
                    Console.WriteLine(sentences[i]);
                }
            }
        }
    }
}
