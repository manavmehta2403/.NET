using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Serialization.Model
{
	[Serializable]
	[XmlRoot("user")]
	public class User
	{
		[XmlAttribute("id")]
		public int Id { get; set; }

		[XmlAttribute("user-type")]
		public UserType Type { get; set; }

		[XmlElement("first-name")]
		public string FirstName { get; set; }

		[XmlElement("last-name")]
		public string LastName { get; set; }

		[XmlIgnore]
		public string FullName
		{
			get
			{
				if (string.IsNullOrEmpty(FirstName))
					return LastName;

				if (string.IsNullOrEmpty(LastName))
					return FirstName;

				return string.Format("{0} {1}", FirstName, LastName);
			}
		}

		[XmlElement("age")]
		public int? Age { get; set; }

		[XmlElement("email")]
		public string Email { get; set; }

		public bool AgeSpecified
		{
			get
			{
				return Age.HasValue;
			}
		}

		[XmlElement("address")]
		public Address UserAddress { get; set; }

		[XmlElement("delivery-address")]
		public Address DeliveryAddress { get; set; }

		[XmlElement("cart")]
		public ShoppingCart ShoppingCart { get; set; }

		public User()
		{ 
		}
	}
}
