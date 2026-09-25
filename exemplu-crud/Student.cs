using System;

namespace ExempluCrud
{
    public class Student
    {
        private string email;
        private int varsta;

        public string Nume { get; set; }
        public string Prenume { get; set; }

        public string Email
        {
            get { return email; }
            set
            {
                if (value == null || !value.Contains("@"))
                {
                    throw new ArgumentException("Emailul trebuie sa contina @");
                }
                email = value;
            }
        }

        public int Varsta
        {
            get { return varsta; }
            set
            {
                if (value < 14 || value > 100)
                {
                    throw new ArgumentException("Varsta trebuie sa fie intre 14 si 100");
                }
                varsta = value;
            }
        }
    }
}
