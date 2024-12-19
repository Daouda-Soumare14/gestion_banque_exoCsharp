using gestionBanque.Controller;

namespace gestionBanque.entities
{
    public class Client : IClient
    {

        private static int conteurClient = 0;
        private int id;
        private string nom;
        private string prenom;
        private int tel;

        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public int Tel { get => tel; set => tel = value; }

        public Client(string nom, string prenom, int tel)
        {
            Id = conteurClient++;
            Nom = nom;
            Prenom = prenom;
            Tel = tel;
        }

        public override string? ToString()
        {
            return base.ToString() + "";
        }

        List<Client> clients = new List<Client>();


        public void ajouterClient(Client client)
        {
            client.id = conteurClient++;
            clients.Add(client);
            Console.WriteLine("Clienht ajouté : " + client);
        }

        public void afficherClient(Client client)
        {
            Console.WriteLine(client);
        }

        public void afficherAllClient()
        {
            clients.ForEach(afficherClient);
        }

        public Client rechercherClient(int id)
        {
            return clients.FirstOrDefault(c => c.Id == id);
        }

        public void supprimerClient(int id)
        {
            var client = rechercherClient(id);

            if (client != null)
            {
                clients.Remove(client);
                Console.WriteLine($"Client ID {id} supprimée avec succes");
            }
            else
            {
                Console.WriteLine($"Aucun client trouvée avec l'ID {id}.");
            } 
        }
    }
}

