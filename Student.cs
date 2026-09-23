
namespace InitiereWindowsForms
{
    public class Student
    {
        public string Nume { get; set; }
        public string Prenume { get; set; }
        private string email;
        private int varsta;

        public string Email
        {
            get { return email; }
            set
            {
                if (!value.Contains("@"))
                {
                    throw new System.ArgumentException("Email gresit");
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
                    throw new System.ArgumentException("Varsta gresita");
                }
                varsta = value;
            }
        }
    }
}