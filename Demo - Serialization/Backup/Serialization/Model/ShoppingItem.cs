using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Serialization.Model
{
	[Serializable]
	[XmlRoot("item")]
	public class ShoppingItem
	{
		[XmlAttribute("reference")]
		public string Reference { get; set; }

		[XmlAttribute("price")]
		public double Price { get; set; }

		public ShoppingItem()
		{
		}
	}
}
