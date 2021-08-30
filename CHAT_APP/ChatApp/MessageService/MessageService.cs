using ChatApp.Contracts.Contract;
using ChatApp.Contracts.Domain;
using System.Collections.ObjectModel;

namespace ChatApp.Service
{

	[ServiceBehavior]
	public class MessageService : IMessageService
	{
		
		public void Connect(User user)
		{
			throw new System.NotImplementedException();
		}

		public ObservableCollection<User> GetConnectedUsers()
		{
			throw new System.NotImplementedException();
		}

		public void SendMessage(Message message)
		{
			throw new System.NotImplementedException();
		}

		private string GetDebuggerDisplay()
		{
			return ToString();
		}
	}
}
