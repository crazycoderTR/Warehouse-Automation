using System;
namespace MessagingToolkit.QRCode.ExceptionHandler
{
	public class FinderPatternNotFoundException:System.Exception
	{
        internal String message = null;
		public override String Message
		{
			get
			{
				return message;
			}
			
		}		
		public FinderPatternNotFoundException(String message)
		{
			this.message = message;
		}
	}
}