using System;
using gestionBanque.entities;

namespace gestionBanque.Controller
{
	public interface IAgence
	{
        void ajouterAgence(Agence agence);
        void afficherAgence(Agence agence);
        void afficherAllAgence();
        void supprimerAgence(int id);
        Agence rechercherAgence(int id);
    }
}

