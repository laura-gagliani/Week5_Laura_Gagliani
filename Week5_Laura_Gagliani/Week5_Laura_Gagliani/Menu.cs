using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week5_Laura_Gagliani.Entita;

namespace Week5_Laura_Gagliani
{
    class Menu
    {
        internal static void Start()
        {
            GestioneCarriera.CaricaDati();

            bool quit = false;
            do
            {
                Console.WriteLine("\n--------------- MENU GESTIONE CARRIERA ---------------");
                Console.WriteLine("[1] Prenotazione esami");
                Console.WriteLine("[2] Verbalizzazione esami");

                Console.WriteLine("\n[x] Esci");

                char choice;
                do
                {
                    Console.WriteLine("\nSeleziona dal menu:");
                    choice = Console.ReadKey().KeyChar;
                } while (!(choice == '1' || choice == '2' || choice == 'x'));



                switch (choice)
                {
                    case '1':
                        PrenotaEsame();
                        break;
                    case '2':
                        VerbalizzaEsame();
                        break;

                    case 'x':
                        quit = true;
                        Console.WriteLine("\nChiusura in corso...");
                        break;
                }
            } while (!quit);
        }

        private static void VerbalizzaEsame()
        {

            int matricola = InserisciMatricola();
            Studente studente = GestioneCarriera.GetStudenteByMatricola(matricola);
            int count = 0;
            string verbalizzato = "";
            Console.WriteLine("\nVerbalizzato - Codice - Nome");
            Console.WriteLine("------------------------------------------------");
            foreach (var item in studente.EsamiStudente)
            {
                if (item.Value)
                {
                    verbalizzato = "Sì";
                }
                else if (!item.Value)
                {
                    verbalizzato = "No";
                    count++;
                }
                Console.WriteLine($"\t{verbalizzato}\t{item.Key.Id}\t{item.Key.Nome} ");
            }

            if (count == 0)
            {
                Console.WriteLine("\nTutti i tuoi esami sono correttamente verbalizzati!");
            }

            else
            {
                Corso esame = SelezionaEsamePerVerbalizzazione(studente);
                GestioneCarriera.Verbalizza(esame, studente);
                Console.WriteLine("Il tuo esame è stato verbalizzato con successo!");
            }

            //if (sottolista.Count = 0)
            //{

            //}
            //seleziono:
            //mettigli true
            // ricalcola cfu
            // ricalcola richiesta laurea
        }

        

        private static void PrenotaEsame()
        {
            int matricola = InserisciMatricola();
            Studente studente = GestioneCarriera.GetStudenteByMatricola(matricola);
            Corso esame = SelezionaEsame(studente);
            List<string> motivi = new List<string>();
            bool requisiti = GestioneCarriera.ControllaRequisiti(studente, esame, motivi);


            if (requisiti)
            {
                Console.WriteLine("\nHai tutti i requisiti per prenotarti a questo esame");
                GestioneCarriera.AggiungiEsameAStudente(studente, esame);
                Console.WriteLine("\nL'esame è stato prenotato con successo");
            }

            else
            {
                Console.WriteLine("\nErrore:");
                foreach (var item in motivi)
                {
                    Console.WriteLine(item);
                }
                
            }
        }
        private static Corso SelezionaEsamePerVerbalizzazione(Studente studente)
        {
            int codiceEsame;
            bool isInt;
            bool isCorrect;
            Corso esame;
            do
            {
                Console.WriteLine("\nDigita il codice dell'esame che vuoi verbalizzare:");
                isInt = int.TryParse(Console.ReadLine(), out codiceEsame);
            } while (!isInt);

            isCorrect = GestioneCarriera.ControllaSceltaVerbalizzazione(codiceEsame, studente, out esame);

            if (!isCorrect)
            {
                do
                {
                    Console.WriteLine("\nErrore! Esame selezionato non corretto");
                    do
                    {
                        Console.WriteLine("\nInserisci un nuovo codice:");
                        isInt = int.TryParse(Console.ReadLine(), out codiceEsame);
                    } while (!isInt);
                    isCorrect = GestioneCarriera.ControllaSceltaVerbalizzazione(codiceEsame, studente, out esame);
                } while (!isCorrect);

            }

            Console.WriteLine("\nInserimento corretto!");
            return esame;
        }
        private static Corso SelezionaEsame(Studente studente)
        {
            Console.WriteLine("\nGli esami del tuo corso di laurea sono:");
            GestioneCarriera.StampaCorsiPerCdL(studente);
            int codiceEsame;
            bool isInt;
            bool isInElenco;
            Corso esame;
            do
            {
                Console.WriteLine("\nDigita il codice dell'esame a cui ti vuoi prenotare:");
                isInt = int.TryParse(Console.ReadLine(), out codiceEsame);
            } while (!isInt);

            isInElenco = GestioneCarriera.ControllaEsame(codiceEsame, studente, out esame);

            if (!isInElenco)
            {
                do
                {
                    Console.WriteLine("\nErrore! Corso non in elenco");
                    do
                    {
                        Console.WriteLine("\nInserisci un codice corretto:");
                        isInt = int.TryParse(Console.ReadLine(), out codiceEsame);
                    } while (!isInt);
                    isInElenco = GestioneCarriera.ControllaEsame(codiceEsame, studente, out esame);
                } while (!isInElenco);

            }

            Console.WriteLine("\nInserimento corretto!");
            return esame;
        } //seleziona l'esame da prenotare

        private static int InserisciMatricola() //chiede input e controlla che sia in elenco
        {
            int matricola;
            bool isInt;
            bool isIscritto;

            do
            {
                Console.WriteLine("\nInserisci il tuo numero di matricola:");
                isInt = int.TryParse(Console.ReadLine(), out matricola);
            } while (!isInt);

            isIscritto = GestioneCarriera.ControllaIscrizione(matricola);

            if (!isIscritto)
            {
                do
                {
                    Console.WriteLine("\nErrore! Matricola non in elenco");
                    do
                    {
                        Console.WriteLine("\nInserisci il tuo numero di matricola:");
                        isInt = int.TryParse(Console.ReadLine(), out matricola);
                    } while (!isInt);
                    isIscritto = GestioneCarriera.ControllaIscrizione(matricola);
                } while (!isIscritto);


            }

            Console.WriteLine("\nNumero di matricola riconosciuto!");
            return matricola;

        }
    }
}
