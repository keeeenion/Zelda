using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

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