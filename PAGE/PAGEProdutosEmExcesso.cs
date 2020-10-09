using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeDevolucao.PAGE
{
    public class PAGEProdutosEmExcesso : PageComumATodos
    {
        public PAGEProdutosEmExcesso(RemoteWebDriver driveFF) : base(driveFF)
        {
            this.NovodriveFF = driveFF;
        }
        public IWebElement BtnExcluirProduto()
        {
           return NovodriveFF.FindElement(By.CssSelector("tr:nth-child(1) path"));
        }
        public IWebElement BtnConfirmarExclusaoNoModal()
        {
            return NovodriveFF.FindElementByCssSelector(".swal2-confirm");
        }
        public IWebElement BtnCancelarExclusaoDoModal()
        {
            return NovodriveFF.FindElementByCssSelector(".swal2-cancel");
        }
        public IWebElement BtnFecharOModal()
        {
            return NovodriveFF.FindElementByCssSelector(".swal2-close");
        }
        public IWebElement BtnESC()
        {
            return NovodriveFF.FindElementByCssSelector(".swal2-confirm");
        }
    }
}
