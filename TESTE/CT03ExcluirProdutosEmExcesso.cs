using OpenQA.Selenium.Remote;
using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SistemaDeDevolucao.DSL;
using System.Threading;

namespace SistemaDeDevolucao.TESTE
{
    [TestFixture]
    public class CT03ExcluirProdutosEmExcesso
    {
        static DSL.DSLComumATodos driver = new DSL.DSLComumATodos();
        RemoteWebDriver driverFF = driver.IrParaCosmosNet();

        #region Funcionario
        string matricula = "108674";
        string senha = "teste";
        #endregion

        #region URL
        string urlConsultarExcesso = "http://cosmosnethomo.pmenos.com.br/ReactDevolucaoLoja/#/ConsultarExcesso";
        #endregion

        [SetUp]
        public void Setup()
        {
            DSL.DSLLoginCosmosNet.driveFF = driverFF;
            DSL.DSLLoginCosmosNet.Logar(matricula, senha);
        }

        [Test]
        public void ExcluirProdutos()
        {
            DSL.DSLProdutosEmExcesso.driveFF = driverFF;
            driver.IrParaURL(urlConsultarExcesso);

            Thread.Sleep(3000);

            //DSL.DSLProdutosEmExcesso.C
            //for (int i=0; i<3; i++)
            //{
            DSL.DSLProdutosEmExcesso.ClicarEmExcluirProduto();
            DSL.DSLProdutosEmExcesso.ClicarEmConfirmarExclusaoNoModal();

            DSL.DSLProdutosEmExcesso.EsperarBtnExcluirFicarVisivel();

            DSL.DSLProdutosEmExcesso.ClicarEmExcluirProduto();
            DSL.DSLProdutosEmExcesso.ClicarEmConfirmarExclusaoNoModal();
            //}
        }

        [TearDown]
        public void FecharNavegador()
        {
            //driverFF.Dispose();
            //driverFF.Quit();
        }
    }
}
