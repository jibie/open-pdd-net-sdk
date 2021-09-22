using Newtonsoft.Json;
using System.Collections.Generic;
namespace PddOpenSdk.Models.Request.Ddk
{
    public partial class GenerateDdkRpPromUrlRequestModel : PddRequestModel
    {
        /// <summary>
        /// 初始金额（单位分），有效金额枚举值：300、500、700、1100和1600，默认300
        /// </summary>
        [JsonProperty("amount")]
        public long? Amount { get; set; }
        /// <summary>
        /// 营销工具类型，必填：-1-活动列表，0-红包(需申请推广权限)，2–新人红包，3-刮刮卡，5-员工内购，6-购物车，10-生成绑定备案链接，12-砸金蛋，13-一元购C端页面，14-千万补贴B端页面，15-充值中心B端页面，16-千万补贴C端页面，17-千万补贴投票页面，18-一元购B端页面，19-多多品牌星选B端页面，20-多多品牌星选C端页面；红包推广权限申请流程链接：https://jinbao.pinduoduo.com/qa-system?questionId=289
        /// </summary>
        [JsonProperty("channel_type")]
        public int? ChannelType { get; set; }
        /// <summary>
        /// 自定义参数，为链接打上自定义标签；自定义参数最长限制64个字节；格式为：  {"uid":"11111","sid":"22222"} ，其中 uid 用户唯一标识，可自行加密后传入，每个用户仅且对应一个标识，必填； sid 上下文信息标识，例如sessionId等，非必填。该json字符串中也可以加入其他自定义的key。（如果使用GET请求，请使用URLEncode处理参数）
        /// </summary>
        [JsonProperty("custom_parameters")]
        public string CustomParameters { get; set; }
        /// <summary>
        /// 一元购自定义参数，json格式，例如:{"goods_sign":"Y9b2_0uSWMFPGSaVwvfZAlm_y2ADLWZl_JQ7UYaS80K"}
        /// </summary>
        [JsonProperty("diy_one_yuan_param")]
        public DiyOneYuanParamRequestModel DiyOneYuanParam { get; set; }
        /// <summary>
        /// 红包自定义参数，json格式
        /// </summary>
        [JsonProperty("diy_red_packet_param")]
        public DiyRedPacketParamRequestModel DiyRedPacketParam { get; set; }
        /// <summary>
        /// 是否生成qq小程序
        /// </summary>
        [JsonProperty("generate_qq_app")]
        public bool? GenerateQqApp { get; set; }
        /// <summary>
        /// 是否返回 schema URL
        /// </summary>
        [JsonProperty("generate_schema_url")]
        public bool? GenerateSchemaUrl { get; set; }
        /// <summary>
        /// 是否生成短链接。true-是，false-否，默认false
        /// </summary>
        [JsonProperty("generate_short_url")]
        public bool? GenerateShortUrl { get; set; }
        /// <summary>
        /// 是否生成拼多多福利券微信小程序推广信息
        /// </summary>
        [JsonProperty("generate_we_app")]
        public bool? GenerateWeApp { get; set; }
        /// <summary>
        /// 推广位列表，例如：["60005_612"]
        /// </summary>
        [JsonProperty("p_id_list")]
        public List<string> PIdList { get; set; }
        /// <summary>
        /// 刮刮卡指定金额（单位分），可指定2-100元间数值，即有效区间为：[200,10000]
        /// </summary>
        [JsonProperty("scratch_card_amount")]
        public long? ScratchCardAmount { get; set; }
        public partial class DiyOneYuanParamRequestModel : PddRequestModel
        {
            /// <summary>
            /// 商品goodsSign，支持通过goodsSign查询商品。goodsSign是加密后的goodsId, goodsId已下线，请使用goodsSign来替代。使用说明：https://jinbao.pinduoduo.com/qa-system?questionId=252
            /// </summary>
            [JsonProperty("goods_sign")]
            public string GoodsSign { get; set; }

        }
        public partial class DiyRedPacketParamRequestModel : PddRequestModel
        {
            /// <summary>
            /// 红包金额列表，200、300、500、1000、2000，单位分。红包金额和红包抵后价设置只能二选一，默认设置了红包金额会忽略红包抵后价设置
            /// </summary>
            [JsonProperty("amount_probability")]
            public List<long?> AmountProbability { get; set; }
            /// <summary>
            /// 设置玩法，false-现金红包, true-现金券
            /// </summary>
            [JsonProperty("dis_text")]
            public bool? DisText { get; set; }
            /// <summary>
            /// 推广页设置，false-红包开启页, true-红包领取页
            /// </summary>
            [JsonProperty("not_show_background")]
            public bool? NotShowBackground { get; set; }
            /// <summary>
            /// 优先展示类目
            /// </summary>
            [JsonProperty("opt_id")]
            public int? OptId { get; set; }
            /// <summary>
            /// 自定义红包抵后价和商品佣金区间对象数组
            /// </summary>
            [JsonProperty("range_items")]
            public List<RangeItemsRequestModel> RangeItems { get; set; }
            public partial class RangeItemsRequestModel : PddRequestModel
            {
                /// <summary>
                /// 区间的开始值
                /// </summary>
                [JsonProperty("range_from")]
                public long? RangeFrom { get; set; }
                /// <summary>
                /// range_id为1表示红包抵后价（单位分）， range_id为2表示佣金比例（单位千分之几)
                /// </summary>
                [JsonProperty("range_id")]
                public int? RangeId { get; set; }
                /// <summary>
                /// 区间的结束值
                /// </summary>
                [JsonProperty("range_to")]
                public long? RangeTo { get; set; }

            }

        }

    }

}
