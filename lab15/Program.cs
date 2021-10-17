using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab15
{
    class Program
    {
        static void Main(string[] args)
        {
            ArithProgression arith = new ArithProgression();
            arith.setStart(4);
            Console.WriteLine("Арифметическая прогрессия");
            for (int i=0; i<6; i++)
            {
                Console.WriteLine("Следующее значение {0}", arith.getNext());
            }
            arith.reset();

            GeomProgression geom = new GeomProgression();
            geom.setStart(4);
            Console.WriteLine("Геометрическая прогрессия");
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("Следующее значение {0}", geom.getNext());
            }
            geom.reset();
            Console.ReadKey();
        }
    }
    //интерфейс
    interface ISeries
    {
        void setStart(int x);
        int getNext();
        void reset();
    }
    class ArithProgression : ISeries
    {
        int start;
        int next;
        public ArithProgression()
        {
            start = 0;
            next = 0;
        }
            
        public int getNext()
        {
            next += 2;
            return next;
        }

        public void reset()
        {
            next = start;
        }

        public void setStart(int x)
        {
            start = x;
            next = start;
        }
    }
    class GeomProgression : ISeries
    {
        int start;
        int next;
        public int getNext()
        {
            next = next * 2;
            return next;
        }

        public void reset()
        {
            next = start;
        }

        public void setStart(int x)
        {
            start = x;
            next = start;
        }
    }
}
