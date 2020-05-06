using System;
using System.IO;

namespace oopLaba3_2
{
    class Program
    {
      
       
        static void Reverse(string str )
        {
            string[] mystring = str.Split(" ");
            char[] inputarray = mystring[0].ToCharArray();
            Array.Reverse(inputarray);



            string output = new string(inputarray);
            foreach(char i in inputarray)
            {
                Console.WriteLine(i);
            }



        }
        static void text(string str)
        {
            string[] mystring = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Console.Write("Кiлькiсть букв в словi=" + mystring[0].Length+"\n");
            int i = int.Parse(mystring[1])+10;
            Console.WriteLine("Число="+i);
        }
        

        static void Main(string[] args)
        {
            string path = "D:\\zavd.txt";
            Console.WriteLine("Введит рядок ");
            using (var sw =new StreamReader(path)) {

                string str = sw.ReadToEnd();
                string str = sw.ReadToEnd();

                Reverse(str);
                text(str);
            } 
        }
    }
}
