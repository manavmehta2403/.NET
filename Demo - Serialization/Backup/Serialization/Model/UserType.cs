using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Serialization.Model
{
	[Flags]
	public enum UserType
	{
		[XmlEnum("0")]
		Basic = 0,

		[XmlEnum("1")]
		Premium = 1,

		[XmlEnum("2")]
		Platinum = 2
	}
}
