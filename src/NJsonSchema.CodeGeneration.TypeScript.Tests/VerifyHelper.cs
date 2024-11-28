/*
* This is a personal academic project. Dear PVS-Studio, please check it.
* PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com
*/
namespace NJsonSchema.CodeGeneration.TypeScript.Tests;

public static class VerifyHelper
{
    /// <summary>
    /// Helper to run verify tests with sane defaults.
    /// </summary>
    public static SettingsTask Verify(string output)
    {
        return Verifier
            .Verify(output)
            .ScrubLinesContaining(StringComparison.OrdinalIgnoreCase, "Generated using the NSwag toolchain")
            .UseDirectory("Snapshots");
    }
}