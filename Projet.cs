using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Poo_Pve
{
    public class Projet
    {
        //attributs
        int numero;
        string nom;
        DateTime dateDebut;
        DateTime dateFin;
        public Projet()
        {

        }
        public Projet(int numero, string nom, DateTime dateDebut, DateTime dateFin)
        {
            this.numero = numero;
            this.nom = nom;
            this.dateDebut = dateDebut;
            this.dateFin = dateFin;
        }

        //Proprietes
        public int Numero { get { return numero; } set { numero = value; } }
        public string Nom { get { return nom; } set { nom = value; } }
        public DateTime DateDebut { get { return dateDebut; } set { dateDebut = value; } }
        public DateTime DateFin { get { return dateFin; } set { dateFin = value; } }


    }
}
