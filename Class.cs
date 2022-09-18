using System;
using System.IO;
using TextCopy;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateLab
{
    class Journal
    {
        public static string NameOfStudent = "John Dow", Discipline = "Discipline";
        public static byte Mark = 0;
        public static DateTime DateOfMark = DateTime.Now;
        private static string path = "Journal.txt";

        public void SetName(string _name)
        {
            NameOfStudent = _name;
        }
        public string GetName()
        {
            return NameOfStudent;
        }
        public void PrintName()
        {
            Console.WriteLine(NameOfStudent);
        }
        public void WriteToFile()
        {
            string myDocs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            path = myDocs + "\\" + path;
            using (StreamWriter sw = File.AppendText(path))
                sw.WriteLine(NameOfStudent + " - " + Discipline);
            Console.WriteLine("Информация добавлена в файл {0}.", path);
        }
        public void CopyToClipboard()
        {
            ClipboardService.SetText(NameOfStudent + " " + Discipline);
            Console.WriteLine("Информация добавлена в буфер обмена.");
        }
        public string GetFromClipboard()
        {
            return ClipboardService.GetText();
        }
        public void SetDiscipline(string _discipline)
        {
            Discipline = _discipline;
        }
        public string GetDiscipline()
        {
            return Discipline;
        }
        public void PrintDiscipline()
        {
            Console.WriteLine(Discipline);
        }
        public void PrintNameAndDiscipline()
        {
            Console.WriteLine(NameOfStudent + " - " + Discipline);
        }
    }
}
