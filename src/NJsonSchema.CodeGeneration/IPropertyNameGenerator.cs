/*
* This is a personal academic project. Dear PVS-Studio, please check it.
* PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com
*/
//-----------------------------------------------------------------------
// <copyright file="IPropertyNameGenerator.cs" company="NJsonSchema">
//     Copyright (c) Rico Suter. All rights reserved.
// </copyright>
// <license>https://github.com/RicoSuter/NJsonSchema/blob/master/LICENSE.md</license>
// <author>Rico Suter, mail@rsuter.com</author>
//-----------------------------------------------------------------------

namespace NJsonSchema.CodeGeneration
{
    /// <summary>Generates the property name for a given <see cref="JsonSchemaProperty"/>.</summary>
    public interface IPropertyNameGenerator
    {
        /// <summary>Generates the property name.</summary>
        /// <param name="property">The property.</param>
        /// <returns>The new name.</returns>
        string Generate(JsonSchemaProperty property);
    }
}