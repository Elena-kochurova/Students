using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;



namespace Students1
{
    public class Class1
    {
        static void Main(string[] args)
        {
            int action;
            string studInfo;
            string course;
            string facultet;



            while (true)
            {
                action = 0;
                Console.WriteLine(" Введите номер действия: \n 1.Посмотреть ранне добавленных студентов. \n 2.Добавить студента.");
                int.TryParse(Console.ReadLine(), out action);
                Console.WriteLine();
                switch (action)
                {
                    case 1:
                        try
                        {
                            using (StreamReader reader = new StreamReader("students.txt"))
                            {
                                string textFromFile = reader.ReadToEnd();
                                Console.WriteLine(textFromFile);
                            }
                        }
                        catch
                        {
                            Console.WriteLine(" Не удалось загрузить список студентов");
                        }
                        break;
                    case 2:
                        course = "";
                        facultet = "";
                        studInfo = "";
                        string test = "";
                        Console.WriteLine("Введите ФИО:");

                        test = Console.ReadLine() + "\t";

                        foreach (char c in test)
                            if ((Char.IsLetter(c)) || Char.IsWhiteSpace(c))
                            {
                                studInfo += c;

                            }
                            else { break; }

                        Console.WriteLine("Введите факультет:");

                        test = Console.ReadLine() + "\f";
                        foreach (char c in test)
                            if (Char.IsLetter(c) || Char.IsWhiteSpace(c))
                            {
                                course += c;
                            }
                            else { break; }
                        Console.WriteLine("Введите специальность:");
                        test = Console.ReadLine() + "\f";
                        foreach (char c in test)
                            if (Char.IsLetter(c) || Char.IsWhiteSpace(c))
                            {
                                facultet += c;
                            }
                            else { break; }

                        using (StreamWriter writer = new StreamWriter("students.txt", true))
                        {
                            writer.WriteLine(studInfo);
                            writer.WriteLine(course);
                            writer.WriteLine(facultet);
                            Console.WriteLine("Новый студент добавлен!");
                        }
                        break;
                    default:
                        Console.WriteLine("Введены не еорректные данные!");
                        break;


                }
            }
        }
    }
}
