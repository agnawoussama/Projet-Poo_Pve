using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace Projet_Poo_Pve
{
    class ListeTache
    {
        //liste des taches
        public static List<Tache> listDesTaches = new List<Tache>();

        public static void Ajouter(Tache t)
        {
            //if (MessageBox.Show("Voulez vous vraiment ajouter ce Tache? ", "Ajout", MessageBoxButtons.YesNo) == DialogResult.OK)
                listDesTaches.Add(t);
            
        }

        public static void Supprimer(Tache t)
        {
            if (MessageBox.Show("Voulez vous vraiment supprimer ce Tache? ", "Suppression", MessageBoxButtons.YesNo) == DialogResult.OK)
                listDesTaches.Remove(t);
        }

        public static string Lister()
        {
            string taches = "";
            foreach (Tache t in listDesTaches)
            {
                taches += t.ToString();
            }
            return taches;
        }

        public static void RechercherTachesDate(DateTime dateDebut, DateTime dateFin)
        {           
            foreach (Tache t in listDesTaches)
            {
                if (t.DateDebut >= dateDebut && t.DateFin <= dateFin)
                {
                    t.ToString();
                }
            }
        }

        public static void Sauvegarder()
        {
            FileStream fs = new FileStream("ListeTaches.xml", FileMode.Create, FileAccess.Write);
            XmlSerializer xs = new XmlSerializer(typeof(List<Tache>));
            xs.Serialize(fs, listDesTaches);
            fs.Close();
        }

    }
}
