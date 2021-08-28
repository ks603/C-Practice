using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleWebScraper.Workers;
using SimpleWebScraper.Data;
using SimpleWebScraper.Builders;
using System.Text.RegularExpressions;

namespace SimpleWebScraper.Test.Unit
{
	[TestClass]
	public class ScraperTest
	{
		private readonly Scraper _scraper = new Scraper();

		[TestMethod]
		public void FindCollectionWithNoParts()
		{
			var content = "Some fluff data <a href=\"http://domain.com\" data-id=\"someId\" class=\"result-title hdrlnk\">some text</a> more fluff data";


			ScrapeCriteria scrapeCriteria = new ScrapeCriteriaBuilder()
				.WithData(content)
				.WithRegex(@"<a href=\""(.*?)\"" data-id=\""(.*?)\"" class=\""result-title hdrlnk\"" id=\""(.*?)\"" >(.*?)</a>")
				.WithRegexOption(RegexOptions.ExplicitCapture)
				.Build();

			var foundElements = _scraper.Scrape(scrapeCriteria);

			Assert.IsTrue(foundElements.Count == 1);
			Assert.IsTrue(foundElements[0] == "<a href=\"http://domain.com\" data-id=\"someId\" class=\"result-title hdrlnk\">some text</a>");
		}
	}
}