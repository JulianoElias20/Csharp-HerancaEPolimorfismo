using ExercicioHerancaePolimorfismo.Entities;
using System;

namespace MyApp 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of employes");
            int n = int.Parse(Console.ReadLine());

            List<Employee> list = new List<Employee>();



            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Employe #" + i + " data:");
                Console.Write("Outsourced (y/n)");
                string check = Console.ReadLine();

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Hours: ");
                int hour = int.Parse(Console.ReadLine());

                Console.Write("Value per hour: ");
                double valuehour = double.Parse(Console.ReadLine());



                if (check == "Y" || check == "y")
                {
                    Console.Write("Addtional charge: ");
                    double charge = double.Parse(Console.ReadLine());

                    list.Add(new OutsourcedEmployee(name, hour, valuehour, charge));
                }

                else if (check=="n" || check == "N")
                {
                    list.Add(new Employee(name, hour, valuehour));
                }

                
            }
            foreach (Employee obj in list)
            {
                Console.WriteLine(obj.ToString());
            }
        }

    }
}
