using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeDevolucao.DSL
{
    public class DSLHomeDevolucao : DSLComumATodos
    {
        //public static RemoteWebDriver driveFF;
        public DSLHomeDevolucao(RemoteWebDriver driveFF)
        {
            DSLHomeDevolucao.driveFF = driveFF;
        }
        public static void ClicarNoBtnCircularIndisponivel()
        {
            new PAGE.PAGEHomeDevolucao(driveFF).BtnCircularIndiponivel().Click();
        }
        public static void ClicarNoBtnCircularDevolucao()
        {
            new PAGE.PAGEHomeDevolucao(driveFF).BtnCircularDevolucao().Click();
        }

    }
}
