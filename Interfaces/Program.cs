
using System;
namespace Interfaces;

class Program
{

    // interface new'lenemez!

    //interface ler referance tiptir!

    // interface ler onu implemente eden classın referance ını tutabilirler!

    static void Main(String[] args)
    {
        IPersonManager customerManager = new CustomerManager();
        customerManager.Add();

        IPersonManager employeeManager = new EmployeeManager();
        employeeManager.Add();

        ProjectManager projectManager = new ProjectManager();
        projectManager.Add(new CustomerManager()); 
        //  projectManager.Add(customerManager); ile aynı.
        projectManager.Update(employeeManager);

    }
    interface IPersonManager
    {
        void Add();

        void Update();
    }

    //inherits - class ---------- implements - interface

    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            //müşteri ekleme kodları
            Console.WriteLine("Müşteri eklendi.");
        }

        public void Update()
        {
            Console.WriteLine("Müşteri güncellendi.");
        }
    }

    class EmployeeManager : IPersonManager
    {
        //personel ekleme kodları
        public void Add()
        {
            Console.WriteLine("Personel eklendi.");
        }

        public void Update()
        {
            Console.WriteLine("Personel güncellendi.");
        }

        class ProjectManager
        {
            public void Add(IPersonManager personManager)
            {
                personManager.Add();
            }
        }

    }
    class ProjectManager
    {
        public void Add(IPersonManager personManager)
        {
            personManager.Add();
        }

        public void Update(IPersonManager personManager)
        {
            personManager.Update();
        }
    }
}