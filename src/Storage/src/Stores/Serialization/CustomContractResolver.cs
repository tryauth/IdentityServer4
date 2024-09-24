/*
 Copyright (c) 2024 Tech6 Group, Alex Tochetto - https://github.com/tryauth  
 Copyright (c) 2018, Brock Allen & Dominick Baier. All rights reserved.

 Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information. 
 Source code and license this software can be found 

 The above copyright notice and this permission notice shall be included in all
 copies or substantial portions of the Software.
*/

#pragma warning disable 1591

namespace IdentityServer4.Stores.Serialization;

public class CustomContractResolver: DefaultContractResolver
{
    protected override IList<JsonProperty> CreateProperties(Type type, MemberSerialization memberSerialization)
    {
        var props = base.CreateProperties(type, memberSerialization);
        return props.Where(p => p.Writable).ToList();
    }
}
