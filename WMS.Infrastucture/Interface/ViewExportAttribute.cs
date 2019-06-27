using System;
using System.ComponentModel;
using System.ComponentModel.Composition;

namespace WMS.Infrastucture.Interface
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    [MetadataAttribute]
    public sealed class ViewExportAttribute : ExportAttribute, IViewRegionRegistration
    {
        public ViewExportAttribute()
            : base(typeof(object))
        { }

        public ViewExportAttribute(string viewName)
            : base(viewName, typeof(object))
        { }

        public string ViewName { get { return base.ContractName; } }
        public string RegionName { get; set; }
        [DefaultValue(false)]
        public bool OnTop { get; set; }
        [DefaultValue("")]
        public string ViewTag { get; set; }
        [DefaultValue("")]
        public string ModuleTag { get; set; }
        [DefaultValue(true)]
        public bool IsNotAdded { get; set; }
    }

}
