using System;
namespace gestionBanque.entities
{
	public abstract class Compte
	{
		protected static int conteurCompte;
        protected int id;
        protected int numeroCompte;
        protected float solde;

        protected Compte(int id, int numeroCompte, float solde)
        {
            Id = id;
            NumeroCompte = numeroCompte;
            Solde = solde;
        }


        protected int Id { get => id; set => id = value; }
        protected int NumeroCompte { get => numeroCompte; set => numeroCompte = value; }
        protected float Solde { get => solde; set => solde = value; }
        protected Client? Client { get; set; }

        protected static List<Compte> comptes = new List<Compte>();

        protected string GenerateMatricule()
        {
            return $"000{Client.Id}{Client.Tel}";
        }


    }
}

