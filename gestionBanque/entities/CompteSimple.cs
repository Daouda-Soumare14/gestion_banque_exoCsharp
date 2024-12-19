using System;
using System.Collections.Generic;
using gestionBanque.Controller;

namespace gestionBanque.entities
{
    public class CompteSimple : Compte, ICompte<CompteSimple>
    {
        private float taux;

        public CompteSimple(int numeroCompte, float solde, float taux) : base(conteurCompte++, numeroCompte, solde)
        {
            Taux = taux;
        }

        public float Taux { get => taux; set => taux = value; }

        
        public void ajouterCompte(CompteSimple compteSimple)
        {
            compteSimple.Id = conteurCompte++;
            comptes.Add(compteSimple);
            Console.WriteLine("Compte ajouté : " + compteSimple);
        }


        public void afficherCompte(CompteSimple compteSimple)
        {
            Console.WriteLine(compteSimple);
        }


        public void afficherAllCompte()
        {
            foreach (var compte in comptes)
            {
                if (compte is CompteSimple compteSimple)
                {
                    afficherCompte(compteSimple);
                }
            }
        }

        
        public Compte rechercheCompte(int id)
        {
            var compte = comptes.OfType<CompteSimple>().FirstOrDefault(c => c.Id == id);
            return compte ?? throw new Exception("Compte introuvable");
        }

        
        public void supprimerCompte(int id)
        {
            var compteSimple = rechercheCompte(id);
            if (compteSimple != null)
            {
                comptes.Remove(compteSimple);
                Console.WriteLine($"Compte simple avec ID {id} supprimé avec succes.");
            }
            else
            {
                Console.WriteLine($"Aucun compte simple trouvé avec l'ID {id}.");
            }
        }
    }
}
