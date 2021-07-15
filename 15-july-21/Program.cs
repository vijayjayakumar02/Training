using System;

namespace _15_july_21
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer computer = new Computer();
            computer.configuration();
            computer.warranty();

            Laptop laptop = new Laptop();
            laptop.configuration();
            laptop.warranty();

            Headphone headphone = new Headphone();
            headphone.configuration();
            laptop.warranty();

            Dockstation dockstation = new Dockstation();
            dockstation.configuration();
            dockstation.warranty();


            facebook fb = new facebook();
            fb.get_userName();
            fb.get_newUserName();

            Access_specifiers access = new Access_specifiers();
            access.print();
        }
    }
}
