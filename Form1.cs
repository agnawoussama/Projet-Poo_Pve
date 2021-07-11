using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_Poo_Pve
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Sauvegarder_Click(object sender, EventArgs e)
        {
            ListeTache.Sauvegarder();
        }

        private void btn_Ajouter_Click(object sender, EventArgs e)
        {
            Projet p1 = new Projet(1, "Excel", new DateTime(2020, 11, 11), new DateTime(2021, 02, 12));

            Developeur d1 = new Developeur("zd5415", "Web", "Ahmed", "Kamal");
            //Programmeur pr1 = new Programmeur(d1.Cin, d1.Genre, d1.Nom, d1.Prenom, "JS", "Junior");
            
            Tache t1 = new Tache(10, p1, new DateTime(2020, 11, 11), new DateTime(2021, 02, 12), d1, "A dev1");
            if (MessageBox.Show("Voulez vous vraiment ajouter ce Tache? ", "Ajout", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ListeTache.Ajouter(t1);
                string[] row = { "10", p1.Nom, (new DateTime(2020, 11, 11).ToString()), (new DateTime(2021, 02, 12)).ToString(), d1.Nom, "A dev1" };
                dataGridView1.Rows.Add(row);
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 6;
            dataGridView1.Columns[0].Name = "Num Tache";
            dataGridView1.Columns[1].Name = "Projet";
            dataGridView1.Columns[2].Name = "Date debut";
            dataGridView1.Columns[3].Name = "Date Fin";
            dataGridView1.Columns[4].Name = "Developpeur";
            dataGridView1.Columns[5].Name = "Fonction";

            Projet p1 = new Projet(1, "Excel", new DateTime(2020, 11, 11), new DateTime(2021, 02, 12));

            Developeur d1 = new Developeur("zd5415", "Web", "Ahmed", "Kamal");
            Tache t2 = new Tache(11, p1, new DateTime(2020, 12, 12), new DateTime(2021, 01, 11), d1, "A dev2");
            Tache t3 = new Tache(12, p1, new DateTime(2020, 10, 10), new DateTime(2021, 10, 10), d1, "A dev3");
            ListeTache.Ajouter(t2);
            ListeTache.Ajouter(t3);
        }

        private void btn_Supprimer_Click(object sender, EventArgs e)
        {
            Tache Recherche(int numTache)
            {
                foreach (Tache t in ListeTache.listDesTaches)
                {
                    if (t.NumTache == numTache) return t;                                     
                }
                return null;
            }

            if (Recherche(int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString())) != null)
            {
                ListeTache.Supprimer(Recherche(int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString())));             
            }
            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
        }

        private void btn_Afficher_Click(object sender, EventArgs e)
        {
            foreach (Tache t in ListeTache.listDesTaches)
            {
                string[] row = { t.NumTache.ToString(), t.Projet.Nom, t.DateDebut.ToString(), t.DateFin.ToString(),t.Dev.Nom, t.Fonction };
                dataGridView1.Rows.Add(row);
            }
            
            
        }

        private void btn_total_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Il y'a {Tache.cpt} taches");
        }
    }
}
