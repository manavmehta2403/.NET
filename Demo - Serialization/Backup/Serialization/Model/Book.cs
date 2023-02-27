using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Serialization.Model
{
	[Serializable]
	[XmlRoot("book")]
	public class Book : ShoppingItem
	{
		[XmlElement("name")]
		public string Name { get; set; }

		[XmlElement("author")]
		public string Author { get; set; }

		[XmlElement("description")]
		public string Description { get; set; }

		public Book()
		{
		}
	}
}
