using ChatApp.Contracts.Domain;
using System.Collections.ObjectModel;
using System.ServiceModel;


namespace ChatApp.Contracts.Contract
{
	public interface IMessageServiceCallBack
	{
		[OperationContract(IsOneWay = true)]
		void ForwardToClient(Message message);

		[OperationContract(IsOneWay = true)]
		void UserConnected(ObservableCollection<User> user);
	}
}
