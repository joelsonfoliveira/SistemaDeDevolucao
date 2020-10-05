using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.PageObjects;
using SistemaDeDevolucao.DSL;

namespace SistemaDeDevolucao.PAGE
{
    public class PAGEHomeDevolucao : PageComumATodos
    {
        public PAGEHomeDevolucao(RemoteWebDriver driveFF) : base(driveFF)
        {
            this.NovodriveFF = driveFF;
        }
        public IWebElement BtnCircularIndiponivel()
        {
            return NovodriveFF.FindElement(By.CssSelector("div.col-sm-12:nth-child(2) > div:nth-child(1) > div:nth-child(1) > div:nth-child(2) > h2:nth-child(2)"));
        }
        public IWebElement BtnCircularDevolucao()
        {
            return NovodriveFF.FindElement(By.CssSelector("div.col-sm-12:nth-child(3) > div:nth-child(1) > div:nth-child(1) > div:nth-child(2) > h2:nth-child(2)"));
        }
    }
}
