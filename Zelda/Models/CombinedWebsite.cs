using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Xml;
using System.Xml.Serialization;

namespace Zelda.Models {
	public class CombinedWebsite {

		public String[] Owner { get; set; }
		public string URL { get; set; }
		public string[] Description { get; set; }
		public int Score { get; set; }
		public string[] Title { get; set; }
		public Categories?[] Category { get; set; }
	}

}