using System;

class Program
{
    class Prodotto
    {
        //Attributi
        private string nome;
        private float prezzo;

        //Costruttore con parametri
        public Prodotto(string mnome, float mprezzo)
        {
            nome = mnome;
            prezzo = mprezzo;
        }
        
        //Costruttore senza parametri
        public Prodotto()
        {
            nome = "pesca";
            prezzo = 4;
        }

        //Metodo
        public string Elenco()
        {
            return nome + " " + Convert.ToString(prezzo);
        }

    }

    static void Main()
    {
        Prodotto prodotto1 = new Prodotto("Mele",3);
        Prodotto prodotto2 = new Prodotto("Pesca", 4);

        Console.WriteLine(prodotto1.Elenco());
        Console.WriteLine(prodotto2.Elenco());
    }

    

}