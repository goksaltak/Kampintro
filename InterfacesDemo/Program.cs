using System;

namespace InterfacesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[] { new Manager(),new Worker(),new Robot() };

            foreach (var worker in workers)
            {
                worker.Work();
            }

            IEat[] eats = new IEat[] { new Manager(), new Worker()};
        }
    }
    interface IWorker
    {
        void Work();
    }
    interface IEat
    {
        void IEat();
    }

    interface ISalary
    {
        void GetSalary();
    }

    class Manager : IWorker, IEat, ISalary
    {
        public void GetSalary()
        {
            throw new NotImplementedException();
        }

        public void IEat()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            throw new NotImplementedException();
        }
    }
    class Worker : IWorker, IEat, ISalary
    {
        public void GetSalary()
        {
            throw new NotImplementedException();
        }

        public void IEat()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            throw new NotImplementedException();
        }
    }
    class Robot : IWorker
    {
        public void Work()
        {
            throw new NotImplementedException();
        }
    }
}
