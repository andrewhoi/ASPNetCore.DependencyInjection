// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;

namespace Microsoft.Extensions.DependencyInjection.V2.ServiceLookup
{
    internal class ServiceScopeService : IService, IServiceCallSite
    {
        public IService Next { get; set; }

        public ServiceLifetime Lifetime
        {
            get { return ServiceLifetime.Scoped; }
        }

        public Type ServiceType => typeof(IServiceScopeFactory);

        public IServiceCallSite CreateCallSite(ServiceProvider2 provider, ISet<Type> callSiteChain)
        {
            return this;
        }
    }
}