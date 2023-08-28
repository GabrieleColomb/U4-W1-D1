using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U4_W1_D1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Atleta atleta = new Atleta();
            {
                atleta.Nome = "Gabriele Colombo";
                atleta.Età = 20;
                atleta.SportPraticato = "Calcio";
                atleta.Altezza = 186;
                atleta.Peso = 92;
            };

            Studente studente = new Studente();
            {
                studente.Nome = "Elon Musk";
                studente.Età = 52;
                studente.CorsoDiStudi = "Economia";
                studente.Matricola = 12345;
                studente.Iscritto = true;
            };

            Animale animale = new Animale();
            {
                animale.Nome = "Simba";
                animale.Specie = "Cane";
                animale.Età = 12;
                animale.Alimentazione = "Croccantini";
                animale.Domestico = true;
            };

            Dipendente dipendente = new Dipendente();
            {
                dipendente.Nome = "Auguste Gusteau";
                dipendente.Ruolo = "Cuoco";
                dipendente.Stipendio = 2007;
                dipendente.AnniServizio = 4;
                dipendente.Dipartimento = "Ristorazione";
            };

            Film film = new Film();
            {
                film.Titolo = "Avatar";
                film.Anno = 2009;
                film.Regista = "James Cameron";
                film.Genere = "Fantascientifico";
                film.Durata = 2.4;
            };

            Prodotto prodotto = new Prodotto();
            {
                prodotto.Nome = "PlayStation";
                prodotto.Prezzo = 599.99m;
                prodotto.Quantità = 3;
            };

            //Stampa dettagli dell'atleta
            Console.WriteLine("Dettagli dell'atleta:");
            Console.WriteLine($"Nome: {atleta.Nome}");
            Console.WriteLine($"Età: {atleta.Età}");
            Console.WriteLine($"Sport praticato: {atleta.SportPraticato}");
            Console.WriteLine($"Altezza: {atleta.Altezza}");
            Console.WriteLine($"Peso: {atleta.Peso}");
            Console.WriteLine();


            //Stampa dettagli dello studente
            Console.WriteLine("Dettagli dello studente:");
            Console.WriteLine($"Nome: {studente.Nome}");
            Console.WriteLine($"Età: {studente.Età}");
            Console.WriteLine($"Corso di studi: {studente.CorsoDiStudi}");
            Console.WriteLine($"Matricola: {studente.Matricola}");
            Console.WriteLine($"Peso: {studente.Iscritto}");
            Console.WriteLine();


            //Stampa dettagli dell'animale
            Console.WriteLine("Dettagli dell'animale:");
            Console.WriteLine($"Nome: {animale.Nome}");
            Console.WriteLine($"Specie: {animale.Specie}");
            Console.WriteLine($"Età: {animale.Età}");
            Console.WriteLine($"Alimentazione: {animale.Alimentazione}");
            Console.WriteLine($"È domestico: {animale.Domestico}");
            Console.WriteLine();


            //Stampa dettagli del dipendente
            Console.WriteLine("Dettagli del dipendente");
            Console.WriteLine($"Nome: {dipendente.Nome}");
            Console.WriteLine($"Ruolo: {dipendente.Ruolo}");
            Console.WriteLine($"Stipendio {dipendente.Stipendio}");
            Console.WriteLine($"Anni di servizio: {dipendente.AnniServizio}");
            Console.WriteLine($"Dipartimento: {dipendente.Dipartimento}");
            Console.WriteLine();


            //Stampa dettagli del film
            Console.WriteLine("Dettagli del film");
            Console.WriteLine($"Titolo: {film.Titolo}");
            Console.WriteLine($"Anno: {film.Anno}");
            Console.WriteLine($"Regista: {film.Regista}");
            Console.WriteLine($"Genere: {film.Genere}");
            Console.WriteLine($"Durata: {film.Durata}");
            Console.WriteLine();

            decimal costoTotale = prodotto.CalcolaTotale();
            Console.WriteLine($"Il costo totale dei prodotti è: {costoTotale:C}");
        }
    }
}
