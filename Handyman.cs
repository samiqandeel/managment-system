using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Handyman : Employes 
    {
        public int hardship {  get; set; }

        protected override decimal gross_pay()
        {
            return base.gross_pay() + hardship ;
        }
        public override string ToString()
        {
            return
                $"\t* team : {this.GetType().Name} *\n" +
                base.ToString() +
                $"\n hardship : {hardship}";
        }
    }
}
