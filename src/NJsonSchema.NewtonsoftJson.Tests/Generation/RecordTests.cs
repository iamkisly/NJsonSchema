/*
* This is a personal academic project. Dear PVS-Studio, please check it.
* PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com
*/
using NJsonSchema.NewtonsoftJson.Generation;
using Xunit;

namespace NJsonSchema.NewtonsoftJson.Tests.Generation
{
    public class RecordTests
    {
        public record Address
        {
            public string Street { get; set; }
        }

        [Fact]
        public void Should_have_only_one_property()
        {
            // Arrange

            // Act
            var schema = NewtonsoftJsonSchemaGenerator.FromType<Address>();
            var data = schema.ToJson();

            // Assert
            Assert.Single(schema.Properties);
        }
    }
}