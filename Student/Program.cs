using StudentLibrary;
using System;

namespace StudentLibrary
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Qrup adini daxil edin: 2 boyuk herif 3 reqem olmalidir.");
            string groupNO = Console.ReadLine();
             while (!(groupNO.Length==5 && char.IsUpper(groupNO[0]) && char.IsUpper(groupNO[1]) && char.IsDigit(groupNO[2])&& char.IsDigit(groupNO[3]) && char.IsDigit(groupNO[4])))
             {
                Console.WriteLine("Qrup adini daxil edin: 2 boyuk herif 3 reqem olmalidir.");
                groupNO = Console.ReadLine();
             }
            Console.WriteLine("Qrupun max Telebe limitini  daxil edin 0-20 arasi");
            int groupLimit = Convert.ToInt32(Console.ReadLine());
            while (!(groupLimit > 0 && groupLimit < 20 ))
            {
                Console.WriteLine("Qrupun max Telebe limitini  daxil edin 0-20 arasi");
                groupLimit = Convert.ToInt32(Console.ReadLine());
            }
            Group group = new Group()
            {
                No = groupNO,
                studentLimit = groupLimit
            };
            bool check = true;
            while (check)
            {
                Console.WriteLine("1.Telebe elave et");
                Console.WriteLine("2.Butun telebelri goster");
                Console.WriteLine("3.Telebeler uzre axtarish et");
                Console.WriteLine("0.Proqrami bitir");

                string answer = Console.ReadLine();


                if (answer == "1")
                {
                    if (group.studentLimit >= group.students.Length+1)
                    {
                        Console.WriteLine("Fullname daxil edin : ");
                        string fullname = Console.ReadLine();
                        Console.WriteLine("Teleberin ortalam balin daxil etsin");
                        int AvgPoint = Convert.ToInt32(Console.ReadLine());
                        Student student = new Student(fullname)
                        {
                            GroupNo = groupNO,
                            avePoint=AvgPoint
                        };
                        group.AddStudent(student);
                    }
                    else
                    {
                        Console.WriteLine("Qrupda yer yoxdur,Limit dashmisiz.");
                    }

                }
                else if (answer == "2")
                {
                    group.getInfo();
                }
                else if(answer == "3")
                {
                    group.getFilter();
                }
                else if (answer == "0")
                {
                    check = false;
                    Console.WriteLine("Application End");
                }
                else
                {

                    Console.WriteLine("Duzgun secim edin ");
                }
            }
                 

        }
    }
}
