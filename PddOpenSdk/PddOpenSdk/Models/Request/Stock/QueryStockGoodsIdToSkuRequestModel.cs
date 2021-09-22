using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Stock
{
    public partial class QueryStockGoodsIdToSkuRequestModel : PddRequestModel
    {
        /// <summary>
        /// 商品id
        /// </summary>
        [JsonProperty("goods_id")]
        public long GoodsId { get; set; }
        /// <summary>
        /// 是否需要查询下架商品和sku，默认不需要
        /// </summary>
        [JsonProperty("need_offsale")]
        public bool? NeedOffsale { get; set; }
        /// <summary>
        /// 货品id
        /// </summary>
        [JsonProperty("ware_id")]
        public long? WareId { get; set; }

    }

}
