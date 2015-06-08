// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Microsoft.AspNet.Antiforgery
{
    // Abstracts out the serialization process for an anti-forgery token
    public interface IAntiforgeryTokenSerializer
    {
        AntiforgeryToken Deserialize(string serializedToken);
        string Serialize(AntiforgeryToken token);
    }
}