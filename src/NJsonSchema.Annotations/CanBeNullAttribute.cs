﻿/*
* This is a personal academic project. Dear PVS-Studio, please check it.
* PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com
*/
//-----------------------------------------------------------------------
// <copyright file="CanBeNullAttribute.cs" company="NJsonSchema">
//     Copyright (c) Rico Suter. All rights reserved.
// </copyright>
// <license>https://github.com/RicoSuter/NJsonSchema/blob/master/LICENSE.md</license>
// <author>Rico Suter, mail@rsuter.com</author>
//-----------------------------------------------------------------------

namespace NJsonSchema.Annotations;

/// <summary>Indicates that the value of the marked element is nullable.</summary>
[AttributeUsage(
    AttributeTargets.Method |
    AttributeTargets.Parameter |
    AttributeTargets.Property |
    AttributeTargets.ReturnValue |
    AttributeTargets.Delegate |
    AttributeTargets.Field |
    AttributeTargets.Event)]
public class CanBeNullAttribute : Attribute
{
}