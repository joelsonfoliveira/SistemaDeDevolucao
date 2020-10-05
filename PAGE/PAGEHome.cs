using OpenQA.Selenium.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using SistemaDeDevolucao.DSL;

namespace SistemaDeDevolucao.PAGE
{
    public class PAGEHome : DSLComumATodos
    {
        public PAGEHome(RemoteWebDriver driverFF) : base(driverFF)
        {
            this.NovodriverFF = driverFF;
        }

    }
}
