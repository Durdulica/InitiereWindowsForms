using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ExempluCrud
{
    public partial class CrudForm : Form
    {
        private List<Student> studenti = new List<Student>();
        private bool seReincarca = false;

        public CrudForm()
        {
            InitializeComponent();
        }

        private void btnIncarca_Click(object sender, EventArgs e)
        {
            studenti = DateDeStart();
            ReincarcaTabelul();
            GolesteCampurile();
            lblStare.Text = "Incarcati " + studenti.Count + " studenti";
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            Student s = CitesteCampurile();
            if (s == null)
            {
                return;
            }

            studenti.Add(s);
            ReincarcaTabelul();
            GolesteCampurile();
            lblStare.Text = "Adaugat: " + s.Nume + " " + s.Prenume;
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            int pozitie = PozitiaSelectata();
            if (pozitie < 0)
            {
                MessageBox.Show("Selecteaza intai un rand din tabel.");
                return;
            }

            Student s = CitesteCampurile();
            if (s == null)
            {
                return;
            }

            studenti[pozitie] = s;
            ReincarcaTabelul();
            lblStare.Text = "Modificat: " + s.Nume + " " + s.Prenume;
        }

        private void btnSterge_Click(object sender, EventArgs e)
        {
            int pozitie = PozitiaSelectata();
            if (pozitie < 0)
            {
                MessageBox.Show("Selecteaza intai un rand din tabel.");
                return;
            }

            string nume = studenti[pozitie].Nume + " " + studenti[pozitie].Prenume;
            studenti.RemoveAt(pozitie);
            ReincarcaTabelul();
            GolesteCampurile();
            lblStare.Text = "Sters: " + nume;
        }

        private void dgvStudenti_SelectionChanged(object sender, EventArgs e)
        {
            if (seReincarca)
            {
                return;
            }

            int pozitie = PozitiaSelectata();
            if (pozitie < 0)
            {
                return;
            }

            Student s = studenti[pozitie];
            txtNume.Text = s.Nume;
            txtPrenume.Text = s.Prenume;
            txtEmail.Text = s.Email;
            txtVarsta.Text = s.Varsta.ToString();
        }

        private int PozitiaSelectata()
        {
            if (dgvStudenti.CurrentRow == null)
            {
                return -1;
            }

            int i = dgvStudenti.CurrentRow.Index;
            if (i < 0 || i >= studenti.Count)
            {
                return -1;
            }

            return i;
        }

        private Student CitesteCampurile()
        {
            if (txtNume.Text == "")
            {
                MessageBox.Show("Numele nu poate fi gol.");
                txtNume.Focus();
                return null;
            }

            if (txtPrenume.Text == "")
            {
                MessageBox.Show("Prenumele nu poate fi gol.");
                txtPrenume.Focus();
                return null;
            }

            int varsta;
            if (!Int32.TryParse(txtVarsta.Text, out varsta))
            {
                MessageBox.Show("Varsta trebuie sa fie un numar intreg.");
                txtVarsta.Focus();
                return null;
            }

            Student s = new Student();
            s.Nume = txtNume.Text;
            s.Prenume = txtPrenume.Text;

            try
            {
                s.Email = txtEmail.Text;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
                txtEmail.Focus();
                return null;
            }

            try
            {
                s.Varsta = varsta;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
                txtVarsta.Focus();
                return null;
            }

            return s;
        }

        private void GolesteCampurile()
        {
            txtNume.Clear();
            txtPrenume.Clear();
            txtEmail.Clear();
            txtVarsta.Clear();
        }

        private void ReincarcaTabelul()
        {
            seReincarca = true;
            dgvStudenti.DataSource = null;
            dgvStudenti.DataSource = new List<Student>(studenti);
            dgvStudenti.ClearSelection();
            seReincarca = false;
        }

        private List<Student> DateDeStart()
        {
            List<Student> lista = new List<Student>();
            lista.Add(Creeaza("Ionescu", "Stefan", "stefan.ionescu@gmail.com", 18));
            lista.Add(Creeaza("Popescu", "Andrei", "andrei.popescu@yahoo.com", 17));
            lista.Add(Creeaza("Marcu", "Elena", "elena.marcu@outlook.com", 19));
            lista.Add(Creeaza("Constantin", "Raluca", "raluca.constantin@gmail.com", 16));
            lista.Add(Creeaza("Radu", "Cosmin", "cosmin.radu@gmail.com", 20));
            lista.Add(Creeaza("Stan", "Ana Maria", "ana.stan@yahoo.com", 15));
            lista.Add(Creeaza("Dumitru", "Marian", "marian.dumitru@gmail.com", 22));
            lista.Add(Creeaza("Neagu", "Alexandru", "alex.neagu@outlook.com", 17));
            lista.Add(Creeaza("Vlad", "Cristina", "cristina.vlad@gmail.com", 18));
            lista.Add(Creeaza("Badea", "Mihai", "mihai.badea@yahoo.com", 21));
            return lista;
        }

        private Student Creeaza(string nume, string prenume, string email, int varsta)
        {
            Student s = new Student();
            s.Nume = nume;
            s.Prenume = prenume;
            s.Email = email;
            s.Varsta = varsta;
            return s;
        }
    }
}
