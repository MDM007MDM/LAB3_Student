using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3
{
    internal class Student
    {
        public String _name;
        public String _id;
        public int _age;
        public int _BirthYear;
        public int _Hight;
        public int _Grade;
        public String _Branch;

        //constructor
        public Student (String name, String id , int BirthYear , int Age , int Hight , int Grade , String Branch)
        {
            this._name = name;
            this._BirthYear = BirthYear;
            this._id = id;
            this._Hight = Hight;
            this._Grade = Grade;
            this._Branch = Branch;
            this._age = Age;
        }

        public int myAge()
        {
            int age = 2023 - _BirthYear;
            return age;
        }
    }
}

