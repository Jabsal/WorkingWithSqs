using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Consumer.Messages
{
    public class CustomerDeleted : IMessage
    {
        [JsonPropertyName("id")]
        public int Id { get; init; }

        [JsonIgnore] public string MessageTypeName => nameof(CustomerDeleted);
    }
}
