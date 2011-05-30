using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace fsm {
		static class IOMachine {
				static string errorMessage ="Błąd w linii {0}:"+Environment.NewLine+"{1)";
				internal static string stringToSpace(this string s) {
						if (s.IndexOf(" ")!= -1) return s.Substring(0, s.IndexOf(" "));
						return s;
				}
				internal static string readToSpace(this string s) {
						try{
								return s.stringToSpace();
						} finally {
//nie wiem czy dziala
								s = s.Substring(s.IndexOf(" "), s.Length); 
						}
				}
				public static FunkcjaPrzejscia LoadMachine(TextReader reader) {
						FunkcjaPrzejscia ret = new FunkcjaPrzejscia("tempName", "");
						string s;
						using (reader) {
								s = reader.ReadLine();
								if (s != "MM_TB_TCS") throw new Exception(string.Format(errorMessage, 1, "Opis Maszyny musi rozpoczynać się od napisu MM_TB_TCS"));
								s = reader.ReadLine();
								ret.nazwa = s.stringToSpace();
						}
						throw new Exception("jeszcze nie dziala. trzeba zaklepac");
						return ret;
				}
				public static string SaveMachine(FunkcjaPrzejscia fP) {
						throw new Exception("jeszcze nie dziala. trzeba zaklepac");
						return null;
				}
		}
}
