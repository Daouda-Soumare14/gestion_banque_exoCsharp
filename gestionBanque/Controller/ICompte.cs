using System;
using gestionBanque.entities;

namespace gestionBanque.Controller
{
	public interface ICompte<T>
	{
		void ajouterCompte(T t);
		void afficherCompte(T t);
		void afficherAllCompte();
		void supprimerCompte(int id);
        Compte rechercheCompte(int id);
    }
}

