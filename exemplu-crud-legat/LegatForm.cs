using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ExempluCrudLegat
{
    public partial class LegatForm : Form
    {
        private List<Playlist> playlists = new List<Playlist>();
        private bool seReincarca = false;

        public LegatForm()
        {
            InitializeComponent();
        }

        private void btnIncarca_Click(object sender, EventArgs e)
        {
            playlists = DateDeStart();
            ReincarcaTot(-1);
            GolesteCampurilePlaylist();
            GolesteCampurileMelodie();
            lblStare.Text = "Incarcate " + playlists.Count + " playlisturi cu " +
                NumaraToateMelodiile() + " melodii";
        }

        private void btnAdaugaP_Click(object sender, EventArgs e)
        {
            Playlist p = CitestePlaylistDinCampuri();
            if (p == null)
            {
                return;
            }

            if (ExistaPlaylistCuNumele(p.Nume, -1))
            {
                MessageBox.Show("Mai exista un playlist cu numele " + p.Nume + ".");
                txtNumeP.Focus();
                return;
            }

            playlists.Add(p);
            ReincarcaTot(playlists.Count - 1);
            GolesteCampurilePlaylist();
            lblStare.Text = "Adaugat playlistul " + p.Nume;
        }

        private void btnModificaP_Click(object sender, EventArgs e)
        {
            int pozitie = PozitiaPlaylistSelectat();
            if (pozitie < 0)
            {
                MessageBox.Show("Selecteaza intai un playlist din tabelul din stanga.");
                return;
            }

            Playlist nou = CitestePlaylistDinCampuri();
            if (nou == null)
            {
                return;
            }

            if (ExistaPlaylistCuNumele(nou.Nume, pozitie))
            {
                MessageBox.Show("Mai exista un playlist cu numele " + nou.Nume + ".");
                txtNumeP.Focus();
                return;
            }

            Playlist vechi = playlists[pozitie];
            vechi.Nume = nou.Nume;
            vechi.Gen = nou.Gen;

            ReincarcaTot(pozitie);
            lblStare.Text = "Modificat playlistul " + vechi.Nume;
        }

        private void btnStergeP_Click(object sender, EventArgs e)
        {
            int pozitie = PozitiaPlaylistSelectat();
            if (pozitie < 0)
            {
                MessageBox.Show("Selecteaza intai un playlist din tabelul din stanga.");
                return;
            }

            Playlist p = playlists[pozitie];

            if (p.NrMelodii > 0)
            {
                MessageBox.Show("Playlistul " + p.Nume + " are " + p.NrMelodii +
                    " melodii. Muta-le sau sterge-le intai, apoi sterge playlistul.");
                return;
            }

            playlists.RemoveAt(pozitie);
            ReincarcaTot(-1);
            GolesteCampurilePlaylist();
            GolesteCampurileMelodie();
            lblStare.Text = "Sters playlistul " + p.Nume;
        }

        private void btnAdaugaM_Click(object sender, EventArgs e)
        {
            int pozitiePlaylist = PozitiaPlaylistSelectat();
            if (pozitiePlaylist < 0)
            {
                MessageBox.Show("Selecteaza intai playlistul in care intra melodia.");
                return;
            }

            Melodie m = CitesteMelodieDinCampuri();
            if (m == null)
            {
                return;
            }

            Playlist p = playlists[pozitiePlaylist];

            if (ExistaMelodieInPlaylist(p, m.Titlu, m.Artist, -1))
            {
                MessageBox.Show("Melodia " + m.Titlu + " de " + m.Artist +
                    " este deja in playlistul " + p.Nume + ".");
                txtTitluM.Focus();
                return;
            }

            p.Melodii.Add(m);
            ReincarcaTot(pozitiePlaylist);
            GolesteCampurileMelodie();
            lblStare.Text = "Adaugat " + m.Titlu + " in " + p.Nume;
        }

        private void btnModificaM_Click(object sender, EventArgs e)
        {
            int pozitiePlaylist = PozitiaPlaylistSelectat();
            if (pozitiePlaylist < 0)
            {
                MessageBox.Show("Selecteaza intai un playlist.");
                return;
            }

            int pozitieMelodie = PozitiaMelodieSelectata();
            if (pozitieMelodie < 0)
            {
                MessageBox.Show("Selecteaza intai o melodie din tabelul din dreapta.");
                return;
            }

            Melodie nou = CitesteMelodieDinCampuri();
            if (nou == null)
            {
                return;
            }

            Playlist p = playlists[pozitiePlaylist];

            if (ExistaMelodieInPlaylist(p, nou.Titlu, nou.Artist, pozitieMelodie))
            {
                MessageBox.Show("Melodia " + nou.Titlu + " de " + nou.Artist +
                    " este deja in playlistul " + p.Nume + ".");
                txtTitluM.Focus();
                return;
            }

            Melodie vechi = p.Melodii[pozitieMelodie];
            vechi.Titlu = nou.Titlu;
            vechi.Artist = nou.Artist;
            vechi.DurataSecunde = nou.DurataSecunde;

            ReincarcaTot(pozitiePlaylist);
            SelecteazaMelodia(pozitieMelodie);
            lblStare.Text = "Modificat " + vechi.Titlu;
        }

        private void btnStergeM_Click(object sender, EventArgs e)
        {
            int pozitiePlaylist = PozitiaPlaylistSelectat();
            if (pozitiePlaylist < 0)
            {
                MessageBox.Show("Selecteaza intai un playlist.");
                return;
            }

            int pozitieMelodie = PozitiaMelodieSelectata();
            if (pozitieMelodie < 0)
            {
                MessageBox.Show("Selecteaza intai o melodie din tabelul din dreapta.");
                return;
            }

            Playlist p = playlists[pozitiePlaylist];
            string titlu = p.Melodii[pozitieMelodie].Titlu;

            p.Melodii.RemoveAt(pozitieMelodie);
            ReincarcaTot(pozitiePlaylist);
            GolesteCampurileMelodie();
            lblStare.Text = "Stearsa " + titlu + " din " + p.Nume;
        }

        private void btnMuta_Click(object sender, EventArgs e)
        {
            int pozitieSursa = PozitiaPlaylistSelectat();
            if (pozitieSursa < 0)
            {
                MessageBox.Show("Selecteaza intai un playlist.");
                return;
            }

            int pozitieMelodie = PozitiaMelodieSelectata();
            if (pozitieMelodie < 0)
            {
                MessageBox.Show("Selecteaza intai melodia pe care o muti.");
                return;
            }

            if (cmbMuta.SelectedIndex < 0)
            {
                MessageBox.Show("Alege din lista playlistul in care muti melodia.");
                return;
            }

            Playlist sursa = playlists[pozitieSursa];
            Playlist destinatie = playlists[cmbMuta.SelectedIndex];

            if (sursa == destinatie)
            {
                MessageBox.Show("Melodia este deja in playlistul " + destinatie.Nume + ".");
                return;
            }

            Melodie m = sursa.Melodii[pozitieMelodie];

            if (ExistaMelodieInPlaylist(destinatie, m.Titlu, m.Artist, -1))
            {
                MessageBox.Show("Playlistul " + destinatie.Nume + " are deja melodia " +
                    m.Titlu + " de " + m.Artist + ".");
                return;
            }

            sursa.Melodii.RemoveAt(pozitieMelodie);
            destinatie.Melodii.Add(m);

            ReincarcaTot(pozitieSursa);
            GolesteCampurileMelodie();
            lblStare.Text = "Mutata " + m.Titlu + " din " + sursa.Nume +
                " in " + destinatie.Nume;
        }

        private void dgvPlaylists_SelectionChanged(object sender, EventArgs e)
        {
            if (seReincarca)
            {
                return;
            }

            int pozitie = PozitiaPlaylistSelectat();
            if (pozitie < 0)
            {
                return;
            }

            Playlist p = playlists[pozitie];
            txtNumeP.Text = p.Nume;
            txtGenP.Text = p.Gen;

            ReincarcaMelodii();
            GolesteCampurileMelodie();
        }

        private void dgvMelodii_SelectionChanged(object sender, EventArgs e)
        {
            if (seReincarca)
            {
                return;
            }

            int pozitiePlaylist = PozitiaPlaylistSelectat();
            int pozitieMelodie = PozitiaMelodieSelectata();
            if (pozitiePlaylist < 0 || pozitieMelodie < 0)
            {
                return;
            }

            Melodie m = playlists[pozitiePlaylist].Melodii[pozitieMelodie];
            txtTitluM.Text = m.Titlu;
            txtArtistM.Text = m.Artist;
            txtDurataM.Text = m.Durata;
        }

        private int PozitiaPlaylistSelectat()
        {
            if (dgvPlaylists.CurrentRow == null)
            {
                return -1;
            }

            int i = dgvPlaylists.CurrentRow.Index;
            if (i < 0 || i >= playlists.Count)
            {
                return -1;
            }

            return i;
        }

        private int PozitiaMelodieSelectata()
        {
            int pozitiePlaylist = PozitiaPlaylistSelectat();
            if (pozitiePlaylist < 0)
            {
                return -1;
            }

            if (dgvMelodii.CurrentRow == null)
            {
                return -1;
            }

            int i = dgvMelodii.CurrentRow.Index;
            if (i < 0 || i >= playlists[pozitiePlaylist].NrMelodii)
            {
                return -1;
            }

            return i;
        }

        private Playlist CitestePlaylistDinCampuri()
        {
            Playlist p = new Playlist();

            try
            {
                p.Nume = txtNumeP.Text;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
                txtNumeP.Focus();
                return null;
            }

            try
            {
                p.Gen = txtGenP.Text;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
                txtGenP.Focus();
                return null;
            }

            return p;
        }

        private Melodie CitesteMelodieDinCampuri()
        {
            int secunde;
            if (!Melodie.IncearcaCitesteDurata(txtDurataM.Text, out secunde))
            {
                MessageBox.Show("Durata se scrie in formatul minute:secunde, de exemplu 3:45.");
                txtDurataM.Focus();
                return null;
            }

            Melodie m = new Melodie();

            try
            {
                m.Titlu = txtTitluM.Text;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
                txtTitluM.Focus();
                return null;
            }

            try
            {
                m.Artist = txtArtistM.Text;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
                txtArtistM.Focus();
                return null;
            }

            try
            {
                m.DurataSecunde = secunde;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
                txtDurataM.Focus();
                return null;
            }

            return m;
        }

        private bool ExistaPlaylistCuNumele(string nume, int pozitieIgnorata)
        {
            for (int i = 0; i < playlists.Count; i++)
            {
                if (i == pozitieIgnorata)
                {
                    continue;
                }

                if (playlists[i].Nume.ToLower() == nume.ToLower())
                {
                    return true;
                }
            }

            return false;
        }

        private bool ExistaMelodieInPlaylist(Playlist p, string titlu, string artist,
            int pozitieIgnorata)
        {
            for (int i = 0; i < p.NrMelodii; i++)
            {
                if (i == pozitieIgnorata)
                {
                    continue;
                }

                Melodie m = p.Melodii[i];
                if (m.Titlu.ToLower() == titlu.ToLower() &&
                    m.Artist.ToLower() == artist.ToLower())
                {
                    return true;
                }
            }

            return false;
        }

        private int NumaraToateMelodiile()
        {
            int total = 0;
            foreach (Playlist p in playlists)
            {
                total = total + p.NrMelodii;
            }
            return total;
        }

        private void ReincarcaTot(int pozitieDeSelectat)
        {
            seReincarca = true;

            dgvPlaylists.DataSource = null;
            dgvPlaylists.DataSource = new List<Playlist>(playlists);
            dgvPlaylists.ClearSelection();

            if (pozitieDeSelectat >= 0 && pozitieDeSelectat < dgvPlaylists.Rows.Count)
            {
                dgvPlaylists.Rows[pozitieDeSelectat].Selected = true;
                dgvPlaylists.CurrentCell = dgvPlaylists.Rows[pozitieDeSelectat].Cells[0];
            }

            seReincarca = false;

            ReincarcaMelodii();
            ActualizeazaListaDeMutare();
        }

        private void ReincarcaMelodii()
        {
            seReincarca = true;

            int pozitie = PozitiaPlaylistSelectat();
            if (pozitie < 0)
            {
                dgvMelodii.DataSource = null;
            }
            else
            {
                dgvMelodii.DataSource = null;
                dgvMelodii.DataSource = new List<Melodie>(playlists[pozitie].Melodii);
            }

            dgvMelodii.ClearSelection();
            seReincarca = false;
        }

        private void SelecteazaMelodia(int pozitie)
        {
            if (pozitie < 0 || pozitie >= dgvMelodii.Rows.Count)
            {
                return;
            }

            seReincarca = true;
            dgvMelodii.Rows[pozitie].Selected = true;
            dgvMelodii.CurrentCell = dgvMelodii.Rows[pozitie].Cells[0];
            seReincarca = false;
        }

        private void ActualizeazaListaDeMutare()
        {
            cmbMuta.Items.Clear();
            foreach (Playlist p in playlists)
            {
                cmbMuta.Items.Add(p.Nume);
            }
        }

        private void GolesteCampurilePlaylist()
        {
            txtNumeP.Clear();
            txtGenP.Clear();
        }

        private void GolesteCampurileMelodie()
        {
            txtTitluM.Clear();
            txtArtistM.Clear();
            txtDurataM.Clear();
        }

        private List<Playlist> DateDeStart()
        {
            List<Playlist> lista = new List<Playlist>();

            Playlist rock = CreeazaPlaylist("Rock clasic", "Rock");
            rock.Melodii.Add(CreeazaMelodie("Stairway to Heaven", "Led Zeppelin", 482));
            rock.Melodii.Add(CreeazaMelodie("Bohemian Rhapsody", "Queen", 355));
            rock.Melodii.Add(CreeazaMelodie("Hotel California", "Eagles", 391));
            rock.Melodii.Add(CreeazaMelodie("Smoke on the Water", "Deep Purple", 340));
            lista.Add(rock);

            Playlist invatat = CreeazaPlaylist("Pentru invatat", "Instrumental");
            invatat.Melodii.Add(CreeazaMelodie("Clair de Lune", "Debussy", 300));
            invatat.Melodii.Add(CreeazaMelodie("Gymnopedie No. 1", "Erik Satie", 210));
            invatat.Melodii.Add(CreeazaMelodie("Nuvole Bianche", "Ludovico Einaudi", 350));
            lista.Add(invatat);

            Playlist alergat = CreeazaPlaylist("Alergat", "Electronic");
            alergat.Melodii.Add(CreeazaMelodie("Titanium", "David Guetta", 245));
            alergat.Melodii.Add(CreeazaMelodie("Levels", "Avicii", 200));
            lista.Add(alergat);

            Playlist gol = CreeazaPlaylist("Playlist gol", "Necunoscut");
            lista.Add(gol);

            return lista;
        }

        private Playlist CreeazaPlaylist(string nume, string gen)
        {
            Playlist p = new Playlist();
            p.Nume = nume;
            p.Gen = gen;
            return p;
        }

        private Melodie CreeazaMelodie(string titlu, string artist, int secunde)
        {
            Melodie m = new Melodie();
            m.Titlu = titlu;
            m.Artist = artist;
            m.DurataSecunde = secunde;
            return m;
        }
    }
}
