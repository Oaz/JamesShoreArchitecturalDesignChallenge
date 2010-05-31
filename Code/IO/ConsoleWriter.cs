
using System;

namespace JamesShoreChallenge
{
	public class ConsoleWriter : OutputCharStream
	{
		public void PutChar(char c)
		{
			Console.Write(c);
		}
	}
}
