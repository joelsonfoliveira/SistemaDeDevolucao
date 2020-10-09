using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeDevolucao.PAGE
{
    public class PageComumATodos
    {
        public RemoteWebDriver NovodriveFF;
        public PageComumATodos(RemoteWebDriver driveFF)
        {
            this.NovodriveFF = driveFF;
        }
        
    }
}
