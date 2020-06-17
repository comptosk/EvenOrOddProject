using System;

namespace EvenOrOddProject {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Enter a number... any number: ");

            var ans = Console.ReadLine();
            var nbr = Convert.ToInt32(ans);

            if (nbr % 2 == 0) {
                Console.WriteLine($"The number is even.");
            } else {
                Console.WriteLine($"The number is odd.");
            }
              
        }
    }
}
