using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lesson3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            string[] question = new string[] { "C# dilində int-in default dəyəri nədir?", "List-də element əlavə etmək üçün hansı metod istifadə olunur?", "Hansı keyword irsi göstərmək üçün istifadə olunur?", "C#-da static nə üçündür?", "Main() metodunun funksiyası nədir?" };
            string[] question1Options = { "1", "0", "null", "100" };
            string[] question2Options = { "Add()", "InsertItem()", "Push()", "Append()" };
            string[] question3Options = { "this", "base", ":", "inherit" };
            string[] question4Options = {"Kodun sürətini artırmaq üçün","Fərqli siniflərə daxil olmaq üçün","Obyektdən asılı olmayan metodlar üçün","Kodun tərcüməsini sürətləndirmək üçün"
};
            string[] question5Options = {"Yalnız test üçün istifadə olunur","GUI üçün istifadə olunur","Giriş nöqtəsidir","Event-lər üçün istifadə olunur"
};
            string[] CorrdectAnswers = new string[] { "0", "Add()", ":", "Obyektdən asılı olmayan metodlar üçün", "Giriş nöqtəsidir" };

            string[][] allOptions = new string[][]
           {
                question1Options,
                question2Options,
                question3Options,
                question4Options,
                question5Options
           };
            int[] index = new int[question.Length];
            for (int i = 0; i < index.Length; i++)
                index[i] = i;
            Random rand = new Random();
            int remaining = index.Length;
            int toplambal = 0;
            while (remaining > 0)
            {

                int randomQues = rand.Next(remaining);
                int questionIndex = index[randomQues];
                Console.WriteLine($"{index.Length - remaining + 1}. {question[questionIndex]}");
                string[] optionsCopy = (string[])allOptions[questionIndex].Clone();
                Shuffle(optionsCopy);
                for (int j = 0; j < allOptions[questionIndex].Length; j++)
                {
                    Console.WriteLine($"{(char)('A' + j)}) {optionsCopy[j]}");
                }
                Console.WriteLine();
                Console.Write("Cavabınızı daxil edin (A, B, C, D): ");
                string userAnswer = Console.ReadLine().ToUpper();

                int correctIndex = Array.IndexOf(optionsCopy, CorrdectAnswers[questionIndex]);
                int userAnswerIndex = userAnswer[0] - 'A';

                if (userAnswerIndex == correctIndex)
                {
                    Console.WriteLine("Düzgün cavab");
                    toplambal += 20;
                }
                else
                {
                    Console.WriteLine($"Yanlış cavab. Doğru cavab: {(char)('A' + correctIndex)}) {CorrdectAnswers[questionIndex]}");
                }

                index[randomQues] = index[remaining - 1];
                remaining--;
            }
        }
            static void Shuffle<T>(T[] array)
            {
                Random rand = new Random();
                for (int i = array.Length - 1; i > 0; i--)
                {
                    int j = rand.Next(i + 1);
                    T temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }
        }
    }



