/*
* This is a personal academic project. Dear PVS-Studio, please check it.
* PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com
*/
using BenchmarkDotNet.Attributes;
using NJsonSchema.NewtonsoftJson.Generation;

namespace NJsonSchema.Benchmark
{
    [MemoryDiagnoser]
    public class JsonSchemaGeneratorBenchmark
    {
        [Benchmark]
        public void GenerateFile()
        {
            NewtonsoftJsonSchemaGenerator.FromType<SchemaGenerationBenchmarks.Container>();
        }
    }
}