using System;

namespace dev0200001
{

    public class Personne
    {
        #region Attributs
        public static List<Personne> CollClass = new List<Personne>();
        private string _nom;
        private string _prenom;
        private int _age;
        #endregion
        #region constructeurs
        
        //constructeur par defaut
        public  Personne()
            {
            _nom = "-";
            _prenom = "-";
            _age = 0;
            Personne.CollClass.Add(this);

        }
        public Personne(string nom, string prenom)
        {
            _nom = nom;
            _prenom = prenom;
            _age = 0;
            Personne.CollClass.Add(this);
        }
        public Personne(string nom, string prenom, int age)
        {
            _nom = nom;
            _prenom = prenom;
            _age = age;
            Personne.CollClass.Add(this);
        }


        #endregion
        #region getters/setters
        public string GetNom()
        { 
            return _nom; 
        }
        public void SetNom(string nom)
        {
            _nom = nom;
        }
        public string GetPrenom()
        {
            return _prenom;
        }
        public void SetPrenom(string prenom)
        {
            _prenom = prenom;
        }
        public int GetAge()
        {
            return _age;
        }
        public void SetAge(int age)
        {
          _age = age;
        }
        #endregion
        #region methodes
        public string GetMaVie()
        {
            return $"mon nom est {this.GetNom()}, mon prenom est {this.GetPrenom()} et j'ai {this.GetAge()} ans.";

        }
        #endregion

    }
    class Program
    {
        // Point d'entrée principal du programme.
        static void Main(string[] args)
        {
          new Personne();
          new Personne("riri","fifi");
          new Personne("loulou", "picsou", 12);

          Personne.GetMe("riri");

            //////////////

            foreach (Personne UnePersonne in Personne.CollClass)
            {
                if (UnePersonne.GetNom() == "riri")
                {
                    Console.WriteLine(UnePersonne.GetMaVie());

                }

            }

            ///////////////



        }

        

        // TODO: Ajoutez d'autres méthodes ou classes si nécessaire.
    }
}