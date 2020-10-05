using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeDevolucao.DSL
{
    public class DSLProdutosEmExcesso : DSLComumATodos
    {
        //public static RemoteWebDriver driveFF;
        public DSLProdutosEmExcesso(RemoteWebDriver driveFF)
        {
            DSLProdutosEmExcesso.driveFF = driveFF;
        }
        public static void ClicarEmExcluirProduto()
        {
            new PAGE.PAGEProdutosEmExcesso(driveFF).BtnExcluirProduto().Click();
        }
        public static void ClicarEmConfirmarExclusaoNoModal()
        {
            new PAGE.PAGEProdutosEmExcesso(driveFF).BtnConfirmarExclusaoNoModal().Click();
        }
        public static void ClicarEmCancelarExclusaoNoModal()
        {
            new PAGE.PAGEProdutosEmExcesso(driveFF).BtnCancelarExclusaoDoModal().Click();
        }
        public static void ClicarEmFecharModal()
        {
            new PAGE.PAGEProdutosEmExcesso(driveFF).BtnFecharOModal().Click();
        }
    }
}
