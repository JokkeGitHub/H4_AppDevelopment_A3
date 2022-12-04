using System.Text.Json.Serialization;

namespace H4_AppDevelopment_A3
{
    public class KanbanTaskItem
    {
        [JsonPropertyName("name")]
        public string Name { get; init; }
        [JsonPropertyName("status")]
        public string Status { get; set; }

        public KanbanTaskItem(string name, string status)
        {
            Name = name;
            Status = status;
        }
    }
}
