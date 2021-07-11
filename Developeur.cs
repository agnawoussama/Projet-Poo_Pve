using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Projet_Poo_Pve
{
    public class Developeur
    {
        //attributs
        string cin;
        string genre;
        string nom;
        string prenom;
        public Developeur()
        {

        }
        public Developeur(string cin, string genre, string nom, string prenom)
        {
            this.cin = cin;
            this.genre = genre;
            this.nom = nom;
            this.prenom = prenom;
        }

        //Proprietes
        public string Cin { get { return cin; } set { cin = value; } }
        public string Genre { get { return genre; } 
            set 
            {
                string mr, mme, melle;
                mr = @"^Mr$"; mme = @"^Mme$"; melle = @"^Melle$";
                Match m1 = Regex.Match(value, mr);
                Match m2 = Regex.Match(value, mme);
                Match m3 = Regex.Match(value, melle);
                if (m1.Success || m2.Success || m3.Success)
                    genre = value;
                else throw new Exception("No");
            }
        }
        public string Nom { get { return nom; } set { nom = value; } }
        public string Prenom { get { return prenom; } set { prenom = value; } }


    }
}
