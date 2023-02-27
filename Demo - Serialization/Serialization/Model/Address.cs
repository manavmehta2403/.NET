using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Serialization.Model
{
	[Serializable]
	[XmlRoot("address")]
	public class Address
	{
		[XmlElement("street")]
		public string Street { get; set; }

		[XmlElement("postal-code")]
		public string PostalCode { get; set; }

		[XmlElement("city")]
		public string City { get; set; }

		[XmlElement("country")]
		public string Country { get; set; }

		[XmlIgnore]
		public string FullAddress
		{
			get
			{
				return string.Format("{0}{1}{2} {3}{1}{4}", Street, System.Environment.NewLine, PostalCode, City, Country);
			}
		}

		public Address() 
		{ 
		}
	}
}
