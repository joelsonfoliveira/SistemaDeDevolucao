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
    public class CT01ExcluirProdutosEmExcesso
    {
        static DSL.DSLComumATodos driver = new DSL.DSLComumATodos();
        RemoteWebDriver driverFF = driver.IrParaCosmosNet();
         xasdas
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
            //DSL.DSLLoginCosmosNet.driveFF = driverFF;
        }

        [Test]
        public void ExcluirProdutos()
        {
            DSL.DSLHomeDevolucao.driveFF = driverFF;
            driver.IrParaURL(urlConsultarExcesso);

            Thread.Sleep(3000);

            //DSL.DSLProdutosEmExcesso.ClicarEmExcluirProduto();
            //DSL.DSLProdutosEmExcesso.ClicarEmCancelarExclusaoNoModal();

            //DSL.DSLProdutosEmExcesso.ClicarEmExcluirProduto();
            //DSL.DSLProdutosEmExcesso.ClicarEmFecharModal();

            //for (int i=0; i<3; i++)
            //{
                DSL.DSLProdutosEmExcesso.ClicarEmExcluirProduto();
                DSL.DSLProdutosEmExcesso.ClicarEmConfirmarExclusaoNoModal();
                //esperaimplicita
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
