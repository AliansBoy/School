using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Program
    {
        static void Main(string[] args)
        {
            Admin admin = new Admin();
            admin.CheckCapacity(15);

            SchoolRoom schoolRoom = new SchoolRoom(admin);

            while (true)
            {
                var check = Console.ReadKey().Key;
                switch (check)
                {
                    case ConsoleKey.Enter:
                        {
                            schoolRoom.CheckPeople(new Teacher());
                        }
                        break;
                    case ConsoleKey.Spacebar:
                        {
                            schoolRoom.CheckPeople(new Student());
                        }
                        break;
                    case ConsoleKey.Escape:
                        return;
                }
            }
        }
    }
}
