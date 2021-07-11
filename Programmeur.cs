using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Poo_Pve
{
    class Programmeur : Developeur
    {
        //attributs
        string language;
        string poste;

        public Programmeur(string cin, string genre, string nom, string prenom,string language, string poste)
            :base(cin, genre, nom, prenom)
        {
            this.language = language;
            this.poste = poste;
            
        }

        //Proprietes
        public string Language { get { return language; } set { language = value; } }
        public string Poste { get { return poste; } set { poste = value; } }

        //Equals si deux programmeurs ont le meme poste
        public override bool Equals(object obj)
        {
            Programmeur p = obj as Programmeur;
            return this.Poste == p.Poste;
        }


    }
}
