using System;
namespace lab5
{
    class Program
    {
        interface IComp
        {
            void Computer();
        }
        class Kon
        {
            IComp kon;
            public Kon(IComp k)
            {
                kon = k;
            }
            public void Start()
            {
                kon.Computer();
            }
        }
        class Cheap : IComp
        {
            public void Computer()
            {
                Console.WriteLine("This is a cheap computer.");
            }
        }
        class Exp : IComp
        {
            public void Computer()
            {
                Console.WriteLine("This is a expensive computer");
            }
        }
        interface IPhone
        {
            void Rost();
        }
        class Phone
        {
            IPhone phone;
            public Phone(IPhone ph)
            {
                phone = ph;
            }
            public void Start()
            {
                phone.Rost();
            }
        }
        class Small : IPhone
        {
            public void Rost()
            {
                Console.WriteLine("This is a phone with a large display.");
            }
        }
        class Big : IPhone
        {
            public void Rost()
            {
                Console.WriteLine("This is a small display phone");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("IPhone interface:");
            Phone small = new Phone(new Small());
            Phone big = new Phone(new Big());
            small.Start();
            big.Start();
            Console.WriteLine();
            Console.WriteLine("Demonstration of IComp interface:");
            Kon ch = new Kon(new Cheap());
            Kon ex = new Kon(new Exp());
            ch.Start();
            ex.Start();
            Console.ReadKey();
        }
    }
}