using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    class Average<T>
    {
        private List<string> avrg = new List<string>(); //создаем список строк, куда будем класть любой тип
        private List<double> avrgdl = new List<double>(); //любой тип преобразуем в дабл, так как предполагаем, что наши типы лежат в пространтве Re
        public void add (T value)
        {
            string pre = Convert.ToString(value);
            avrg.Add(pre);
        }
        public void reset()
        {
            avrg.Clear();
        }
        public double average()
        {
            double sum = 0;
            foreach (string a in avrg)
            {
                sum += Convert.ToDouble(a);
            }
            return sum;
        }
    } 
    class Program
    {
        static void Main(string[] args)
        {
            Average<int> test = new Average<int>();
            for (int i = 0; i < 6; i++)
            {
                test.add(i);
            }
            Console.WriteLine(test.average());

            Average<double> test1 = new Average<double>();
            test1.reset();
            for (int i = 0; i < 6; i++)
            {
                double newfloat = Convert.ToDouble(i) + 0.5;
                test1.add(newfloat);
            }
            Console.WriteLine(test1.average());
            Console.ReadKey();
        }
    }
}
