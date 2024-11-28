/*
* This is a personal academic project. Dear PVS-Studio, please check it.
* PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com
*/
using NJsonSchema.NewtonsoftJson.Generation;
using Xunit;

namespace NJsonSchema.Tests.Generation
{
    public class ShouldSerializeTests
    {
        public class Test
        {
            public string Name { get; set; }

            public bool ShouldSerializeName()
            {
                return !string.IsNullOrEmpty(Name);
            }
        }

        [Fact]
        public void When_ShouldSerialize_method_exists_then_schema_is_generated()
        {
            // Arrange
            var schema = NewtonsoftJsonSchemaGenerator.FromType<Test>();

            // Act


            // Assert
            Assert.NotNull(schema);
        }
    }
}
