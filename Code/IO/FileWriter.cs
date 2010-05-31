
using System;

namespace JamesShoreChallenge
{


	public class FileWriter : OutputCharStream
	{
		string filePath;

		public FileWriter(string fileName, Configuration configuration)
		{
			filePath = configuration.GetDataPath(fileName);
		}
		
		public void PutChar(char c)
		{
			System.IO.File.AppendAllText(filePath, c.ToString());
		}
	}
}
