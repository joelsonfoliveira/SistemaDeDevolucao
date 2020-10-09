using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeDevolucao.DSL
{
    public class DSLProdutosEmExcesso : DSLComumATodos
    {
        public DSLProdutosEmExcesso(RemoteWebDriver driveFF)
        {
            DSLProdutosEmExcesso.driveFF = driveFF;
        }
        public static void ClicarEmExcluirProduto()
        {
            new PAGE.PAGEProdutosEmExcesso(driveFF).BtnExcluirProduto().Click();
            Console.WriteLine("Botão excluir clicado");
        }
        public static void ClicarEmConfirmarExclusaoNoModal()
        {
            new PAGE.PAGEProdutosEmExcesso(driveFF).BtnConfirmarExclusaoNoModal().Click();
            Console.WriteLine("Botão confirmar exclusão clicado");
        }
        public static void ClicarEmCancelarExclusaoNoModal()
        {
            new PAGE.PAGEProdutosEmExcesso(driveFF).BtnCancelarExclusaoDoModal().Click();
        }
        public static void ClicarEmFecharModal()
        {
            new PAGE.PAGEProdutosEmExcesso(driveFF).BtnFecharOModal().Click();
        }
        public static void ApertarESCParaFecharModal()
        {
            new PAGE.PAGEProdutosEmExcesso(driveFF).BtnESC().SendKeys(Keys.Escape);
        }
        public static void EsperarBtnExcluirFicarVisivel()
        {
            DSLComumATodos.EsperaImplicita(driveFF, new PAGE.PAGEProdutosEmExcesso(driveFF).BtnExcluirProduto(), 12000);
            bool isBtnClicavel = new PAGE.PAGEProdutosEmExcesso(driveFF).BtnExcluirProduto().Displayed;
            Console.WriteLine(isBtnClicavel);
            Console.WriteLine("Botão confirmar exclusão clicado");
            Assert.IsTrue(isBtnClicavel);
            Assert.IsNotNull(isBtnClicavel);
        }
    }
}
