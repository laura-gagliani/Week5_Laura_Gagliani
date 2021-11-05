using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week5_Laura_Gagliani.Entita;

namespace Week5_Laura_Gagliani
{
    public static class GestioneCarriera
    {
        public static List<Studente> studentiIscritti = new List<Studente>();  // generica lista di iscritti all'università

        internal static void CaricaDati()
        {
            // creazione dei cdl
            CdL cdlMatematica = new CdL { Codice = "LM-40", Nome = "Matematica", AnniDurata = 5, TotaleCFU = 300 };
            CdL cdlStoria = new CdL { Codice = "L-42", Nome = "Storia", AnniDurata = 3, TotaleCFU = 180 };
            CdL cdlMedicina = new CdL { Codice = "LM-41", Nome = "Medicina", AnniDurata = 6, TotaleCFU = 360 };

            // studenti (immatr. e iscrizione a relativi corsi)
            Studente sSto = new Studente { Matricola = 1, Nome = "Cosimo", Cognome = "Bianchini", AnnoNascita = 1999,/* RichiestaLaurea = true, CFUAccumulati = 180,*/ CodiceCdL = "L-42", CdL = cdlStoria};
            Studente sMat = new Studente { Matricola = 2, Nome = "Sara", Cognome = "Giannini", AnnoNascita = 1993, /*RichiestaLaurea = false, CFUAccumulati = 240,*/ CodiceCdL = "LM-40", CdL = cdlMatematica};
            Studente sMed = new Studente { Matricola = 3, Nome = "Caterina", Cognome = "Cipriani", AnnoNascita = 2001, /*RichiestaLaurea = false, CFUAccumulati = 120,*/ CodiceCdL = "LM-41" , CdL = cdlMedicina};

            cdlMatematica.StudentiIscritti.Add(sMat);
            cdlStoria.StudentiIscritti.Add(sSto);
            cdlMedicina.StudentiIscritti.Add(sMed); // a questo punto ogni stud ha il suo corso (fk e nav property), gli mancano gli esami in carriera

            studentiIscritti.Add(sMat);
            studentiIscritti.Add(sMed);
            studentiIscritti.Add(sSto); 

            //creazione e assegnazione corsi ai vari corsi di laurea
            Corso cMat1 = new Corso { Id = 4001, Nome = "Algebra lineare", CFU = 60, CodiceCdL = "LM-40", CdL = cdlMatematica };
            Corso cMat2 = new Corso { Id = 4002, Nome = "Analisi I e II", CFU = 120, CodiceCdL = "LM-40", CdL = cdlMatematica };
            Corso cMat3 = new Corso { Id = 4003, Nome = "Statistica", CFU = 60, CodiceCdL = "LM-40", CdL = cdlMatematica };
            Corso cMat4 = new Corso { Id = 4004, Nome = "Modelli geometrici", CFU = 60, CodiceCdL = "LM-40", CdL = cdlMatematica };
            Corso cMat5 = new Corso { Id = 4005, Nome = "Storia della matematica", CFU = 60, CodiceCdL = "LM-40", CdL = cdlMatematica };

            cdlMatematica.CorsiAssociati.Add(cMat1);
            cdlMatematica.CorsiAssociati.Add(cMat2);
            cdlMatematica.CorsiAssociati.Add(cMat3);
            cdlMatematica.CorsiAssociati.Add(cMat4);
            cdlMatematica.CorsiAssociati.Add(cMat5);

            Corso cSto1 = new Corso { Id = 4201, Nome = "Storia medievale", CFU = 60, CodiceCdL = "L-42", CdL = cdlStoria };
            Corso cSto2 = new Corso { Id = 4202, Nome = "Storia delle religioni", CFU = 60, CodiceCdL = "L-42", CdL = cdlStoria };
            Corso cSto3 = new Corso { Id = 4203, Nome = "Storia contemporanea", CFU = 60, CodiceCdL = "L-42", CdL = cdlStoria };
            Corso cSto4 = new Corso { Id = 4204, Nome = "Storia delle filosofie orientali", CFU = 60, CodiceCdL = "L-42", CdL = cdlStoria };

            cdlStoria.CorsiAssociati.Add(cSto1);
            cdlStoria.CorsiAssociati.Add(cSto2);
            cdlStoria.CorsiAssociati.Add(cSto3);
            cdlStoria.CorsiAssociati.Add(cSto4);

            Corso cMed1 = new Corso { Id = 4101, Nome = "Anatomia", CFU = 120, CodiceCdL = "LM-41" , CdL = cdlMedicina };
            Corso cMed2 = new Corso { Id = 4102, Nome = "Citologia", CFU = 60, CodiceCdL = "LM-41", CdL = cdlMedicina };
            Corso cMed3 = new Corso { Id = 4103, Nome = "Diagnostica per immagini", CFU = 60, CodiceCdL = "LM-41", CdL = cdlMedicina };
            Corso cMed4 = new Corso { Id = 4104, Nome = "Patologia generale", CFU = 60, CodiceCdL = "LM-41", CdL = cdlMedicina };
            Corso cMed5 = new Corso { Id = 4105, Nome = "Clinica chirurgica", CFU = 60, CodiceCdL = "LM-41", CdL = cdlMedicina };
            Corso cMed6 = new Corso { Id = 4106, Nome = "Malattie infettive", CFU = 60, CodiceCdL = "LM-41", CdL = cdlMedicina };

            cdlMedicina.CorsiAssociati.Add(cMed1);
            cdlMedicina.CorsiAssociati.Add(cMed2);
            cdlMedicina.CorsiAssociati.Add(cMed3);
            cdlMedicina.CorsiAssociati.Add(cMed4);
            cdlMedicina.CorsiAssociati.Add(cMed5);
            cdlMedicina.CorsiAssociati.Add(cMed6);


            // dati carriere studenti

            sSto.EsamiStudente.Add(cSto1, true);
            sSto.EsamiStudente.Add(cSto2, true); 
            sSto.CFUAccumulati = CalcolaCFUaccumulati(sSto);
            sSto.RichiestaLaurea = ValutaRichiestaLaurea(sSto);

            sMat.EsamiStudente.Add(cMat1, true);
            sMat.EsamiStudente.Add(cMat2, true);
            sMat.EsamiStudente.Add(cMat3, true);
            sMat.CFUAccumulati = CalcolaCFUaccumulati(sMat);
            sMat.RichiestaLaurea = ValutaRichiestaLaurea(sMat); 

            sMed.EsamiStudente.Add(cMed1, true);
            sMed.EsamiStudente.Add(cMed2, true);
            sMed.EsamiStudente.Add(cMed3, true);
            sMed.CFUAccumulati = CalcolaCFUaccumulati(sMed);
            sMed.RichiestaLaurea = ValutaRichiestaLaurea(sMed); 


        }

