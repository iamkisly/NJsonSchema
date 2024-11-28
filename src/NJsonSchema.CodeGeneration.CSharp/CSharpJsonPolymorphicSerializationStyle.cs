/*
* This is a personal academic project. Dear PVS-Studio, please check it.
* PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com
*/
namespace NJsonSchema.CodeGeneration.CSharp
{
    /// <summary>The CSharp JSON polymorphic serialization style.</summary>
    public enum CSharpJsonPolymorphicSerializationStyle
    {
        /// <summary>Use NJsonSchema polymorphic serialization</summary>
        NJsonSchema, 

        /// <summary>Use System.Text.Json polymorphic serialization</summary>
        SystemTextJson
    }
}