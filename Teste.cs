using NUnit.Framework;
using OpenQA.Selenium.Chrome;

namespace VideoAula
{
    public class Teste
    {
        [SetUp]
        public void Setup()
        {
            ProportiesCollection.driver = new ChromeDriver(".");
            ProportiesCollection.driver.Navigate().GoToUrl("http://executeautomation.com/demosite/index.html");
            ProportiesCollection.driver.Manage().Window.Maximize();
        }

        [Test]
        public void Execute()
        {
            //inserir os comando aqui 
            SeleniumSetMethods.SelectDropDown("TitleId", "Mr.", PropertyType.Id);
            SeleniumSetMethods.EnterText("Initial", "teste Júlia", PropertyType.Name);

            System.Console.WriteLine("O valor do titulo é: " + SeleniumGetMethods.GetTextFromDDL("TitleId", PropertyType.Id));
            System.Console.WriteLine("O valor do titulo é: " + SeleniumGetMethods.GetText("Initial", PropertyType.Name));

            SeleniumSetMethods.Click("Save", PropertyType.Name);
            //Assert.Pass();
        }

        [TearDown]
        public void CleanUP()
        {
            ProportiesCollection.driver.Quit();
        }
    }
}