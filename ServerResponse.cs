using System;
using System.Text.Json.Serialization;

namespace DockerDemoPoker
{
    public class ServerResponse
    {
        [JsonPropertyName("type")]
        public Uri Type { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("status")]
        public long Status { get; set; }

        [JsonPropertyName("detail")]
        public string Detail { get; set; }

        [JsonPropertyName("traceId")]
        public string TraceId { get; set; }
    }
}
