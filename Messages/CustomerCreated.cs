using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Consumer.Messages
{
    public class CustomerCreated : IMessage
    {
        [JsonPropertyName("id")]
        public int Id { get; init; }

        [JsonPropertyName("fullName")] 
        public string FullName { get; init; } = default!;

        [JsonIgnore] public string MessageTypeName => nameof(CustomerCreated);
    }
}
