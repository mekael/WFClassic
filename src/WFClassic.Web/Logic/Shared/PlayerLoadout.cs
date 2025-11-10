using System.Text.Json.Serialization;

namespace WFClassic.Web.Logic.Shared;



public class PlayerLoadout
{
    [JsonPropertyName("ItemId")]
    public ItemId ItemId { get; set; }
    [JsonPropertyName("Name")]
    public string Name { get; set; }
    [JsonPropertyName("Presets")]
    public Preset[] Presets { get; set; }
}

public class ItemId
{
    [JsonPropertyName("$id")]
    public string id { get; set; }
}

public class Preset
{
    [JsonPropertyName("ItemId")]
    public ItemId ItemId { get; set; }
    [JsonPropertyName("Customization")]
    public Customization Customization { get; set; }
}

public class Customization
{
    [JsonPropertyName("Emblem")]
    public string Emblem { get; set; }
    [JsonPropertyName("Colors")]
    public int[] Colors { get; set; }
    [JsonPropertyName("Skins")]
    public string[] Skins { get; set; }
}
