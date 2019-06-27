using WMS.Infrastucture.Interface;
using Microsoft.Practices.Prism.Regions;
using System;
using System.ComponentModel.Composition;

namespace WMS.Infrastucture.Behaviors
{
    [Export(typeof(AutoPopulateExportedViewsBehavior))]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public class AutoPopulateExportedViewsBehavior : RegionBehavior, IPartImportsSatisfiedNotification
    {
        public void OnImportsSatisfied()
        {
            AddRegisteredViews();
        }
        protected override void OnAttach()
        {
            AddRegisteredViews();
        }
        private void AddRegisteredViews()
        {
            if (this.Region != null)
            {
                if (this.Region.Name == RegionType.TabPageRegion)
                {
                    return;
                }

                foreach (var viewEntry in this.RegisteredViews)
                {
                    if (viewEntry.Metadata.IsNotAdded)
                    {
                        continue;
                    }
                    if (viewEntry.Metadata.RegionName == this.Region.Name)
                    {
                        try
                        {
                            if (viewEntry.Value == null)
                            {
                                continue;
                            }
                        }
                        catch (Exception)
                        {
                            continue;
                        }

                        var view = viewEntry.Value;

                        if (!this.Region.Views.Contains(view))
                        {
                            this.Region.Add(view);
                            if (viewEntry.Metadata.OnTop)
                            {
                                this.Region.Activate(viewEntry.Value);
                            }
                            else
                            {
                                this.Region.Deactivate(viewEntry.Value);
                            }
                        }
                    }

                }
            }
        }
        [ImportMany(AllowRecomposition = true)]
        public Lazy<object, IViewRegionRegistration>[] RegisteredViews { get; set; }

    }
}
