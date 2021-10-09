namespace PddOpenSdk.Models.Response.DdkTools;
public partial class BindDdkOauthPidMediaidResponse : PddResponseModel
{

    /// <summary>
    /// response
    /// </summary>
    [JsonPropertyName("p_id_bind_response")]
    public PIdBindResponseResponse PIdBindResponse { get; set; }
    public partial class PIdBindResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 绑定结果
        /// </summary>
        [JsonPropertyName("result")]
        public ResultResponse Result { get; set; }
        public partial class ResultResponse : PddResponseModel
        {

            /// <summary>
            /// 绑定结果信息提示
            /// </summary>
            [JsonPropertyName("msg")]
            public string Msg { get; set; }

            /// <summary>
            /// 绑定结果
            /// </summary>
            [JsonPropertyName("result")]
            public bool? Result { get; set; }

        }

    }

}

