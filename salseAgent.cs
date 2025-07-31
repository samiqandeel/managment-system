using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class salseAgent : Employes
    {
        private const decimal persentgcomission = 0.05m;

        public  int totalsalse {  get; set; }
        protected decimal CalcComission()
        {
            return totalsalse * persentgcomission / 100;
        }
        protected override decimal  gross_pay()
        {
            return base.gross_pay() + CalcComission();
        }
        public override string ToString()
        {
            return $"\t* team : {this.GetType().Name} * \n" +
                   base.ToString() +
                   $"\n totalsalse : {totalsalse}" +
                   $"\n Comission : {CalcComission()}";
                   
        }
    }
}
