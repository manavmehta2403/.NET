using System;
using System.Collections.ObjectModel;

namespace ChatApp.Contracts.Domain
{
	public class User
	{
		private string _UserID;

		public string UserID
		{
			get { return _UserID; }
			set { _UserID = value; }
		}

		public string Name { get; set; }

		public DateTime TimeCreated { get; set; }

		public ObservableCollection<Message> UserMessages { get; set; }
	}
}
