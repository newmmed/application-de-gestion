using System;
using System.Linq;

namespace GestiondeStock.Ressource // Correction de l'orthographe (ajout du 's')
{
    public class CLS_Produit // Changement de internal à public
    {
        private dbStockContext1 db = new dbStockContext1();
        private Produit PR;

        public bool Ajouter_Produit(string NomP, int quantite, int prix, byte[] imageP, int id_categorie)
        {
            PR = new Produit();
            PR.Nom_produit = NomP;
            PR.Quantité_produit = quantite;
            PR.Prix_produit = prix;
            PR.Image_produit = imageP; // J'ai ajouté cette ligne car vous utilisez imageP
            PR.ID_Categorie = id_categorie;

            if (db.Produits.SingleOrDefault(p => p.Nom_produit == NomP) == null)
            {
                db.Produits.Add(PR);
                db.SaveChanges();
                return true;
            }
            return false;
        }
        public bool Modifier_Produit(int id_produit, string NomP, int quantite, int prix, byte[] imageP, int id_categorie)
        {
            PR = db.Produits.SingleOrDefault(s => s.Id_produit == id_produit);
            if (PR != null)
            {
                PR.Nom_produit = NomP;
                PR.Quantité_produit = quantite;
                PR.Prix_produit = prix;
                PR.Image_produit = imageP;
                PR.ID_Categorie = id_categorie;

                db.SaveChanges();
                return true;
            }
            return false;
        }
    }
    }

    