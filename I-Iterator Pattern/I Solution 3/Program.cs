using System;
using System.Threading;

namespace I_Solution_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            DinnerUnit dinnerUnit = new DinnerUnit();
            for (int i = 1; i <= 10; ++i)
            {
                String name = "DinnerItem" + i;
                float price = 50 + i * 5;
                int qty = r.Next(5) + 1;
                dinnerUnit.addItem(new MenuItem(name, price, qty));
            }

            BreakfastUnit breakfastUnit = new BreakfastUnit(5);
            for (int i = 1; i <= 5; ++i)
            {
                String name = "BreakfastItem" + i;
                float price = 30 + i * 5;
                int qty = r.Next(3) + 1;
                breakfastUnit.addItem(new MenuItem(name, price, qty));
            }

            var dummy = new Dummy(dinnerUnit, breakfastUnit);

            Thread t1 = new Thread(new ThreadStart(dummy.run));
            Thread t2 = new Thread(new ThreadStart(dummy.run));
            t1.Start();
            t2.Start();
        }
    }

    class Dummy
    {
        private DinnerUnit dinnerUnit;
        private BreakfastUnit breakfastUnit;

        public Dummy(DinnerUnit dinner, BreakfastUnit breakfast)
        {
            dinnerUnit = dinner;
            breakfastUnit = breakfast;
        }

        private void display(Iterator iterator)
        {
            while (iterator.hasNext())
                Console.WriteLine(iterator.next().ToString());
        }

        public void run()
        {
            display(dinnerUnit.iterator());
            display(breakfastUnit.iterator());
        }
    }
}