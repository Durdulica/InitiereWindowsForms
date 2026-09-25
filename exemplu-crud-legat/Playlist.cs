using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace ExempluCrudLegat
{
    public class Playlist
    {
        private string nume;
        private string gen;
        private List<Melodie> melodii = new List<Melodie>();

        public string Nume
        {
            get { return nume; }
            set
            {
                if (value == null || value.Trim() == "")
                {
                    throw new ArgumentException("Numele playlistului nu poate fi gol.");
                }
                nume = value.Trim();
            }
        }

        public string Gen
        {
            get { return gen; }
            set
            {
                if (value == null || value.Trim() == "")
                {
                    throw new ArgumentException("Genul nu poate fi gol.");
                }
                gen = value.Trim();
            }
        }

        [Browsable(false)]
        public List<Melodie> Melodii
        {
            get { return melodii; }
        }

        public int NrMelodii
        {
            get { return melodii.Count; }
        }

        public string Durata
        {
            get
            {
                int total = 0;
                foreach (Melodie m in melodii)
                {
                    total = total + m.DurataSecunde;
                }
                return Melodie.Formateaza(total);
            }
        }

        public override string ToString()
        {
            return nume;
        }
    }
}
