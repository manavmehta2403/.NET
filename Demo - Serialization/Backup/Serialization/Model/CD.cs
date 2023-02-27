using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Serialization.Model
{
	[Serializable]
	[XmlRoot("cd")]
	public class CD : ShoppingItem
	{
		[XmlElement("artist")]
		public string Artist  { get; set; }

		[XmlElement("name")]
		public string Name { get; set; }

		[XmlElement("genre")]
		public string Genre { get; set; }

		public CD()
		{
		}
	}
}
