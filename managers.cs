using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class managers : Employes
    {
        private const int Allowance = 100;

        protected override decimal  gross_pay()
        {
            return base.gross_pay() + Allowance;
        }
        public override string ToString()
        {
            return $"\t* team : {this.GetType().Name} * \n" +
                   base.ToString() + 
                   $"\n Allowance : {Allowance}";
        }


    }
}
