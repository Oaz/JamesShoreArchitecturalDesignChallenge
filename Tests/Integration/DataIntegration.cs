
using System;
using NUnit.Framework;
using NUnit.Framework.SyntaxHelpers;

namespace JamesShoreChallenge
{
	[TestFixture]
	public class DataIntegration
	{
		[Test]
		public void HasTestConfigFile()
		{
			var config = new TestConfiguration();
			var testFilePath = config.GetDataPath("someInput.txt");
			Assert.That( System.IO.File.Exists(testFilePath), Is.True ); 
		}

		[Test]
		public void ReadFileFromDisk()
		{
			var reader = new FileReader( "someInput.txt", new TestConfiguration() );
			Assert.That( reader.HasChars(), Is.True );
			Assert.That( reader.GetChar(), Is.EqualTo('A') );
			Assert.That( reader.HasChars(), Is.True );
			Assert.That( reader.GetChar(), Is.EqualTo('B') );
			Assert.That( reader.HasChars(), Is.True );
			Assert.That( reader.GetChar(), Is.EqualTo('C') );
			Assert.That( reader.HasChars(), Is.False );
		}

		[Test]
		public void WriteFileToDisk()
		{
			var config = new TestConfiguration();
			var fileName = "someOutput.txt";
			var filePath = config.GetDataPath(fileName);
			
			System.IO.File.Delete(filePath);
			Assert.That( System.IO.File.Exists(filePath), Is.False );
			
			var writer = new FileWriter( fileName, config );
			writer.PutChar('X');
			writer.PutChar('Y');
			writer.PutChar('Z');
			Assert.That( System.IO.File.Exists(filePath), Is.True );
			Assert.That( System.IO.File.ReadAllText(filePath), Is.EqualTo("XYZ") );
		}
	}
}
