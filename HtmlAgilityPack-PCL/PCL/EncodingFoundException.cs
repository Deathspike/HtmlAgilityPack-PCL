using System;
using System.Text;

namespace HtmlAgilityPack {
	class EncodingFoundException : Exception {
		public EncodingFoundException(Encoding Encoding) {
			this.Encoding = Encoding;
		}

		public Encoding Encoding { get; private set; }
	}
}