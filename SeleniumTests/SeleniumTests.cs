using NUnit.Framework;
using Selenium;

namespace SeleniumTests
{
	public class SeleniumTests
	{
		private Executer _executer;

		[SetUp]
		public void Setup()
		{
			_executer = new Executer();
		}

		[Test]
		public void CountingVacanciesTest()
		{
			int expectedVacancies = 6;
			int actualVacancies = _executer.CountingVacancies();
			Assert.AreEqual(expectedVacancies, actualVacancies);
		}
	}
}