        internal static void Verbalizza(Corso esame, Studente studente)
        {
            studente.EsamiStudente[esame] = true;
            studente.CFUAccumulati = CalcolaCFUaccumulati(studente);
            studente.RichiestaLaurea = ValutaRichiestaLaurea(studente);

        }

        internal static bool ControllaSceltaVerbalizzazione(int codiceEsame, Studente studente, out Corso esame)
        {
            bool esameInLista = false;
            bool nonVerbalizzato = false;
            esame = null;
            

            foreach (var item in studente.EsamiStudente)
            {
                if (codiceEsame == item.Key.Id)
                {
                    esameInLista = true;
                    var placeholder = item;

                    if (!placeholder.Value)
                    {
                        nonVerbalizzato = true;
                        esame = placeholder.Key;
                    }
                }
            }

            
            if (esameInLista && nonVerbalizzato)
            {
                return true;
            }

            else return false;
        }

        internal static void AggiungiEsameAStudente(Studente studente, Corso esame)
        {
            studente.EsamiStudente.Add(esame, false);
        }

        internal static bool ControllaEsame(int codiceEsame, Studente studente, out Corso esame)
        {

            foreach (var item in studente.CdL.CorsiAssociati)
            {
                if (item.Id == codiceEsame)
                {
                    esame = item;
                    return true;
                }
            }
            esame = null;
            return false;
        }

        internal static Studente GetStudenteByMatricola(int matricola)
        {
            foreach (var item in studentiIscritti)
            {
                if (matricola == item.Matricola)
                {
                    return item;
                }
            }
            return null;
        }

        internal static void StampaCorsiPerCdL(Studente studente)
        {
            foreach (var item in studente.CdL.CorsiAssociati)
            {
                Console.WriteLine($" {item.Id} - {item.Nome}");
            }
        }

        internal static bool ControllaIscrizione(int matricola)
        {
            foreach (var item in studentiIscritti)
            {
                if (matricola == item.Matricola)
                {
                    return true;
                }
            }
            return false;
        }

        internal static bool ControllaRequisiti(Studente studente, Corso esame)
        {
            //requisiti prenotazione (tre booleani)
            // check richiestalaurea
            // esame non già in lista studente
            // CFU non sforano
            bool bool1 = true;
            bool bool2 = true;
            bool bool3= true;

            if (studente.RichiestaLaurea)
            {
                bool1 = false;
            }

            foreach (var item in studente.EsamiStudente)
            {
                if (item.Key.Id == esame.Id)
                {
                    bool2 = false;
                }
            }

            int cfu = studente.CFUAccumulati + esame.CFU;

            if (cfu > studente.CdL.TotaleCFU)
            {
                bool3 = false;
            }

            if (bool1 && bool2 && bool3)
            {
                return true;
            }

            else return false;

        }

        private static bool ValutaRichiestaLaurea(Studente stud)
        {
            if (stud.CFUAccumulati == stud.CdL.TotaleCFU)
            {
                return true;
            }
            else
                return false;

        }

        private static int CalcolaCFUaccumulati(Studente stud)
        {
            int cfu = 0;
            foreach (var item in stud.EsamiStudente) // (item è la coppia key value, ovvero cod.esame / esito)
            {
                if (item.Value)
                {
                    cfu += item.Key.CFU;
                }
            }
            return cfu;
        }
    }
}
