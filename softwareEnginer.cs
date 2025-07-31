using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class softwareEnginer :Employes
    {
        public int TraningAllowence { get; set; }
        public int storypointcompleted { get; set; }

        public int Bonus()
        {
            int bonus =  0;
            if (storypointcompleted >= 8)
            {
                bonus = 40;
            }
            return bonus;
        }

        protected override decimal gross_pay()
        {
            return base.gross_pay() + TraningAllowence + Bonus();

        }
        public override string ToString()
        {
            return 
                $"\t* team : {this.GetType().Name} *\n" +
                base.ToString() + 
                $" \n TraningAllowence : {TraningAllowence }" + 
                $" \n storypointcompleted: {storypointcompleted }";
        }
    }
}
