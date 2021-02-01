using System;

namespace InterfacesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[] { new Manager(), new Worker(),new Robot() };
            foreach (var worker in workers)
            {
                worker.Work();
            }
            IEat[] eats = new IEat[] {new Manager(),new Worker()};
            foreach (var eat in eats)
            {
                eat.Eat();
            }
            IGetSalary[] getSalary = new IGetSalary[] {new Manager(),new Worker() };
            foreach (var salary in getSalary)
            {
                salary.GetSalary();
            }
        }
    }
    interface IWorker
    {
        void Work();
        //void Eat();
        //void GetSalary();
    }
    interface IEat
    {
        void Eat();
    }
    interface IGetSalary
    {
        void GetSalary();
    }

    //class Manager : IWorker
    //{
    //    public void Eat()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void GetSalary()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void Work()
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
    //class Worker : IWorker
    //{
    //    public void Eat()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void GetSalary()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void Work()
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
    //class Robot : IWorker
    //{
    //    public void Eat()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void GetSalary()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void Work()
    //    {
    //        throw new NotImplementedException();
    //    }
    //}

    class Manager : IWorker, IEat, IGetSalary
    {
        public void Eat()
        {
            Console.WriteLine("Yemek yiyecek.");
        }

        public void GetSalary()
        {
            Console.WriteLine("Maaş alacak.");
        }

        public void Work()
        {
            Console.WriteLine("Çalışacak.");
        }
    }
    class Worker : IWorker, IEat, IGetSalary
    {
        public void Eat()
        {
            Console.WriteLine("Yemek yiyecek.");
        }

        public void GetSalary()
        {
            Console.WriteLine("Maaş alacak.");
        }

        public void Work()
        {
            Console.WriteLine("Çalışacak.");
        }
    }
    class Robot : IWorker
    {
        public void Work()
        {
            Console.WriteLine("Çalışacak.");
        }
    }
}
