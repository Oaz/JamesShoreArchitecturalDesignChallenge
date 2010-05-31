
using System;
using NUnit.Framework;
using Moq;
using NUnit.Framework.SyntaxHelpers;

namespace JamesShoreChallenge
{


	[TestFixture]
	public class Rot13ConverterLogic
	{

		[Test]
		public void PerformRot13OnIndividualChars ()
		{
			Assert.That( Rot13Converter.CharRot13('A'), Is.EqualTo('N') );
			Assert.That( Rot13Converter.CharRot13('U'), Is.EqualTo('H') );
			Assert.That( Rot13Converter.CharRot13('c'), Is.EqualTo('p') );
			Assert.That( Rot13Converter.CharRot13('s'), Is.EqualTo('f') );
			Assert.That( Rot13Converter.CharRot13('3'), Is.EqualTo('3') );
			Assert.That( Rot13Converter.CharRot13('*'), Is.EqualTo('*') );
		}
		
		[Test]
		public void TransformCharStreamIntoRot13edCharStream ()
		{
			var inputStream = new Mock<InputCharStream>();
			inputStream
				.Setup( stream => stream.HasChars() )
				.ReturnsInOrder( true, true, false );
			inputStream
				.Setup( stream => stream.GetChar() )
				.ReturnsInOrder( 'A', 'c' );
			
			var outputStream = new Mock<OutputCharStream>();      
			var converter = new Rot13Converter();
			
			converter.ExecuteOn( inputStream.Object, outputStream.Object );
			
			outputStream.Verify( stream => stream.PutChar('N'), Times.Once() );
			outputStream.Verify( stream => stream.PutChar('p'), Times.Once() );
			outputStream.Verify( stream => stream.PutChar(It.IsAny<char>()), Times.Exactly(2) );
		}
	}
}
