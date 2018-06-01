using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo.Dossier
{
    class Menu
    {
        private List<MenuItem> menuItems;

        public Menu()
        {
            menuItems = new List<MenuItem>();
        }

        /// <summary>
        /// Affiche les éléments de menu
        /// </summary>
        public void AfficherMenu()
        {                                               
            foreach (MenuItem ligne in menuItems)
            {
                Console.WriteLine($"{ligne.Numero}-{ligne.Libelle}");
            }

        }

        /// <summary>
        /// Test et récupère la saisie de l'utilisateur
        /// </summary>
        /// <param name="menu">La liste des choix possible</param>
        /// <returns>Le choix de l'utilisateur</returns>
    public int Choisir()
        {
            Console.WriteLine();
            Console.WriteLine("Saisir un choix : ");
            int choix;
            choix = int.Parse(Console.ReadLine());

            //Test du choix par rapport aux éléments du menu
            while (true)
            {
                foreach (MenuItem item in menuItems)
                {
                    if (choix == item.Numero)
                    {
                        return choix;
                    }
                }
                Console.WriteLine("Erreur, saisir un choix : ");
                choix = int.Parse(Console.ReadLine());
            }
            //return -1;

            //return menu.SingleOrDefault(x => x.Numero == choix) != null ? choix : -1;                    

        }        

        /// <summary>
        /// Insère un MenuItem dans le menu.
        /// </summary>
        /// <param name="item">Elément à insèrer dans le menu</param>
        /// <exception cref="ArgumentException">Si le numéro de l'item est déjà</exception>
    public void InsererLigne(MenuItem item)
        {
            foreach (MenuItem ligne in menuItems)
            {
                if (ligne.Numero == item.Numero)
                { 
                    throw new ArgumentException($"Le numéro {item.Numero} existe déjà dans le menu");
                    
                }
            }
            /*if (menuItems.Exists(x=> x.Numero ==item.Numero))
            {
                throw new ArgumentException($"Le numéro {item.Numero} existe déjà dans le menu");
            }*/
            menuItems.Add(item);
        }
    }
                 
}

