using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioHerancaePolimorfismo.Entities
{
    internal sealed class OutsourcedEmployee : Employee
    {
        public  double AdditionalCharge { get; set; }

        public OutsourcedEmployee(string name, int hour, double valueperhour,double additionalCharge)
            : base (name,hour, valueperhour)
        {
            AdditionalCharge = additionalCharge;
        }

        public override double Payment()
        {
            return (1.10*AdditionalCharge) + base.Payment();
        }

        
    }
}
