using System;

namespace ChatApp.Contracts.Domain
{
	public class Message
	{
		public DateTime TimeSent { get; set; }
		public string FromUserID { get; set; }
		public string ToUserID { get; set; }
		public string Messagesent { get; set; }
	}
}