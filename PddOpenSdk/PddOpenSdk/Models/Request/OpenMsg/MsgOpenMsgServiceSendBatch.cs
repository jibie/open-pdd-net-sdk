namespace PddOpenSdk.Models.Request.OpenMsg;
public partial class MsgOpenMsgServiceSendBatch
{

    /// <summary>
    /// 业务请求唯一标识
    /// </summary>
    [JsonPropertyName("out_id")]
    public string OutId { get; set; }

    /// <summary>
    /// 接收短信的手机号码列表（仅允许密文）,["密文1", "密文2"]
    /// </summary>
    [JsonPropertyName("phone_numbers")]
    public List<string> PhoneNumbers { get; set; }

    /// <summary>
    /// 短信签名名称
    /// </summary>
    [JsonPropertyName("sign_name")]
    public string SignName { get; set; }

    /// <summary>
    /// 上行短信扩展码
    /// </summary>
    [JsonPropertyName("sms_up_extend_code")]
    public string SmsUpExtendCode { get; set; }

    /// <summary>
    /// 短信模板CODE
    /// </summary>
    [JsonPropertyName("template_code")]
    public long TemplateCode { get; set; }

    /// <summary>
    /// 短信模板变量JSON集合(与手机号对应)
    /// </summary>
    [JsonPropertyName("template_param_json")]
    public List<Dictionary<string, object>> TemplateParamJson { get; set; }
    public partial class TemplateParamJsonModel
    {

        /// <summary>
        /// 模板变量名
        /// </summary>
        [JsonPropertyName("$key")]
        public string Key { get; set; }

        /// <summary>
        /// 模板变量值
        /// </summary>
        [JsonPropertyName("$value")]
        public string Value { get; set; }

    }

}

