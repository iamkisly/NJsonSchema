/*
* This is a personal academic project. Dear PVS-Studio, please check it.
* PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com
*/
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using NJsonSchema.Annotations;

namespace NJsonSchema.CodeGeneration.TypeScript.Tests.Models
{
    public class Person
    {
        [Required]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }
        
        [ReadOnly(true)]
        public DateTime Birthday { get; set; }

        public TimeSpan TimeSpan { get; set; }

        public TimeSpan? TimeSpanOrNull { get; set; }

        public Gender Gender { get; set; }

        public Gender? GenderOrNull { get; set; }

        [JsonProperty("address", Required = Required.Always)]
        public Address Address { get; set; }

        [CanBeNull]
        public Address AddressOrNull { get; set; }

        public List<string> Array { get; set; } 

        public Dictionary<string, int> Dictionary { get; set; }
    }
}