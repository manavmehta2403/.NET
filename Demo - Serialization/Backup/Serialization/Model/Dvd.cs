using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Serialization.Model
{
	[Serializable]
	[XmlRoot("dvd")]
	public class Dvd : ShoppingItem
	{
		[XmlElement("name")]
		public string Name { get; set; }

		[XmlElement("genre")]
		public string Genre { get; set; }

		public Dvd()
		{
		}
	}
}
