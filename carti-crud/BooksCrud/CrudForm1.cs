using FotoFlow.Users.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BooksCrud
{
    public partial class CrudForm1 : Form
    {
        private List<User> users = new List<User>();
        bool seReincarca = false;
        public CrudForm1()
        {
            InitializeComponent();
        }

        private void btnIncarca_Click(object sender, EventArgs e)
        {
            users = DateDeStart();
            ReincarcaTabel();
            GolesteCampurile();
            lblStare.Text = ("S-au incarcat " + users.Count + " useri");

        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            User user = CitesteCampurile();
            if (user == null)
            {
                return;
            }

            users.Add(user);
            ReincarcaTabel();
            GolesteCampurile();
            lblStare.Text = "Adaugat: " + user.Nume;
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            int poz = PozitiaSelectata();
            if(poz < 0)
            {
                MessageBox.Show("Selecteaza intai un rand din tabel.");
                return;
            }

            User user = CitesteCampurile();
            if (user == null)
            {
                return;
            }

            users[poz] = user;
            ReincarcaTabel();
            GolesteCampurile();
            lblStare.Text = "Modificat: " + user.Nume;
        }

        private void btnSterge_Click(object sender, EventArgs e)
        {
            int poz = PozitiaSelectata();
            if (poz < 0)
            {
                MessageBox.Show("Selecteaza intai un rand din tabel.");
                return;
            }

            string nume = users[poz].Nume;
            users.RemoveAt(poz);
            ReincarcaTabel();
            GolesteCampurile();
            lblStare.Text = "Sters: " + nume;
        }

        private void ReincarcaTabel()
        {
            seReincarca = true;
            dgvUsers.DataSource = null;
            dgvUsers.DataSource = users;
            dgvUsers.ClearSelection();
            seReincarca = false;
        }

        private int PozitiaSelectata()
        {
            if (dgvUsers.CurrentRow == null)
            {
                return -1;
            }

            int i = dgvUsers.CurrentRow.Index;
            if (i < 0 || i >= users.Count)
            {
                return -1;
            }

            return i;
        }

        private void GolesteCampurile()
        {
            txtNume.Clear();
            txtEmail.Clear();
            txtVarsta.Clear();
            txtParola.Clear();
        }

        private User CitesteCampurile()
        {
            if (txtNume.Text == "")
            {
                MessageBox.Show("Numele nu poate fi gol.");
                txtNume.Focus();
                return null;
            }

            if (txtParola.Text == "")
            {
                MessageBox.Show("Parola nu poate fi goala.");
                txtParola.Focus();
                return null;
            }

            int varsta;
            if (!Int32.TryParse(txtVarsta.Text, out varsta))
            {
                MessageBox.Show("Varsta trebuie sa fie un numar intreg.");
                txtVarsta.Focus();
                return null;
            }

            User user = new User();
            user.Nume = txtNume.Text;
            
            try
            {
                user.Email = txtEmail.Text;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
                txtEmail.Focus();
                return null;
            }

            try
            {
                user.Varsta = varsta;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
                txtVarsta.Focus();
                return null;
            }

            try
            {
                user.Password = txtParola.Text;
            }
            catch (ArgumentException ex) 
            {
                MessageBox.Show(ex.Message);
                txtParola.Focus();
                return null;
            }

            return user;
        }

        private List<User> DateDeStart()
        {
            List<User> lista = new List<User>();
            lista.Add(Creeaza("Stefan", "stefan.ionescu@gmail.com", 18, "Aabcd123!"));
            lista.Add(Creeaza("Andrei", "andrei.popescu@yahoo.com", 17, "Aabcd123!"));
            lista.Add(Creeaza("Elena", "elena.marcu@outlook.com", 19, "Aabcd123!"));
            lista.Add(Creeaza("Raluca", "raluca.constantin@gmail.com", 16, "Aabcd123!"));
            lista.Add(Creeaza("Cosmin", "cosmin.radu@gmail.com", 20, "Aabcd123!"));
            lista.Add(Creeaza("Ana Maria", "ana.stan@yahoo.com", 15, "Aabcd123!"));
            lista.Add(Creeaza("Marian", "marian.dumitru@gmail.com", 22, "Aabcd123!"));
            lista.Add(Creeaza("Alexandru", "alex.neagu@outlook.com", 17, "Aabcd123!"));
            lista.Add(Creeaza("Cristina", "cristina.vlad@gmail.com", 18, "Aabcd123!"));
            lista.Add(Creeaza("Mihai", "mihai.badea@yahoo.com", 21, "Aabcd123!"));
            return lista;
        }

        private User Creeaza(string nume, string email, int varsta, string parola)
        {
            return new User(nume, email, varsta, parola);
        }
    }
}
