using System.Text.Json.Serialization;

namespace H4_AppDevelopment_A3
{
    public class KanbanSection
    {
        [JsonPropertyName("name")]
        public string Name { get; init; }
        [JsonPropertyName("newTaskOpen")]
        public bool NewTaskOpen { get; set; }
        [JsonPropertyName("newTaskName")]
        public string NewTaskName { get; set; }

        public KanbanSection(string name, bool newTaskOpen, string newTaskName)
        {
            Name = name;
            NewTaskOpen = newTaskOpen;
            NewTaskName = newTaskName;
        }
    }
}
