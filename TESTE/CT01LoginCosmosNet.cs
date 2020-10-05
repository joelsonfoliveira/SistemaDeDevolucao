using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;

namespace SistemaDeDevolucao.TESTE
{
    [TestFixture]
    public class CT01LoginCosmosNet
    {
        private IWebDriver driver;
        private string baseURL;

        #region Funcionário
        string matricula = "108674";
        string senha = "teste";
        #endregion

        [SetUp]
        public void SetupTest()
        {
            driver = new FirefoxDriver();
            //driver = new ChromeDriver();
            //driver = new InternetExplorerDriver();
            baseURL = "http://cosmosnethomo.pmenos.com.br/cosmosnet";
        }
        
        [TearDown]
        public void TeardownTest()
        {
            driver.Quit();
        }

        [Test]
        public void CT01RealizarLogin()
        {
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(baseURL);
            driver.FindElement(By.Id("Usuario")).SendKeys(matricula);
            driver.FindElement(By.Id("Senha")).SendKeys(senha);
            driver.FindElement(By.Id("Senha")).SendKeys(Keys.Enter);

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
        }
        /*
        [Test]
        public void CT02NavegarParaSistemaDevolucao()
        {
            driver.Navigate().GoToUrl(baseURL + "/ReactDevolucaoLoja/");


        }
        */
    }
}
