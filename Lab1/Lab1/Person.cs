using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    class Person
    {
        private string name;
        private string surname;
        private DateTime birthday;

        public Person()
        {
            name = "Борис";
            surname = "Ельцин";
            birthday = new DateTime(1931, 2, 1);
        }

        public Person(string name, string surname, DateTime bd)
        {
            this.name = name;
            this.surname = surname;
            this.birthday = bd;
        }
        /*public string getName()
        {
            return name;
        }

        public string getSurname()
        {
            return surname;
        }

        public DateTime getBirthDay()
        {
            return birthday;
        }

        public void setName(string name)
        {
            this.name = name;
        }
        public void setSurname(string surname)
        {
            this.surname = surname;
        }*/

        public string Name {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string Surname {
            get
            {
                return surname;
            }
            set
            {
                surname = value;
            }
        }
        public int Year 
        {
            get
            {
                return birthday.Year;
            }
            set
            {
                birthday = new DateTime(value, birthday.Month, birthday.Day);
            }
        }

        public override string ToString()
        {
            return Surname + " " + Name + " " + birthday.ToShortDateString();
        }

        public virtual string ToShortString()
        {
            return Surname + " " + Name;
        }
    }
}
