using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Poo_Pve
{
    [Serializable]
    public class Tache
    {
        //attributs
        int numTache;
        Projet projet;
        DateTime dateDebut;
        DateTime dateFin;
        Developeur dev;
        string fonction;

        public static int cpt = 0;
        public Tache()
        {
            cpt++;
        }
        public Tache(int numTache, Projet projet, DateTime dateDebut, DateTime dateFin, Developeur dev, string fonction)
        {
            cpt++;
            this.numTache = numTache;
            this.projet = projet;
            this.dateDebut = dateDebut;
            this.dateFin = dateFin;
            this.dev = dev;
            this.fonction = fonction;
        }

        //Proprietes
        public int NumTache { get { return numTache; } set { numTache = value; } }
        public Projet Projet { get { return projet; } set { projet = value; } }
        public DateTime DateDebut { get { return dateDebut; } set { dateDebut = value; } }
        public DateTime DateFin { get { return dateFin; } set { dateFin = value; } }
        public Developeur Dev { get { return dev; } set { dev = value; } }
        public string Fonction { get { return fonction; } set { fonction = value; } }

        //ToString
        public override string ToString()
        {
            return $"Numero de tache: {numTache}\nProjet: {projet}\nDate de Debut: {dateDebut}\nDate de Fin: {dateFin}\nDeveloppeur: {dev.Nom}\nFonction: {fonction}\n";
        }
    }
}
