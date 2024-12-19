using System;
using gestionBanque.Controller;

namespace gestionBanque.entities
{
	public class CompteEpargne : Compte, ICompte<CompteEpargne>
	{
		private DateTime duree;

        public CompteEpargne(int id, int numeroCompte, float solde, DateTime duree) : base(numeroCompte, solde)
        {
            Id = id;
            Duree = duree;
        }

        public DateTime Duree { get => duree; set => duree = value; }
        public int Id { get => id; set => id = value; }

        public void afficherAllCompte()
        {
            foreach (var compte in comptes)
            {
                if (compte is CompteEpargne compteEpargne)
                {
                    afficherCompte(compteEpargne);
                }
            }
        }

        public void afficherCompte(CompteEpargne compteEpargne)
        {
            Console.WriteLine(compteEpargne);   
        }

        public void ajouterCompte(CompteEpargne compteEpargne)
        {
            compteEpargne.Id = conteurCompte++;
            comptes.Add(compteEpargne);
            Console.WriteLine("Compte ajouté : " + compteEpargne);
        }

        public Compte rechercheCompte(int id)
        {
            return comptes.OfType<CompteEpargne>().FirstOrDefault(c => c.Id == id);
        }

        public void supprimerCompte(int id)
        {
            var compteEpargne = rechercheCompte(id);
            if (compteEpargne != null)
            {
                comptes.Remove(compteEpargne);
                Console.WriteLine($"Compte Epargne ID {id} supprimée avec succes");
            }
            else
            {
                Console.WriteLine($"Aucun compte Epargne trouvé avec l'ID {id}");
            }
        }
    }
}

