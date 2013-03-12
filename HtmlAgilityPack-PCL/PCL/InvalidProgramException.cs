using System;

namespace HtmlAgilityPack {
	class InvalidProgramException : Exception {
		public InvalidProgramException(string Exception)
			: base(Exception) {
			return;
		}
	}
}