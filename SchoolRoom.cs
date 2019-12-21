using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class SchoolRoom
    {
        public SchoolRoom (Admin admin)
        {
            Humen = new List<Human>();
            Admininstrator = admin;
        }
        Admin Admininstrator { get; }

        List<Human> Humen;

        int TeacherCount = 0;

        public void CheckPeople (Human human)
        {
            if (human is Teacher && TeacherCount < 1 && Humen.Count() < Admininstrator.Capacity)
            {
                Humen.Add(human);
                Console.WriteLine($"{Humen.Count}");
                TeacherCount++;
            }
            else if (human is Student && Humen.Count() < Admininstrator.Capacity)
            {
                Humen.Add(human);
                Console.WriteLine($"{Humen.Count}");
            }
            else Console.WriteLine($"Go out ...,");
        }
    }
}
