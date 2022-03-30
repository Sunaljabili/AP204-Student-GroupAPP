using System;
namespace ClassLibrary
{
    public class Employee
    {
        private string _name;
        private string _surname;
        private int _salary;

        public string Name {
            get
            {
                return _name;
            }
            set {

                int count = 0;
                foreach (var item in value)
                {

                    if (!char.IsLetter(item))
                    {
                        count++;

                    }
                }
                if(count ==0 && char.IsUpper(value[0]) )
                {
                    _name = value;
                }
                else
                {
                    Console.WriteLine("Ilk herf boyuk ve Hamisi soz olmalidir.");
                }

            }
        }
        public string Surname  {

            get
            {
                return _surname;
            }
            set {

                int count = 0;
                foreach (var item in value)
                {

                    if (!char.IsLetter(item))
                    {
                        count++;

                    }
                }
                if (count == 0 && char.IsUpper(value[0]))
                {
                    _surname = value;
                }
                else
                {
                    Console.WriteLine("Ilk herf boyuk ve Hamisi soz olmalidir.");
                }
            }

        }
        public int Salary {
            get {
                return _salary;
            }
            set {
                if (value > 250)
                {
                    _salary = value;
                }
                else
                {
                    Console.WriteLine("Maash 250den az ola bilmez.");
                }
            }
        }

    }
}
