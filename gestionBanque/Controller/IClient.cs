using System;
using gestionBanque.entities;

namespace gestionBanque.Controller
{
	public interface IClient
	{
		void ajouterClient(Client client);
		void afficherClient(Client client);
		void afficherAllClient();
		void supprimerClient(int id);
		Client rechercherClient(int id);
	}
}

