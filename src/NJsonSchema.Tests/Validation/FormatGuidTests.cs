/*
* This is a personal academic project. Dear PVS-Studio, please check it.
* PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com
*/
using Newtonsoft.Json.Linq;
using NJsonSchema.Validation;
using Xunit;

namespace NJsonSchema.Tests.Validation
{
    public class FormatGuidTests
    {
        [Fact]
        public void When_format_guid_incorrect_then_validation_succeeds()
        {
            // Arrange
            var schema = new JsonSchema();
            schema.Type = JsonObjectType.String;
            schema.Format = JsonFormatStrings.Guid;

            var token = new JValue("test");

            // Act
            var errors = schema.Validate(token);

            // Assert
            Assert.Equal(ValidationErrorKind.GuidExpected, errors.First().Kind);
        }

        [Fact]
        public void When_format_guid_correct_then_validation_succeeds()
        {
            // Arrange
            var schema = new JsonSchema();
            schema.Type = JsonObjectType.String;
            schema.Format = JsonFormatStrings.Guid;

            var guid = Guid.NewGuid().ToString(); 
            var token = new JValue(guid);

            // Act
            var errors = schema.Validate(token);

            // Assert
            Assert.Empty(errors);
        }
    }
}