﻿// Copyright (c) 2011-2023 Roland Pheasant. All rights reserved.
// Roland Pheasant licenses this file to you under the MIT license.
// See the LICENSE file in the project root for full license information.

namespace System.Runtime.CompilerServices;

// Allows use of the C#11 `required` keyword, internally within this library, when targeting frameworks older than .NET 7.
[AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = false)]
internal sealed class CompilerFeatureRequiredAttribute
    : Attribute
{
    public CompilerFeatureRequiredAttribute(string featureName)
        => FeatureName = featureName;

    public string FeatureName { get; }

    public bool IsOptional { get; init; }

    public const string RefStructs
        = nameof(RefStructs);

    public const string RequiredMembers
        = nameof(RequiredMembers);
}