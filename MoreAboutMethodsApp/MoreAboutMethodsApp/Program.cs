using System;

namespace MoreAboutMethodsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = DoThis(10, "Sad");
            var result2 = DoThis(25);
            var pizza1 = OrderPizza(true, pineapples: true, true);

            var myTuple = ("Joe", "Bloggs", 25);
            Console.WriteLine(myTuple);
            Console.WriteLine(myTuple.Item2);
            var myNamedTuple = (fName: "Jane", lName: "Doe", age: 32);
            Console.WriteLine(myNamedTuple.lName);
            
            var title = "The Shining";
            int copies = 3;
            var MyTuple3 = (title, copies);
            Console.WriteLine(MyTuple3);
            Console.WriteLine(MyTuple3.title);

            var weight = ConvertPoundsToStones(188);
        }
        public static (int stones, int pounds) ConvertPoundsToStones(int Pounds)
        {
            const int poundsInAStone = 14;
            var sty = Pounds / poundsInAStone;
            var lbs = Pounds % poundsInAStone;
            return(sty, lbs);
        }
        public static string OrderPizza(bool achovies, bool pineapples, bool mushrooms = false)
        {
            var pizza = "Pizza with tomato sauce, cheese, ";
            if (achovies) pizza += "anchovies, ";
            if (pineapples) pizza += "NO STOP IT NO PINEAPPLE, ";
            if (mushrooms) pizza += "mushrooms, ";
            return pizza;
        }
        public static int DoThis(int x, string y = "happy")
        {
            Console.WriteLine($"I'm feeling {y}");
            return x * x;
        }
    }
}
