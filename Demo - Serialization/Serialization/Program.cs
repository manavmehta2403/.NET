// A Hello World! program in C#.
using System;
using System.Text;
using System.Xml.Serialization;
using System.Xml;

using Serialization.Model;

namespace Serialization
{
	class Hello
	{
		static void Main(string[] args)
		{
			User user = CreateUser();

			DefaultSettingsExample(user);
			NonIndentedXmlExample(user);
			RemoveNamespacesExample(user);
			CustomNamespacesExample(user);
			EncodingExample(user);
			XmlNoDeclarationExample(user);

			// the settings used in the previous examples can also be used with XML file serialization
			XmlFileSerializationExample(user);
		}

		private static User CreateUser()
		{
			User user = new User();
			user.Id = 1;
			user.Age = 30;
			user.Type = UserType.Platinum;
			user.FirstName = "Rui";
			user.LastName = "Jarimba";
			user.Email = "email@somewhere.com";

			user.UserAddress = new Address();
			user.UserAddress.Street = "my street 1";
			user.UserAddress.PostalCode = "1000-001";
			user.UserAddress.City = "Lisbon";
			user.UserAddress.Country = "Portugal";

			user.DeliveryAddress = new Address();
			user.DeliveryAddress.Street = "another street";
			user.DeliveryAddress.PostalCode = "1000-002";
			user.DeliveryAddress.City = "Lisbon";
			user.DeliveryAddress.Country = "Portugal";

			//
			// Shopping cart 
			//
			user.ShoppingCart = new ShoppingCart();
			// u.ShoppingCart.PurchaseDate = DateTime.Now;

			Book book1 = new Book();
			book1.Name = "Jamie's Italy";
			book1.Price = 34.95;
			book1.Reference = "978-1401301958";
			book1.Author = "Jamie Oliver";
			book1.Description = "Italian food made by Jamie Oliver!";
			user.ShoppingCart.Items.Add(book1);

			Book book2 = new Book();
			book2.Name = "Ensaio Sobre a Cegueira";
			book2.Price = 59.95;
			book2.Reference = "B0042TL15I";
			book2.Author = "José Saramago";
			user.ShoppingCart.Items.Add(book2);

			CD cd = new CD();
			cd.Name = "The Blackening";
			cd.Artist = "Machine Head";
			cd.Genre = "Trash Metal";
			cd.Price = 15.0;
			cd.Reference = "B000N3ST9I";
			user.ShoppingCart.Items.Add(cd);

			Dvd dvd = new Dvd();
			dvd.Name = "The Lord of the Rings: The Return of the King";
			dvd.Price = 14.99;
			dvd.Reference = "B00005JKZY";
			dvd.Genre = "Action, Adventure, Drama ";
			user.ShoppingCart.Items.Add(dvd);

			return user;
		}

		private static void DefaultSettingsExample(User user)
		{
			// default serialization settings
			string xml = XmlSerializer<User>.Serialize(user);

			// get user from XML
			User user2 = XmlSerializer<User>.Deserialize(xml);
		}

		private static void NonIndentedXmlExample(User user)
		{
			XmlWriterSettings settings = new XmlWriterSettings();
			settings.Indent = false;

			string xml = XmlSerializer<User>.Serialize(user, settings);

			// get user from XML
			User user2 = XmlSerializer<User>.Deserialize(xml);
		}

		private static void RemoveNamespacesExample(User user)
		{
			XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();
			namespaces.Add("", "");

			string xml = XmlSerializer<User>.Serialize(user, namespaces);

			// get user from XML
			User user2 = XmlSerializer<User>.Deserialize(xml);
		}

		private static void CustomNamespacesExample(User user)
		{
			XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();
			namespaces.Add("n1", "http://mynamespace1.com");
			namespaces.Add("n2", "http://mynamespace2.com"); 

			string xml = XmlSerializer<User>.Serialize(user, namespaces);

			// get user from XML
			User user2 = XmlSerializer<User>.Deserialize(xml);
		}

		private static void EncodingExample(User user)
		{
			XmlWriterSettings writterSettings = new XmlWriterSettings();
			writterSettings.Encoding = Encoding.UTF32;

			string xml = XmlSerializer<User>.Serialize(user, writterSettings);

			// get user from XML
			User user2 = XmlSerializer<User>.Deserialize(xml, Encoding.UTF32);
		}

		private static void XmlNoDeclarationExample(User user)
		{
			XmlWriterSettings writterSettings = new XmlWriterSettings();
			writterSettings.OmitXmlDeclaration = true;

			string xml = XmlSerializer<User>.Serialize(user, writterSettings);

			XmlReaderSettings readerSettings = new XmlReaderSettings();
			readerSettings.ConformanceLevel = ConformanceLevel.Fragment;
			User user2 = XmlSerializer<User>.Deserialize(xml, readerSettings); 
			User user3 = XmlSerializer<User>.Deserialize(xml); // this works too
		}

		private static void XmlFileSerializationExample(User user)
		{
			string filename = @"c:\dump\user.xml";

			// default file serialization
			XmlSerializer<User>.SerializeToFile(user, filename);
			User u3 = XmlSerializer<User>.DeserializeFromFile(filename); // try to get the object from the created file


			//
			// define some settings
			//
			XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();
			namespaces.Add("", "");

			XmlWriterSettings settings = new XmlWriterSettings();
			settings.Encoding = Encoding.UTF8;
			settings.Indent = true;
			settings.IndentChars = "\t";

			XmlSerializer<User>.SerializeToFile(user, filename, namespaces, settings);
			u3 = XmlSerializer<User>.DeserializeFromFile(filename);
		}
	}
}