using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

public class Stan
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
        catch (Exception) { };
        return ret;
    }
}


public class FunkcjaPrzejscia
{
    public string nazwa;
    public string alfabet;
    Stan obecny = null;
    public List<Stan> Stany = new List<Stan>();

    public FunkcjaPrzejscia(string nazwa, string alfabet)
    {
        this.nazwa = nazwa;
        this.alfabet = alfabet;
    }


    public void ZmainaNazwy(string nowaNazwa)
    {
        nazwa = nowaNazwa;
    }

    public void DodajLitere(char litera) {
        
        bool lit = false;
        foreach (char i in alfabet) if (i == litera) lit = true;
        if (lit) throw new Exception("Ta litera jest już w alfabecie");
        alfabet += litera;
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

    public void UstawKoncowy(string nazwa, bool koncowy) {
        foreach (Stan x in Stany) if (x.nazwa == nazwa) x.koncowy = koncowy;
    }


    public void Test()
    {
        
        {
            
            DodajStan("S1", false);
            DodajStan("S2", false);
            DodajStan("S3", true);
            alfabet = "abc";
            DodajPrzejscie("S1", 'a', "S2");
            DodajPrzejscie("S3", 'c', "S3");
            DodajPrzejscie("S2", 'b', "S1");
            DodajPrzejscie("S1", 'c', "S3");
      
        }
      
    }
}

