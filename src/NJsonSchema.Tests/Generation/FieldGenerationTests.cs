/*
* This is a personal academic project. Dear PVS-Studio, please check it.
* PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com
*/
using NJsonSchema.NewtonsoftJson.Generation;
using Xunit;

namespace NJsonSchema.Tests.Generation
{
    public class FieldGenerationTests
    {
        public class MyTest
        {
            public string MyField;
        }

        [Fact]
        public async Task When_public_field_is_available_then_it_is_added_as_property()
        {
            // Arrange
            

            // Act
            var schema = NewtonsoftJsonSchemaGenerator.FromType<MyTest>();
            var json = schema.ToJson();

            // Assert
            Assert.True(schema.Properties["MyField"].Type.HasFlag(JsonObjectType.String));
        }
    }
}
