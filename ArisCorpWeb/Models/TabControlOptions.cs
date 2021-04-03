using System;
using DevExpress.Web.ASPxTabControl;

namespace DevExpress.Web.Demos
{
    public class TabControlFeaturesDemoOptions
    {
        public TabControlFeaturesDemoOptions()
        {
            ActivateTabPageAction = ActivateTabPageAction.Click;
            EnableHotTrack = true;
            SaveStateToCookies = true;
            TabAlign = TabAlign.Left;
            TabPosition = TabPosition.Top;
        }

        public ActivateTabPageAction ActivateTabPageAction { get; set; }
        public bool EnableHotTrack { get; set; }
        public bool SaveStateToCookies { get; set; }
        public TabAlign TabAlign { get; set; }
        public TabPosition TabPosition { get; set; }
    }
}
