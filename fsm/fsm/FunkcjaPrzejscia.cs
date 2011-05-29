using System;



public class FunkcjaPrzejscia
{
    string nazwa;
    string alfabet;
    Stan obecny = null;
    List<Stan> Stany = new List<Stan>();

    public FunkcjaPrzejscia(string nazwa, string alfabet)
    {
        this.nazwa = nazwa;
        this.alfabet = alfabet;
    }

    public FunkcjaPrzejscia(string nazwa, string alfabet)
    {
        this.nazwa = nazwa;
        this.alfabet = alfabet;
    }

    public void ZmainaNazwy(string nowaNazw)
    {
        nazwa = nowaNazwa;
    }


    class Stan
    {
        public Stan(string nazwa, bool koncowy)
        {
            this.nazwa = nazwa;
            this.koncowy = koncowy;
        }
        public bool koncowy;
        public string nazwa;
        public Dictionary<char, Stan> mapa = new Dictionary<char, Stan>();
        public Stan Przejscie(char litera)
        {
            Stan ret = null;
            try
            {
                ret = mapa[litera];
            }
            catch (Exception e) { };
            return ret;
        }
    }



    public void DodajStan(string nazwa, bool koncowy)
    {
        foreach (Stan e in Stany) if (e.nazwa == nazwa)
                throw new Exception("Stan o podanej nazwie już istnieje");
        Stan nowy = new Stan(nazwa, koncowy);
        Stany.Add(nowy);
        if (obecny == null) obecny = nowy;
    }



    public void DodajPrzejscie(string nazwaStanu, char litera, string stanDocelowy)
    {
        Stan start = null;
        foreach (Stan i in Stany) if (i.nazwa == nazwaStanu) start = i;
        if (start == null) throw new Exception("Stan początkowy nie istnieje");
        Stan koniec = null;
        foreach (Stan i in Stany) if (i.nazwa == stanDocelowy) koniec = i;
        if (koniec == null) throw new Exception("Stan docelowy nie istnieje");
        bool lit = true;
        foreach (char i in alfabet) if (i == litera) lit = false;
        if (lit) throw new Exception("Podana litra nie istnieje w alfabecie");
        char[] c = start.mapa.Keys.ToArray();
        lit = false;
        foreach (char i in c) if (i == litera) lit = true;
        if (lit) throw new Exception("Takie przejście jest już zdefiniowane");
        start.mapa.Add(litera, koniec);
    }

    public void Przejscie(char litera)
    {
        Stan s = obecny.Przejscie(litera);
        if (s != null) obecny = s;
        else throw new Exception("Wyraz nieakceptowalny");

    }


/*
    public static void Main()
    {
        try
        {
            FunkcjaPrzejscia f = new FunkcjaPrzejscia("Funkcja1", "abc");
            f.DodajStan("S1", false);
            f.DodajStan("S2", false);
            f.DodajStan("S3", true);
            Console.WriteLine(f.obecny.nazwa);
            f.DodajPrzejscie("S1", 'a', "S2");

            f.DodajPrzejscie("S2", 'b', "S1");
            f.DodajPrzejscie("S1", 'c', "S3");
            f.Przejscie('a');
            Console.WriteLine(f.obecny.nazwa);
            f.Przejscie('b');
            Console.WriteLine(f.obecny.nazwa);
            f.Przejscie('c');
            Console.WriteLine(f.obecny.nazwa);
        }
        catch (Exception e) { Console.WriteLine(e.Message); }
        Console.ReadLine();
    }*/
}

