/*
* This is a personal academic project. Dear PVS-Studio, please check it.
* PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com
*/
//-----------------------------------------------------------------------
// <copyright file="CodeArtifactLanguage.cs" company="NJsonSchema">
//     Copyright (c) Rico Suter. All rights reserved.
// </copyright>
// <license>https://github.com/RicoSuter/NJsonSchema/blob/master/LICENSE.md</license>
// <author>Rico Suter, mail@rsuter.com</author>
//-----------------------------------------------------------------------

namespace NJsonSchema.CodeGeneration
{
    /// <summary>The code artifact type.</summary>
    public enum CodeArtifactLanguage
    {
        /// <summary>Undefined.</summary>
        Undefined,

        /// <summary>C#.</summary>
        CSharp,

        /// <summary>TypeScript.</summary>
        TypeScript,

        /// <summary>Html.</summary>
        Html
    }
}