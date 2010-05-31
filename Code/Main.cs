using System;

namespace JamesShoreChallenge
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			var config = new CurrentFolderConfiguration();
			var converter = new Rot13Converter();
			converter.ExecuteOn(
			  new FileReader(args[0], config),
			  new MultiOutputCharStream(
			    new FileWriter(args[1], config),
			    new ConsoleWriter()
			  )
			);
			Console.WriteLine();
		}
	}
}
