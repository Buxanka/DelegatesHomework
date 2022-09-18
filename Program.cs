using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateLab
{
    class Program
    {
        delegate void Output();

        static void Choice(Journal myJournal)
        {
            Output _myOutput;
            Console.WriteLine("Вывести на экран? (Y) На экран и в файл (F)");
            string answer = Console.ReadLine();
            if (answer == "Y" | answer == "y")
            {
                _myOutput = myJournal.PrintNameAndDiscipline;
            }
            else
            {
                if (answer == "F" | answer == "f")
                {
                    _myOutput = myJournal.PrintNameAndDiscipline;
                    _myOutput += myJournal.WriteToFile;
                }
                else
                {
                    _myOutput = myJournal.WriteToFile;
                }

            }
            _myOutput += myJournal.CopyToClipboard;
            _myOutput += () => Console.WriteLine("Hello");
            _myOutput -= myJournal.PrintName;
            _myOutput += myJournal.PrintName;
            _myOutput();
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Введите имя студента: ");
            var myJournal = new Journal();
            myJournal.SetName(Console.ReadLine());
            Console.WriteLine("Введите дисциплину: ");
            myJournal.SetDiscipline(Console.ReadLine());
            Choice(myJournal);
            Console.WriteLine(myJournal.GetFromClipboard());
            Output func = () =>
            {
                Console.WriteLine("Hello");
                Console.WriteLine("Hello".Length);
            };
            func();
            //var func001(string _text) => Console.WriteLine(_text);

        }
    }
}
