using System;
using System.Collections.Generic;
using System.Text;

namespace StudentLibrary
{
    class Group
    {
        public string No;
        public Student[] students = new Student[0];
        public int studentLimit;

        public Student[] AddStudent( Student student)
        {
            Array.Resize(ref students, students.Length + 1);
            students[students.Length - 1] = student;
            return students;
        }
        public void getInfo()
        {
            foreach (var item in students)
            {
                Console.WriteLine($"Telebenin Fullname {item.Fullname} Ortalama Bali {item.avePoint}  Qrup Nomresi {item.GroupNo}");
            }
        }
        public void getFilter()
        {
            Console.WriteLine("Telebenin fullname-ni daxil edin.");
            string fullname = Console.ReadLine();
            int count = 0;
            foreach (var item in students)
            {
                if(item.Fullname == fullname)
                {
                    count++;
                    Console.WriteLine($"Telebenin adi {item.Fullname} | Ortalam bali {item.avePoint} Qrup adi {item.GroupNo}");
                }
               
            }
            if (count == 0)
            {
                Console.WriteLine("Bele bir telebe yoxdur");
            }
        }
    }
}
