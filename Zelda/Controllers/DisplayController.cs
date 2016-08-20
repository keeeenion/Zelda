using Zelda.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Collections;
using System.Xml.Serialization;
using System.Web;
using System.IO;
using System.Xml;
using Newtonsoft.Json;
using System.Text;

namespace Zelda.Controllers {
	public class DisplayController : ApiController {

		public HttpResponseMessage Get() {
			WebsiteDbContext db = new WebsiteDbContext();

			var websites = new List<CombinedWebsite>();

			var query = db.Website.ToList();
			var uniques = query.Select(x => x.URL).Distinct().ToList();

			foreach (var unique in uniques) {

				String[] titles = query.Where(w => w.URL == unique).Select(s => s.Title).Distinct().ToArray();
				String[] owners = query.Where(w => w.URL == unique).Select(s => s.Owner).Distinct().ToArray();
				String[] descriptions = query.Where(w => w.URL == unique).Select(s => s.Description).Distinct().ToArray();
				int score = query.Where(w => w.URL == unique).Select(s => s.Score).Sum();
				Categories?[] categories = query.Where(w => w.URL == unique).Select(s => s.Category).Distinct().ToArray();

				websites.Insert(websites.Count, new CombinedWebsite {
					Title = titles,
					URL = unique,
					Owner = owners,
					Description = descriptions,
					Score = score,
					Category = categories
				});
			}

			string output = JsonConvert.SerializeObject(websites);

			var response = Request.CreateResponse(HttpStatusCode.OK);
			response.Content = new StringContent(output, Encoding.UTF8, "application/json");
			return response;
		}
	}
}
