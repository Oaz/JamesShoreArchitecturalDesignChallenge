
using System;

namespace JamesShoreChallenge
{


	public class CurrentFolderConfiguration : Configuration
	{
		public string GetDataPath (string fileName)
		{
			string basePath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
			return System.IO.Path.Combine( basePath, fileName );
		}
	}
}
