using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //InterfacesIntro();
            //manager.Add(student);
            //Demo();

            IcustomerDal[] customerDals = new IcustomerDal[] { new SqlServerCustomerDal(), new OracleCustomerDal(),new MySqlCustomerDal() };
            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }

        }

        private static void Demo()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new OracleCustomerDal());
        }
    }
    interface IPerson
    {
        int Id { get; set; }
        string Firstname { get; set; }
        string LastName { get; set; }

    }
    class Customer : IPerson
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string LastName { get; set; }
        public string Adress { get; set; }

    }
    class Student : IPerson
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string LastName { get; set; }
        public string Departmant { get; set; }
    }
    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.Firstname);
        }
    }
    class Worker : IPerson
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string LastName { get; set; }
        public string Departmant { get; set; }
    }
}

