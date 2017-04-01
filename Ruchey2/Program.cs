using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ruchey2
{
    class Program
    {
        static void Main(string[] args)
        {
            var Monkey = new Monkey() { Name = "Monkey", Zoo = "Ruchey" };
            var Turt = new Turtle() { Name = "Turtle", Zoo = "Ruchey" };
            var Leo = new Leo() { Name = "Leo", Zoo = "Ruchey" };
            var Rab = new Employee() { Name = "Vasya", Zoo = "Ruchey" };
            var Client = new Client();
            var List = new List<IinZoo>() { Monkey, Turt, Leo, Rab};
            Console.ReadKey();
        }
    }
}
