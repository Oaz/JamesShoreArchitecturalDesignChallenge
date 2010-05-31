
using System;

namespace JamesShoreChallenge
{


	public class Rot13Converter
	{
		public void ExecuteOn (InputCharStream inputStream,  OutputCharStream outputStream)
		{
			while( inputStream.HasChars() )
				outputStream.PutChar( CharRot13(inputStream.GetChar()) );
		}
		
		public static char CharRot13(char c)
		{
			if( char.IsUpper(c) )
				return CharRot13Impl(c,'A');
			else if( char.IsLower(c) )
				return CharRot13Impl(c,'a');
			else
				return c;
		}
		
		static char CharRot13Impl(char inputChar, char baseChar)
		{
			return Convert.ToChar(AsciiRot13(Convert.ToInt32(inputChar),Convert.ToInt32(baseChar)));
		}
		
		static int AsciiRot13(int inputCode, int baseCode)
		{
			return ((inputCode - baseCode + 13) % 26) + baseCode;
		}
	}
}
