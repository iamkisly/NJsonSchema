/*
* This is a personal academic project. Dear PVS-Studio, please check it.
* PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com
*/
//-----------------------------------------------------------------------
// <copyright file="DefaultEnumNameGenerator.cs" company="NJsonSchema">
//     Copyright (c) Rico Suter. All rights reserved.
// </copyright>
// <license>https://github.com/RicoSuter/NJsonSchema/blob/master/LICENSE.md</license>
// <author>Rico Suter, mail@rsuter.com</author>
//-----------------------------------------------------------------------

using System.Text.RegularExpressions;

namespace NJsonSchema.CodeGeneration
{
    /// <summary>The default enumeration name generator.</summary>
    public class DefaultEnumNameGenerator : IEnumNameGenerator
    {
        private static readonly Regex _invalidNameCharactersPattern = new Regex(@"[^\p{Lu}\p{Ll}\p{Lt}\p{Lm}\p{Lo}\p{Nl}\p{Mn}\p{Mc}\p{Nd}\p{Pc}\p{Cf}]");

        /// <summary>Generates the enumeration name/key of the given enumeration entry.</summary>
        /// <param name="index">The index of the enumeration value (check <see cref="JsonSchema.Enumeration" /> and <see cref="JsonSchema.EnumerationNames" />).</param>
        /// <param name="name">The name/key.</param>
        /// <param name="value">The value.</param>
        /// <param name="schema">The schema.</param>
        /// <returns>The enumeration name.</returns>
        public string Generate(int index, string? name, object? value, JsonSchema schema)
        {
            if (string.IsNullOrEmpty(name))
            {
                return "Empty";
            }

            name = name switch
            {
                "=" => "Eq",
                "!=" => "Ne",
                ">" => "Gt",
                "<" => "Lt",
                ">=" => "Ge",
                "<=" => "Le",
                "~=" => "Approx",
                _ => name
            };

#pragma warning disable CS8604 // Possible null reference argument.
            if (name.StartsWith('-'))
#pragma warning restore CS8604 // Possible null reference argument.
            {
                name = string.Concat("Minus", name.AsSpan(1));
            }

            if (name.StartsWith('+'))
            {
                name = string.Concat("Plus", name.AsSpan(1));
            }

            if (name.StartsWith("_-", StringComparison.Ordinal))
            {
                name = string.Concat("__", name.AsSpan(2));
            }

            return _invalidNameCharactersPattern.Replace(ConversionUtilities.ConvertToUpperCamelCase(name
                .Replace(":", "-").Replace(@"""", ""), firstCharacterMustBeAlpha: true), "_");
        }
    }
}
