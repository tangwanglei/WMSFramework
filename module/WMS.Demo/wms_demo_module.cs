using Microsoft.Practices.Prism.MefExtensions.Modularity;
using Microsoft.Practices.Prism.Modularity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WMS.Demo
{
    [ModuleExport("wms_demo_module", typeof(wms_demo_module), InitializationMode = InitializationMode.WhenAvailable)]

    class wms_demo_module : IModule
    {
        public void Initialize()
        {

        }
    }
}
