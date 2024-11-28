/*
* This is a personal academic project. Dear PVS-Studio, please check it.
* PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com
*/
namespace NJsonSchema.CodeGeneration.Tests;

public class ApiSurfaceGuard
{
    private abstract class TypeResolverBaseApiGuard : TypeResolverBase
    {
        protected TypeResolverBaseApiGuard(CodeGeneratorSettingsBase settings) : base(settings)
        {
        }

        // dummy implementation making sure this method stays overridable
        public override string GetOrGenerateTypeName(JsonSchema schema, string typeNameHint)
        {
            throw new System.NotImplementedException();
        }

        // dummy implementation making sure this method stays overridable
        public override JsonSchema RemoveNullability(JsonSchema schema)
        {
            throw new System.NotImplementedException();
        }
    }
}