using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Firefox;
using System.Threading;
using OpenQA.Selenium.Support.UI;
using System;
using OpenQA.Selenium;

namespace SistemaDeDevolucao.DSL
{
    public class DSLComumATodos
    {
        #region URL
        string urlCosmosNet = "http://cosmosnethomo.pmenos.com.br/cosmosnet";
        #endregion

        public static RemoteWebDriver driveFF;
        public RemoteWebDriver IrParaCosmosNet()
        {
            driveFF = new FirefoxDriver();
            driveFF.Navigate().GoToUrl(urlCosmosNet);
            //Thread.Sleep(6000);
            return driveFF;
        }
        public RemoteWebDriver IrParaURL(string url)
        {
            //Thread.Sleep(6000);
            driveFF.Navigate().GoToUrl(url);
            return driveFF;
        }
        public static void EsperaImplicita(RemoteWebDriver drive, IWebElement elemento, int tempoMax)
        {
            WebDriverWait wait = new WebDriverWait(drive, TimeSpan.FromSeconds(tempoMax));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(elemento));
        }
    }
}
