namespace PddOpenSdk.Models.Request.Pmc;
public partial class GetPmcUser
{

    /// <summary>
    /// 用户唯一id
    /// </summary>
    [JsonPropertyName("owner_id")]
    public string OwnerId { get; set; }

}

