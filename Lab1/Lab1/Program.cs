using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    struct Student
    {
        public string fio;
        public string age;
        public string math;
        public string phys;

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {fio} Age: {age}");
        }
    }

    

    class Program
    {
        //static public void Menu()
        //{
        //    Console.WriteLine("Add new student");
        //    Console.WriteLine("Show student");
        //    Console.WriteLine("Show all exelent student");
        //    Console.WriteLine("Show bad student");
        //    Console.Write("q");
        //    Console.Write("\n" + "Введите команду: ");

        //    string menu = Console.ReadLine();
        //    switch (menu)
        //    {
        //        case "Add new student":
        //            AddNewStudent();
        //            break;
        //        case "Show student":
        //            ShowStudent();
        //            break;
        //        case "Show all exelent student":
        //            ShowAllExelentStudent();
        //            break;
        //        case "Show bad student":
        //            ShowBadStudent();
        //            break;
        //        case "q":
        //            return;
        //    }
        //}

        static void Main(string[] args)
        {
            //    Student tom;
            //Console.Write("Enter name: ");
            //tom.fio = Console.ReadLine();
            //Console.Write("Enter age: ");
            //tom.age = Console.ReadLine();
            //Console.Write("Enter mathematic score: ");
            //tom.math = Console.ReadLine();
            //Console.Write("Enter physics score: ");
            //tom.phys = Console.ReadLine();
            //tom.DisplayInfo();

            Console.WriteLine("1. Add new student");
            Console.WriteLine("2. Show student");
            Console.WriteLine("3. Show all exelent student");
            Console.WriteLine("4. Show bad student");
            Console.Write("q");
            Console.Write("\n" + "Введите команду: ");

            string menu = Console.ReadLine();
            switch (menu)
            {
                case "1":
                    AddNewStudent();
                    break;
                case "2":
                    ShowStudent();
                    break;
                case "3":
                    ShowAllExelentStudent();
                    break;
                case "4":
                    ShowBadStudent();
                    break;
                case "q":
                    return;
            }

            Console.ReadKey();
        }

        static void AddNewStudent()
        {
            int[] arr = new int[10];



            Student tom;
            Console.Write("Enter name: ");
            tom.fio = Console.ReadLine();
            Console.Write("Enter age: ");
            tom.age = Console.ReadLine();
            Console.Write("Enter mathematic score: ");
            tom.math = Console.ReadLine();
            Console.Write("Enter physics score: ");
            tom.phys = Console.ReadLine();
        }

        static void ShowStudent()
        {
            
        }

        static void ShowAllExelentStudent()
        {

        }

        static void ShowBadStudent()
        {

        }
    }
}
