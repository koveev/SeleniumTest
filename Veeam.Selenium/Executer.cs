using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Veeam.Selenium
{
	public class Executer
	{
		public int CountingVacancies()
		{
			IWebDriver driver = new ChromeDriver();
			driver.Navigate().GoToUrl(@"https://careers.veeam.ru/vacancies");
			driver.Manage().Window.Maximize();
			driver.FindElement(By.XPath("//button[text() = 'Все отделы']")).Click();
			driver.FindElement(By.XPath("//a[text() = 'Разработка продуктов']")).Click();
			driver.FindElement(By.XPath("//button[text() = 'Все языки']")).Click();
			driver.FindElement(By.XPath("//label[text() = 'Английский']")).Click();
			driver.FindElement(By.XPath("//div[@class='container container-spacer-lg']")).Click();
			var countVacancies =  driver.FindElements(By.XPath("//a[@class='card card-no-hover card-sm']")).Count;
			driver.Quit();
			return countVacancies;
		}		
	}
}
