
using System;

namespace JamesShoreChallenge
{


	public class MultiOutputCharStream : OutputCharStream
	{
		OutputCharStream[] streams;
		
		public MultiOutputCharStream(params OutputCharStream[] outputStreams)
		{
			streams = outputStreams;
		}

		public void PutChar(char c)
		{
			foreach(var stream in streams)
				stream.PutChar(c);
		}
	}
}
