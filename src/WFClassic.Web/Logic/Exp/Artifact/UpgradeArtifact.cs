using System.Text.Json.Serialization;

namespace WFClassic.Web.Logic.Exp.Artifact
{
    public class UpgradeArtifact
    {
        public Guid AccountId { get; set; }
        public long Nonce { get; set; }

        public IncomingUpgradeArtifactRequest IncomingUpgradeArtifactRequest { get; set; }
    }

    public class IncomingUpgradeArtifactRequest
    {
        public Upgrade Upgrade { get; set; }
        public string Fingerprint { get; set; }
        public Consumed[] Consumed { get; set; }
        public int Cost { get; set; }
    }

    public class Upgrade
    {
        public string ItemType { get; set; }
        public Itemid ItemId { get; set; }
        public string UpgradeFingerprint { get; set; }
        public int Slot { get; set; }
        public Itemid ParentId { get; set; }
    }

    public class Itemid
    {
        [JsonPropertyName("$id")]
        public string id { get; set; }
    }

    public class Consumed
    {
        public string ItemType { get; set; }
        public Itemid ItemId { get; set; }
        public string UpgradeFingerprint { get; set; }
        public int Slot { get; set; }
        public Itemid ParentId { get; set; }
    }
}