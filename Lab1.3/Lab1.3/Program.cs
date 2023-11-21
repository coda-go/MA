using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading;


namespace CSharp_Net_module1_1_4_lab
{
    class Program
    {
        // 1) declare enum ComputerType

        enum ComputerType
        {
            Desktop,
            Laptop,
            Server
        }

        // 2) declare struct Computer

        struct Computer
        {
            public string CPU;
            public string Memorry;
            public string HDD;
        }


        static void Main(string[] args)
        {
            // 3) declare jagged array of computers size 4 (4 departments)

            int[][] departments = new int[4][];

            // 4) set the size of every array in jagged array (number of computers)

            departments[0] = new int[3] { 2, 2, 1 };
            departments[1] = new int[3] { 0, 3, 0 };
            departments[2] = new int[3] { 3, 2, 0 };
            departments[3] = new int[3] { 1, 1, 2 };

            // 5) initialize array
            // Note: use loops and if-else statements


            for (int i = 0; i < departments.Length; i++)
            {
                for (int j = 0; j < departments[i].Length; j++)
                {
                    int counComputer = departments[i][j];

                    //int d = i; d++;
                    if (ComputerType.Desktop == (ComputerType)j)
                    {
                        ComputerType desktop = (ComputerType)counComputer;
                        //Console.WriteLine($"{d} departament have : \nDesktop = {counComputer}");
                    }
                    else if (ComputerType.Laptop == (ComputerType)j)
                    {
                        ComputerType laptop = (ComputerType)counComputer;
                        //Console.WriteLine($"Laptop = {counComputer}");
                    }
                    else
                    {
                        ComputerType server = (ComputerType)counComputer;
                        //Console.WriteLine($"Server = {counComputer}");
                    }
                }
            }


            // 6) count total number of every type of computers
            // 7) count total number of all computers
            // Note: use loops and if-else statements
            // Note: use the same loop for 6) and 7)

            int sumComputer = 0;
            int sumDesktop = 0;
            int sumLaptop = 0;
            int sumServer = 0;

            for (int i = 0; i < departments.Length; i++)
            {
                for (int j = 0; j < departments[i].Length; j++)
                {
                    int k = departments[i][j];
                    sumComputer += k;

                    if ((ComputerType)j == ComputerType.Desktop)
                    {
                        int d = departments[i][j];
                        sumDesktop += d;
                    }
                    else if ((ComputerType)j == ComputerType.Laptop)
                    {
                        int l = departments[i][j];
                        sumLaptop += l;
                    }
                    else if ((ComputerType)j == ComputerType.Server)
                    {
                        int s = departments[i][j];
                        sumServer += s;
                    }
                }
            }
            Console.WriteLine("count Desktop type " + sumDesktop);
            Console.WriteLine("count Laptop type " + sumLaptop);
            Console.WriteLine("count Server type " + sumServer);
            Console.WriteLine("count all computers " + sumComputer);

            // 8) find computer with the largest storage (HDD) - 
            // compare HHD of every computer between each other; 
            // find position of this computer in array (indexes)
            // Note: use loops and if-else statements

            Computer Desktop;
            Desktop.CPU = "4 cores, 2.5 HGz";
            Desktop.Memorry = "6 GB";
            Desktop.HDD = "500 GB";

            Computer Laptop;
            Laptop.CPU = "2 cores, 1.7 HGz";
            Laptop.Memorry = "4 GB";
            Laptop.HDD = "250 GB";

            Computer Server;
            Server.CPU = "8 cores, 3 HGz";
            Server.Memorry = "16 GB";
            Server.HDD = "2 TB";



            // 9) find computer with the lowest productivity (CPU and memory) - 
            // compare CPU and memory of every computer between each other; 
            // find position of this computer in array (indexes)
            // Note: use loops and if-else statements
            // Note: use logical oerators in statement conditions


            // 10) make desktop upgrade: change memory up to 8
            // change value of memory to 8 for every desktop. Don't do it for other computers
            // Note: use loops and if-else statements

        }
    }
}