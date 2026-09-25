using System;
using System.ComponentModel;

namespace ExempluCrudLegat
{
    public class Melodie
    {
        private string titlu;
        private string artist;
        private int durataSecunde;

        public string Titlu
        {
            get { return titlu; }
            set
            {
                if (value == null || value.Trim() == "")
                {
                    throw new ArgumentException("Titlul nu poate fi gol.");
                }
                titlu = value.Trim();
            }
        }

        public string Artist
        {
            get { return artist; }
            set
            {
                if (value == null || value.Trim() == "")
                {
                    throw new ArgumentException("Artistul nu poate fi gol.");
                }
                artist = value.Trim();
            }
        }

        [Browsable(false)]
        public int DurataSecunde
        {
            get { return durataSecunde; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Durata trebuie sa fie mai mare decat zero.");
                }
                if (value > 3600)
                {
                    throw new ArgumentException("Durata nu poate depasi o ora.");
                }
                durataSecunde = value;
            }
        }

        public string Durata
        {
            get { return Formateaza(durataSecunde); }
        }

        public static string Formateaza(int secunde)
        {
            int minute = secunde / 60;
            int rest = secunde % 60;
            return minute + ":" + rest.ToString("00");
        }

        public static bool IncearcaCitesteDurata(string text, out int secunde)
        {
            secunde = 0;

            if (text == null)
            {
                return false;
            }

            string[] parti = text.Trim().Split(':');
            if (parti.Length != 2)
            {
                return false;
            }

            int minute;
            if (!Int32.TryParse(parti[0], out minute))
            {
                return false;
            }

            int resturi;
            if (!Int32.TryParse(parti[1], out resturi))
            {
                return false;
            }

            if (minute < 0 || resturi < 0 || resturi > 59)
            {
                return false;
            }

            secunde = minute * 60 + resturi;
            return true;
        }
    }
}
