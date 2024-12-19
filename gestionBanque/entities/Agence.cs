using System;
using gestionBanque.Controller;

namespace gestionBanque.entities
{
    public class Agence : IAgence
    {
        
        private int conteurAgence = 1;
        private int id;
        private int idClient;
        private string code;

        

        public Agence(int id, int idClient, string code)
        {
            Id = id;
            IdClient = idClient;
            Code = code;
        }

        public int Id { get => id; set => id = value; }
        public string Code { get => code; set => code = value; }
        public int IdClient { get => idClient; set => idClient = value; }

        List<Agence> agences = new List<Agence>();

        public void ajouterAgence(Agence agence)
        {
            agence.Id = conteurAgence++;
            agences.Add(agence);
            Console.WriteLine("Agence ajouté : " + agence);
        }


        public override string ToString()
        {
            return $"Agence [ID: {Id}, ID Client: {IdClient}, Code: {Code}]";
        }


        public void afficherAgence(Agence agence)
        {
             Console.WriteLine(agence);
            
        }

        public void afficherAllAgence()
        {
            agences.ForEach(afficherAgence);
        }


        public Agence rechercherAgence(int id)
        {
            return agences.FirstOrDefault(a => a.Id == id);
        }

        public void supprimerAgence(int id)
        {
            var agence = rechercherAgence(id);
            if (agence != null)
            {
                agences.Remove(agence);
                Console.WriteLine($"Agence ID {id} supprimée avec succes.");
            }
            else
            {
                Console.WriteLine($"Aucune agence trouvée avec l'ID {id}.");
            }
        }   
    }
}