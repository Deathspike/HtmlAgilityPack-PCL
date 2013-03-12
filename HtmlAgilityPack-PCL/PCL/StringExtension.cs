using System;
using System.Linq;

namespace HtmlAgilityPack {
	static class StringExtension {
		public static string[] Split(this string Subject, char[] Separator, int Count) {
			string[] Pieces = Subject.Split(Separator);
			if (Pieces.Length > 2) {
				Pieces[1] = String.Join(Separator.First().ToString(), Pieces.Skip(1).ToArray());
			}
			return Pieces;
		}
	}
}