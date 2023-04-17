using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Xsl;

namespace bytebank_ATENDIMENTO.bytebank.Exception
{

	[Serializable]
	public class BytebankException : System.Exception
	{
		public BytebankException() { }
		public BytebankException(string message) : base("Aconteceu uma exceção: " + message)
		{

		}
		public BytebankException(string message, System.Exception inner) : base(message, inner) { }
		protected BytebankException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
	}
}
