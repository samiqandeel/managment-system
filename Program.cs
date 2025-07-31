namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employes e1 = new managers
            {
                Id = "0001",
                F_name ="sami",
                L_name = ".q",
                Hourlyrate = 10,
                Exepetedhours = 40,
                loggedhours = 40,
                
            };

            Console.WriteLine( e1 );

            Console.WriteLine( " \n\n*******************\n\n ");

            Employes e2 = new salseAgent 
            {
                Id = "0002",
                F_name = "farag",
                L_name = ".A",
                Hourlyrate = 10,
                Exepetedhours = 40,
                loggedhours = 45,
                totalsalse = 10000,
                

            };
            Console.WriteLine(e2);

            Console.WriteLine( " \n\n*******************\n\n ");

            Employes e3 = new Handyman
            {
                Id = "0003",
                F_name = "Ahmed",
                L_name = ".A",
                Hourlyrate = 5,
                Exepetedhours = 40,
                loggedhours = 65,
                hardship = 75

            };
            Console.WriteLine(e3);

            Console.WriteLine( " \n\n*******************\n\n ");

            Employes e4 = new softwareEnginer 
            {
                Id = "0004",
                F_name = "Elsaed",
                L_name = ".R",
                Hourlyrate = 10,
                Exepetedhours = 40,
                loggedhours = 40,
                TraningAllowence = 50 ,
                storypointcompleted = 8

            };
            Console.WriteLine(e4);

        }
    }
}
