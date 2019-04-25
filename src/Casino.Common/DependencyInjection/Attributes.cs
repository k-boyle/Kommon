﻿using System;

namespace Casino.Common.DependencyInjection
{
    /// <inheritdoc />
    /// <summary>
    /// Fields marked with this attribute will have their value automatically assigned when the class
    /// inherits <see cref="T:Casino.Common.DependencyInjection.BaseService`1" /> or when Inject is called.
    /// </summary>
    [AttributeUsage(AttributeTargets.Field)]
    public sealed class InjectAttribute : Attribute
    {
    }
}