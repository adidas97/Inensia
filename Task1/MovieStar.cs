using System;
using System.Text;

namespace Task1
{
   public class MovieStar
    {
        public MovieStar(DateTime birthDate, string name, string surname, string sex, string nationality)
        {
            DateOfBirth = birthDate;
            Name = name;
            Surname = surname;
            Sex = sex;
            Nationality = nationality;
        }
        public DateTime DateOfBirth { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Sex { get; set; }
        public string Nationality { get; set; }

        private int CalculateYears()
        {
            DateTime dt = new DateTime(2018, 8, 22);
            var differenceInDays = dt - this.DateOfBirth;
            int currentAge = differenceInDays.Days / 365;
            return currentAge;
        }

        public override string ToString()
        {
            int currentYears = CalculateYears();
            var sb = new StringBuilder();
            sb.AppendLine($"{Name} {Surname}");
            sb.AppendLine(Sex);
            sb.AppendLine(Nationality);
            sb.AppendLine($"{currentYears} years old");
            return sb.ToString();
        }
    }
}
