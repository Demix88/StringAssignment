using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string part1 = ("\"If opportunity ");
            string part2 = ("doesn't knock,  ");
            string part3 = ("build a door.\"");
            string part4 = ("– Milton Berle");
            string concat = (part1 + part2 + part3+"\n"+part4);
            Console.WriteLine(concat.ToUpper());
           




            StringBuilder sb = new StringBuilder();
            sb.Append("\n\"If I am not for myself, who is for me? ");
            sb.AppendLine("And if I am only for myself, what am I?");
            sb.AppendLine("And if not now, when?\"");
            sb.AppendLine("-Rabbi Hillel");
            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
