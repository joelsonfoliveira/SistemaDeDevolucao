using NUnit.Framework;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SistemaDeDevolucao.TESTE
{
    [TestFixture]
    public class CT02CancelarExclusaoUsandoClique
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
        public void CancelarExclusaoProdutos()
        {
            DSL.DSLProdutosEmExcesso.driveFF = driverFF;
            driver.IrParaURL(urlConsultarExcesso);

            Thread.Sleep(3000);

            DSL.DSLProdutosEmExcesso.ClicarEmExcluirProduto();
            DSL.DSLProdutosEmExcesso.ClicarEmCancelarExclusaoNoModal();
        }

        [TearDown]
        public void FecharNavegador()
        {
            driverFF.Dispose();
            driverFF.Quit();
        }
    }
}
