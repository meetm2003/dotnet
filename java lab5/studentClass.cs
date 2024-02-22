using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labwork.java_lab5
{
    class student
    {
        private String name;
        private int id;
        public student()
        {
            name = null;
            id = 0;
        }
        public student(String name, int id)
        {
            this.name = name;
            this.id = id;
        }
        public String Name
        {
            get { return name; }
            set { name = value; }
        }
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
    }
    class results : student
    {
        private int rank;
        private double spi;
        public results(String name, int id, int rank, double spi) : base(name, id)
        {

            this.rank = rank;
            this.spi = spi;
        }

        public int Rank
        {
            get { return rank; }
            set { rank = value; }
        }
        public double SPI
        {
            get { return spi; }
            set { spi = value; }
        }
        public override String ToString()
        {
            return Name + " " + ID + " " + rank + " " + spi;
        }
    }
    public class students
    {
        public static void Main(String[] args)
        {

            double max = 5.5;
            Console.WriteLine("How many students : ");
            int n = Convert.ToInt32(Console.ReadLine());
            results[] r = new results[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter Student details");
                Console.Write("Enter Name : ");
                String name = Console.ReadLine();
                Console.Write("Enter ID : ");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Rank : ");
                int rank = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter SPI : ");
                double spi = Convert.ToDouble(Console.ReadLine());

                r[i] = new results(name, id, rank, spi);
            }
            for (int i = 0; i < n; i++)
            {
                if (r[i].Rank < 10)
                {
                    Console.WriteLine("Rank less than 10: " + r[i]);
                }

                if (r[i].SPI > max)
                {
                    max = r[i].SPI;
                    Console.WriteLine("Highest SPI: " + r[i]);
                }
                double s1 = 7.0;
                double s2 = 10.0;
                if (r[i].SPI > s1 || r[i].SPI < s2)
                {
                    Console.WriteLine("SPI in range " + s1 + " to " + s2
                    + " : " + r[i]);
                }

                if (r[i].Rank >= 1 && r[i].Rank <= 2)
                {
                    Console.WriteLine("Rank Between 1 & 2: " + r[i] + "\n");
                }
            }
        }
    }

}
