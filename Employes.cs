using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal abstract class Employes
    {
        protected  const decimal persentegofovertime = 1.5m;
        protected  const decimal  persentageTAx = 0.10m;
        public string Id {  get; set; }
        public string F_name {  get; set; }
        public string L_name {  get; set; }
        public decimal  Hourlyrate {  get; set; }
        public int Exepetedhours {  get; set; }
        public int  loggedhours {  get; set; }

        protected decimal  Basicsalary()
        {
            return Exepetedhours * Hourlyrate;
        }
        protected decimal overtiem()
        {
            decimal divetionhour = loggedhours - Exepetedhours;
            return Math.Max(divetionhour, 0) * Hourlyrate * persentegofovertime;
        }

        protected virtual  decimal  gross_pay()
        {
            return Basicsalary() + overtiem() ;
        }
        protected decimal Tax()
        {
            return gross_pay() * persentageTAx;
        }
        protected  decimal netsalary()
        {
            return gross_pay() - Tax();
        }

        public override string ToString()
        {
            return $" name is : [{Id}], ({F_name} {L_name}) " +
                   $" \n Hourlyrate : {Hourlyrate} " +
                   $" \n Exepetedhours {Exepetedhours} " +
                   $" \n loggedhours :{loggedhours} " +
                   $" \n Basicsalary : {Basicsalary()} " +
                   $" \n overtiem : {overtiem()} " +
                   $" \n grosspuy : {gross_pay()}" +
                   $" \n Tax : {Tax()}" +
                   $" \n netsalary : {netsalary()}";
        }
    }
}
