
using System;
using NUnit.Framework;
using Moq;

namespace JamesShoreChallenge
{
	[TestFixture]
	public class MultiOutput
	{
		[Test]
		public void DuplicateCharStream()
		{
			var outputStream1 = new Mock<OutputCharStream>();      
			var outputStream2 = new Mock<OutputCharStream>(); 
			var multipleOutput = new MultiOutputCharStream( outputStream1.Object, outputStream2.Object );
			multipleOutput.PutChar('A');
			outputStream1.Verify(stream => stream.PutChar('A'));
			outputStream2.Verify(stream => stream.PutChar('A'));
			multipleOutput.PutChar('B');
			outputStream1.Verify(stream => stream.PutChar('B'));
			outputStream2.Verify(stream => stream.PutChar('B'));
		}
	}
}
