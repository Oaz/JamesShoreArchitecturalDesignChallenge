
using System;
using System.Reflection;

namespace JamesShoreChallenge
{


	public class TestConfiguration : Configuration
	{
		public string GetDataPath (string fileName)
		{
			string basePath = System.IO.Path.GetFullPath(
			  System.IO.Path.Combine(
			    System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location),
			    "../../Tests/Integration"
			  )
			);
			return System.IO.Path.Combine( basePath, fileName );
		}
	}
}
