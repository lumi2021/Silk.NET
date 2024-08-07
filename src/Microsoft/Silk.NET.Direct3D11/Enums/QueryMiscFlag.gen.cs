// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_QUERY_MISC_FLAG")]
    public enum QueryMiscFlag : int
    {
        [Obsolete("Deprecated in favour of \"Predicatehint\"")]
        [NativeName("Name", "D3D11_QUERY_MISC_PREDICATEHINT")]
        QueryMiscPredicatehint = 0x1,
        [NativeName("Name", "D3D11_QUERY_MISC_PREDICATEHINT")]
        Predicatehint = 0x1,
    }
}
