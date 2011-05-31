using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

public class ExceptionInFunkcjaPrzejscia : Exception{
		public ExceptionInFunkcjaPrzejscia(string s): base(s) {}
}
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
        catch (ExceptionInFunkcjaPrzejscia) { };
        return ret;
    }
}


public class FunkcjaPrzejscia
{
		public const int MAX_DLUGOSC_NAZWY_STANU = 20;
    public string nazwa;
    public string alfabet;
    public string info;
    public Stan obecny = null;
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
        if (lit) throw new ExceptionInFunkcjaPrzejscia("Ta litera jest już w alfabecie");
        alfabet += litera;
    }

    internal void UsunStan(string nazwa){
        int i = 0;
        foreach (Stan s in Stany) { if (s.nazwa == nazwa) break; i++;}
        Stany.Remove(Stany[i]);
        }

    public void UsunLitere(char c){
        string t="";
        foreach (char a in alfabet) if (a != c) t += a;
        alfabet=t;
    }

    

    public void DodajStan(string nazwa, bool koncowy)
    {
        foreach (Stan e in Stany) if (e.nazwa == nazwa)
                throw new ExceptionInFunkcjaPrzejscia("Stan o podanej nazwie już istnieje");
        Stan nowy = new Stan(nazwa, koncowy);
        Stany.Add(nowy);
        if (obecny == null) obecny = nowy;
    }



    public void DodajPrzejscie(string nazwaStanu, char litera, string stanDocelowy)
    {
        Stan start = null;
        foreach (Stan i in Stany) if (i.nazwa == nazwaStanu) start = i;
        if (start == null) throw new ExceptionInFunkcjaPrzejscia("Stan początkowy nie istnieje: "+ nazwaStanu);
        Stan koniec = null;
        foreach (Stan i in Stany) if (i.nazwa == stanDocelowy) koniec = i;
        if (koniec == null) throw new ExceptionInFunkcjaPrzejscia("Stan docelowy nie istnieje: "+ stanDocelowy);
        bool lit = true;
        foreach (char i in alfabet) if (i == litera) lit = false;
        if (lit) throw new ExceptionInFunkcjaPrzejscia("Podana litra nie istnieje w alfabecie: "+litera);
        char[] c = start.mapa.Keys.ToArray();
        lit = false;
        foreach (char i in c) if (i == litera) lit = true;
        if (lit) throw new ExceptionInFunkcjaPrzejscia("Takie przejście jest już zdefiniowane");
        start.mapa.Add(litera, koniec);
    }

    public void Przejscie(char litera)
    {
        Stan s = obecny.Przejscie(litera);
        if (s != null) obecny = s;
        else throw new ExceptionInFunkcjaPrzejscia("Wyraz nieakceptowalny");

    }

    public void UstawKoncowy(string nazwa, bool koncowy) {
        foreach (Stan x in Stany) if (x.nazwa == nazwa) x.koncowy = koncowy;
    }

    public int AlfabetIndex(char c) {
        int i = 0;
        while (i < alfabet.Length && c != alfabet[i]) i++;
        if (i == alfabet.Length) return -1;
        return i;
    }

    public void Reset() {
        obecny = Stany[0];
    }

		public FunkcjaPrzejscia(bool b ){        
            info = "Funkcja akceptuje wyrazy postaci (((ab)^n)c)";
            nazwa = "Pierwsza";
            DodajStan("S1", false);
            DodajStan("S2", false);
            DodajStan("S3", true);
            alfabet = "abc";
            DodajPrzejscie("S1", 'a', "S2");
            DodajPrzejscie("S3", 'c', "S3");
            DodajPrzejscie("S2", 'b', "S1");
            DodajPrzejscie("S1", 'c', "S3");
      
        }


		internal void UsunWszystkiePrzejscia() {
				foreach (Stan s in Stany) {
						s.mapa.Clear();
				}
		}
}

