using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeDevolucao.PAGE
{
    public class PAGELoginCosmosNet : PageComumATodos
    {
        public PAGELoginCosmosNet(RemoteWebDriver driveFF) : base(driveFF)
        {
            this.NovodriveFF = driveFF;
        }
        public IWebElement CampoMatricula() {
            return NovodriveFF.FindElement(By.Id("Usuario"));
        }
        public IWebElement CampoSenha() {
            return NovodriveFF.FindElement(By.Id("Senha"));
        }
        public IWebElement BtnEntrar() {
            return NovodriveFF.FindElement(By.CssSelector(".btAzul"));
        }
        public IWebElement LblUsuario() {
            return NovodriveFF.FindElement(By.CssSelector(".content-wrapper > form:nth-child(4) > fieldset:nth-child(1) > div:nth-child(1) > label:nth-child(1)"));
        }
        public IWebElement LblSenha() {
            return NovodriveFF.FindElement(By.CssSelector(".content-wrapper > form:nth-child(4) > fieldset:nth-child(1) > div:nth-child(1) > label:nth-child(5)"));
        }
    }
}
