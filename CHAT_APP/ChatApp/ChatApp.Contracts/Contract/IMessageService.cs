﻿using ChatApp.Contracts.Domain;
using System.Collections.ObjectModel;
using System.ServiceModel;
namespace ChatApp.Contracts.Contract
{
	[ServiceContract(CallbackContract = typeof(IMessageServiceCallBack),SessionMode = SessionMode.Required)]
	public interface IMessageService
	{
		[OperationContract(IsOneWay = true)]
		void Connect(User user);

		[OperationContract(IsOneWay = true)]
		void SendMessage(Message message);

		[OperationContract(IsOneWay = false)]
		ObservableCollection<User>GetConnectedUsers();
	}
}
