using System;
using System.Text;
using System.IO;

namespace fsm {
		//Tomasz Binczycki
		static class IOMachine {
				static string errorMessage = "Błąd w linii {0}:" + Environment.NewLine + "{1}";
				internal static string stringToSpace(this string s) {
						if (s.IndexOf(" ") != -1) return s.Substring(0, s.IndexOf(" "));
						if (s.IndexOf(Environment.NewLine) != -1) return s.Substring(0, s.IndexOf(Environment.NewLine));
						return s;
				}
				internal static string readToSpace(ref string s) {
						try {
								return s.stringToSpace();
						} finally {
								int l = s.stringToSpace().Length;
								while (l < s.Length && s[l] == ' ') ++l;
								s = s.Substring(l, s.Length - l);
						}
				}
				public static FunkcjaPrzejscia LoadMachine(TextReader reader) {
						FunkcjaPrzejscia ret = new FunkcjaPrzejscia("tempName", "");
						string s;
						int line = 0;
						try {
								using (reader) {
										s = reader.ReadLine(); ++line;
										if (s != "MM_TB_TCS") throw new Exception(string.Format(errorMessage, line, "Opis Maszyny musi rozpoczynać się od napisu MM_TB_TCS"));
										s = reader.ReadLine(); ++line;
										ret.nazwa = s.stringToSpace();
										s = reader.ReadLine(); ++line;
										int liczbaStanow;
										while (!Int32.TryParse(readToSpace(ref s), out liczbaStanow)) { s = reader.ReadLine(); ++line; }
										//InfoBox.Show(liczbaStanow+"");
										s = reader.ReadLine(); ++line;
										for (int i = 0; i < liczbaStanow; ++i) ret.DodajStan(readToSpace(ref s), false);
										int liczbaKoncowych;
										s = reader.ReadLine(); ++line;
										while (!Int32.TryParse(readToSpace(ref s), out liczbaKoncowych)) { s = reader.ReadLine(); ++line; }
										//InfoBox.Show(liczbaKoncowych + "");
										s = reader.ReadLine(); ++line;
										for (int i = 0; i < liczbaKoncowych; ++i) ret.UstawKoncowy(readToSpace(ref s), true);
										int liczbaLiter;
										s = reader.ReadLine(); ++line;
										while (!Int32.TryParse(readToSpace(ref s), out liczbaLiter)) { s = reader.ReadLine(); ++line; }
										//InfoBox.Show(liczbaLiter + "");
										s = reader.ReadLine(); ++line;
										for (int i = 0; i < liczbaLiter; ++i) ret.DodajLitere(s[i]);
										//wczytywanie funkcji przejscia
										int liczbaPrzejsc;
										s = reader.ReadLine(); ++line;
										while (!Int32.TryParse(readToSpace(ref s), out liczbaPrzejsc)) { s = reader.ReadLine(); ++line; }
										//InfoBox.Show(liczbaPrzejsc + "");
										string s1, s2, a;
										for (int i = 0; i < liczbaPrzejsc; ++i) {
												s = reader.ReadLine(); ++line;
												s1 = readToSpace(ref s);
												a = readToSpace(ref s);
												if (readToSpace(ref s) != "->") throw new Exception(string.Format(errorMessage, line, "Bledny opis funkcji przejscia"));
												s2 = readToSpace(ref s);
												ret.DodajPrzejscie(s1, a[0], s2);
										}
										ret.info = reader.ReadToEnd();
								}
						} catch (ExceptionInFunkcjaPrzejscia ex) {
								throw new ExceptionInFunkcjaPrzejscia(string.Format(errorMessage, line, ex.Message));
						}
						return ret;
				}
				public static string SaveMachine(FunkcjaPrzejscia fP) {
						StringBuilder sb = new StringBuilder();
						sb.AppendLine("MM_TB_TCS");
						sb.AppendLine(fP.nazwa + " Nazwa maszyny");
						sb.AppendLine();
						sb.AppendLine(fP.Stany.Count + " Liczba stanow");
						int liczbaKoncowych = 0;
						int liczbaPrzejsc = 0;
						fP.Stany.ForEach(o => {
								if (o.koncowy) ++liczbaKoncowych;
								liczbaPrzejsc += o.mapa.Count;
						});
						fP.Stany.ForEach(o => { sb.Append(o.nazwa + " "); });
						sb.AppendLine("Nazwy stanow");
						sb.AppendLine(liczbaKoncowych + " Liczba stanow koncowych");
						fP.Stany.ForEach(o => { if (o.koncowy)sb.Append(o.nazwa + " "); });
						sb.AppendLine("Stany koncowe");
						sb.AppendLine();
						sb.AppendLine(fP.alfabet.Length + " Liczba liter alfabetu");
						sb.AppendLine(fP.alfabet+ " Litery alfabetu");
						sb.AppendLine();
						sb.AppendLine(liczbaPrzejsc + " Liczba produkcji");
						fP.Stany.ForEach(o => {
								foreach (var x in o.mapa) {
										sb.AppendLine(o.nazwa + " " + x.Key + " -> " + x.Value.nazwa);
								}
						});
						sb.Append(fP.info);
						sb.AppendLine();
						//		throw new ExceptionInFunkcjaPrzejscia("jeszcze nie dziala. trzeba zaklepac");
						return sb.ToString();
				}
		}
}
