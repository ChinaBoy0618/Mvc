// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Microsoft.AspNetCore.Mvc.Filters
{
    /// <summary>
    /// A filter that requires a reference back to the <see cref="IFilterFactory"/> that created it.
    /// 一个过滤器必须有一个工厂去创建它（约束）
    /// </summary>
    public interface IFilterContainer
    {
        /// <summary>
        /// The <see cref="IFilterFactory"/> that created this filter instance.
        /// 工厂创建这个实例
        /// </summary>
        IFilterMetadata FilterDefinition { get; set; }
    }
}
