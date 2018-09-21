using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class UpdateAdKeywordResponseModel : PddResponseModel
    {
        /// <summary>
/// 返回response
/// </summary>
[JsonProperty("ad_keyword_update_response")]
public AdKeywordUpdateResponseResponseModel AdKeywordUpdateResponse {get;set;}

    public partial class AdKeywordUpdateResponseResponseModel : PddResponseModel
    {
        /// <summary>
/// 是否成功
/// </summary>
[JsonProperty("is_success")]
public object IsSuccess {get;set;}

}

}
}
