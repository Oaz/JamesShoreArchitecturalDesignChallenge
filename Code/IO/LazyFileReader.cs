
using System;

namespace JamesShoreChallenge
{
	public class LazyFileReader : InputCharStream
	{
		System.IO.StreamReader readerImpl;
		
		public LazyFileReader(string fileName, Configuration configuration)
		{
			readerImpl = System.IO.File.OpenText(configuration.GetDataPath(fileName));
		}
		
		public char GetChar()
		{
			return Convert.ToChar(readerImpl.Read());
		}
		
		public bool HasChars()
		{
			return !readerImpl.EndOfStream;
		}
	}
}
