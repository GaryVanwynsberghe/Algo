using Algo.Dossier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo
{
    class Program
    {


        static void Main(string[] args)
        {
            Menu menu = new Menu();
            menu.InsererLigne(new MenuItem { Numero = 1, Libelle = "Voyages" });
            menu.InsererLigne(new MenuItem { Numero = 2, Libelle = "Clients" });
            menu.InsererLigne(new MenuItem { Numero = 3, Libelle = "Dossiers" });

            menu.AfficherMenu();

            int resultat = menu.Choisir();

            switch (resultat.ToString())
            {
                case "1":
                    SousMenuVoyage();
                    break;

                case "2":
                    SousMenuClients();                   
                    break;

                case "3":
                    SousMenuDossiers();
                    break;
                    
            }

            Console.WriteLine(resultat);
            Console.ReadLine();


        }

        private static void SousMenuVoyage()
        {
            Menu sousMenu = new Menu();
            sousMenu.InsererLigne(new MenuItem { Numero = 1, Libelle = "Destinations" });
            sousMenu.InsererLigne(new MenuItem { Numero = 2, Libelle = "Conpagnies" });

            sousMenu.AfficherMenu();
            int resultatSousMenu = sousMenu.Choisir();
            switch (resultatSousMenu)
            {
                case 1:
                    Console.WriteLine("Vous souhaitez : Voyages => Destination");
                    break;

                case 2:
                    Console.WriteLine("vous souhaitez : Voyages => Compagnies");
                    break;
            }
        }

        private static void SousMenuClients()
        {
            Menu sousMenu = new Menu();
            sousMenu.InsererLigne(new MenuItem { Numero = 1, Libelle = "Créer" });
            sousMenu.InsererLigne(new MenuItem { Numero = 2, Libelle = "Rechercher clients" });
            sousMenu.InsererLigne(new MenuItem { Numero = 3, Libelle = "Supprimer clients" });

            sousMenu.AfficherMenu();
            int resultatSousMenu = sousMenu.Choisir();
            switch (resultatSousMenu)
            {
                case 1:
                    Console.WriteLine("Vous souhaitez : Clients => Créer");
                    break;

                case 2:
                    Console.WriteLine("vous souhaitez : Clients => Rechercher clients");
                    break;

                case 3:
                    Console.WriteLine("vous souhaitez : Clients => Supprimer clients");
                    break;
            }
        }

        private static void SousMenuDossiers()
            {
                Menu sousMenu = new Menu();
                sousMenu.InsererLigne(new MenuItem { Numero = 1, Libelle = "Créer un dossier" });
                sousMenu.InsererLigne(new MenuItem { Numero = 2, Libelle = "Rechercher un dossier" });
                sousMenu.InsererLigne(new MenuItem { Numero = 3, Libelle = "Supprimer un dossier" });

                sousMenu.AfficherMenu();
                int resultatSousMenu = sousMenu.Choisir();
                switch (resultatSousMenu)
                {
                    case 1:
                        Console.WriteLine("Vous souhaitez : Dossier => Créer un dossier");
                        break;

                    case 2:
                        Console.WriteLine("vous souhaitez : Dossier => Rechercher un dossier");
                        break;

                    case 3:
                        Console.WriteLine("vous souhaitez : Dossier => Supprimer un dossier");
                        break;
                }
            }


        }
    }

    







