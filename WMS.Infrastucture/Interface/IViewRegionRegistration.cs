using System;

namespace WMS.Infrastucture.Interface
{
    public interface IViewRegionRegistration
    {
        /// <summary>
        /// 区域名称
        /// </summary>
        string RegionName { get; }
        /// <summary>
        /// 视图名称
        /// </summary>
        string ViewTag { get; }
        /// <summary>
        /// 模块名称 
        /// </summary>
        string ModuleTag { get; }
        /// <summary>
        /// 视图置顶
        /// </summary>
        bool OnTop { get; }
        /// <summary>
        /// 自动添加视图
        /// </summary>
        bool IsNotAdded { get; }
    }
}
