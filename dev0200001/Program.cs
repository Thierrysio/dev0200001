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

        /// <summary>
        /// Méthode pour obtenir une instance de la classe Personne à partir d'un nom donné.
        /// </summary>
        /// <param name="param">Le nom de la personne à rechercher.</param>
        /// <returns>Retourne une instance de la classe Personne si elle est trouvée, sinon retourne null.</returns>
        public static Personne GetMe(string param)
        {
            // Parcourez chaque instance de Personne dans la collection static CollClass de la classe Personne.
            foreach (Personne UnePersonne in Personne.CollClass)
            {
                // Vérifiez si le nom de l'instance actuelle de Personne correspond au paramètre 'param'.
                if (UnePersonne.GetNom() == param)
                {
                    // Si c'est le cas, affichez une information associée à cette personne (probablement une description ou une biographie).
                    Console.WriteLine(UnePersonne.GetMaVie());

                    // Retournez l'instance actuelle de Personne.
                    return UnePersonne;
                }
            }

            // Si aucune instance de Personne avec le nom donné n'a été trouvée, retournez null.
            return null;
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

          Personne P = Personne.GetMe("riri");



        }

        

        // TODO: Ajoutez d'autres méthodes ou classes si nécessaire.
    }
}