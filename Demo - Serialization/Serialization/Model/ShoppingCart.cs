using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Serialization.Model
{
	[Serializable]
	[XmlRoot("shopping-cart")]
	public class ShoppingCart
	{
		[XmlElement("purchase-date", IsNullable=true)]
		public DateTime? PurchaseDate { get; set;}

		/// <summary>
		/// {property}Specified
		/// </summary>
		public bool PurchaseDateSpecified
		{
			get
			{
				return PurchaseDate.HasValue;
			}
		}

		// for each subclass of ShoppingItem you need to specify the XML element to generate
		[XmlArrayItem("cd", typeof(CD))]
		[XmlArrayItem("book", typeof(Book))]
		[XmlArrayItem("dvd", typeof(Dvd))]
		[XmlArray("items")]
		public List<ShoppingItem> Items
		{
			get;
			set;
		}

		[XmlIgnore]
		public double TotalPrice
		{
			get 
			{ 
				double total = 0;

				foreach (ShoppingItem i in Items)
					total += i.Price;

				return total;
			}
		}

		public ShoppingCart()
		{
			Items = new List<ShoppingItem>();
		}
	}
}
