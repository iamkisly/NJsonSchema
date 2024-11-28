/*
* This is a personal academic project. Dear PVS-Studio, please check it.
* PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com
*/
using BenchmarkDotNet.Attributes;
using NJsonSchema.CodeGeneration.TypeScript;

namespace NJsonSchema.Benchmark
{
    [MemoryDiagnoser]
    public class TypeScriptGeneratorBenchmark
    {
        private string _json;
        private JsonSchema _schema;
        
        [GlobalSetup]
        public async Task Setup()
        {
            _json = await JsonSchemaBenchmark.ReadJson();
            _schema = await JsonSchema.FromJsonAsync(_json);
        }
        
        [Benchmark]
        public void GenerateFile()
        {
            var generator = new TypeScriptGenerator(_schema, new TypeScriptGeneratorSettings());
            generator.GenerateFile();
        }
    }
}