using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioHerancaePolimorfismo.Entities
{
    internal class Employee
    {
        public string Name { get; set; }

        public int Hour { get; set; }

        public double ValuePerHour { get; set; }

        public Employee() { }

        public Employee(string name, int hour, double valueperhour)
        {
            Name = name;
            Hour = hour;
            ValuePerHour = valueperhour;
        }

        public virtual double Payment()
        {
            return Hour * ValuePerHour;
        }

        public override string ToString()
        {
           

            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Payments");
            sb.AppendLine(Name + " - $" + Payment().ToString("F2"));

            return sb.ToString();

        }

    }
}
