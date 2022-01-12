using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsOfCsharp
{
    internal class StringsPractice
    {
        static void Main()
        {
            Console.WriteLine("Enter full name: ");
            string fullName = Console.ReadLine();
            string[] arr = fullName.Split(' ');
            int last = Convert.ToInt32(arr.Length - 1);
        
            for (var i = 0; i < arr.Length; i++)
            {
             
                if (arr[i] != arr[last])
                {
                    Console.Write($"{arr[i].Substring(0,1).ToUpper()}.");
                }
            }
            Console.Write($"{arr[last].Substring(0,1).ToUpper()}{arr[last].Substring(1)}");
            Console.ReadLine();
        }
    }
}
