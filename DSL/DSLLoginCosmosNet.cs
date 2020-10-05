using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeDevolucao.DSL
{
    public class DSLLoginCosmosNet
    {
        public static RemoteWebDriver driveFF;
        public DSLLoginCosmosNet(RemoteWebDriver driveFF)
        {
            DSLLoginCosmosNet.driveFF = driveFF;
        }
        public static void PreencherMatricula(string matricula)
        {
            new PAGE.PAGELoginCosmosNet(driveFF).CampoMatricula().SendKeys(matricula);
        }
        public static void PreencherSenha(string senha)
        {
            new PAGE.PAGELoginCosmosNet(driveFF).CampoSenha().SendKeys(senha);
        }
        public static void ClicarEmEntrar()
        {
            new PAGE.PAGELoginCosmosNet(driveFF).BtnEntrar().Click();
        }
        public static void Logar(string matricula, string senha)
        {
            PreencherMatricula(matricula);
            PreencherSenha(senha);
            ClicarEmEntrar();
        }
    }
}
