using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
    class Employee : Person, ICloneable
    {
        private int salary;
        public int Salary { get {return salary;} set { salary = value; } }

        private string profession;
        public string Profession { get { return profession; } set { profession = value; } }

        public Room Room;

        public Employee()
        {
            Room = null;
        }

        public Employee(string name, DateTime birthDate, int salary, string profession) : base(name, birthDate)
        {
            this.salary = salary;
            this.profession = profession;
            Room = null;
        }

        public override string ToString()
        {
            return base.ToString() + $"salary: {salary} , profession: {profession} , room: {Room.Number}";
        }


        public object Clone()
        {
            Employee newEmployee = (Employee)this.MemberwiseClone();
            newEmployee.Room = new Room(Room.Number);
            return newEmployee;
        }
    }
}
