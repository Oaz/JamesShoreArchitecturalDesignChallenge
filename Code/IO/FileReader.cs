
using System;

namespace JamesShoreChallenge
{

	public class FileReader : InputCharStream
	{
		char[] content;
		int index;

		public FileReader(string fileName, Configuration configuration)
		{
			content = System.IO.File.ReadAllText(configuration.GetDataPath(fileName)).ToCharArray();
			index = 0;
		}
		
		public char GetChar ()
		{
			return content[index++];
		}
		
		public bool HasChars ()
		{
			return index < content.Length;
		}
	}
}
