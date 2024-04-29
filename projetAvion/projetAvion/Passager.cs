namespace projetAvion
{/// <summary>
/// Cette classe contient les informations d'un passager 
/// </summary>
    public class Passager
    {
        // Attributs
        private string nom;
        private string prenom;
        private int noSiege;
        private DateTime dateNaissance;

        // Propriétés
        public string Nom
        {
            get { return nom; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    nom = value;
                else
                    throw new ArgumentException("Le nom du passager ne peut pas être vide.");
            }
        }

        public string Prenom
        {
            get { return prenom; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    prenom = value;
                else
                    throw new ArgumentException("Le prénom du passager ne peut pas être vide.");
            }
        }

        public int NoSiege
        {
            get { return noSiege; }
            set
            {
                if (value > 0)
                    noSiege = value;
                else
                    throw new ArgumentException("Le numéro de siège du passager doit être supérieur à zéro.");
            }
        }

        public DateTime DateNaissance
        {
            get { return dateNaissance; }
            set
            {
                if (value < DateTime.Now)
                    dateNaissance = value;
                else
                    throw new ArgumentException("La date de naissance du passager doit être antérieure à la date actuelle.");
            }
        }

        // Constructeur
        public Passager(string nom, string prenom, int noSiege, DateTime dateNaissance)
        {
            Nom = nom;
            Prenom = prenom;
            NoSiege = noSiege;
            DateNaissance = dateNaissance;
        }

        // Méthode pour afficher les informations du passager
        public void AfficherInfosPassager()
        {
            Console.WriteLine($"Nom: {nom}");
            Console.WriteLine($"Prénom: {prenom}");
            Console.WriteLine($"Numéro de siège: {noSiege}");
            Console.WriteLine($"Date de naissance: {dateNaissance.ToShortDateString()}");
        }



    }
}