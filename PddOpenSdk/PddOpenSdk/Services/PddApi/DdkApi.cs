
using PddOpenSdk.Models.Request.Ddk;
using PddOpenSdk.Models.Response.Ddk;
namespace PddOpenSdk.Services.PddApi;
public class DdkApi : PddCommonApi
{
    public DdkApi() { }
    public DdkApi(string clientId, string clientSecret, string accessToken) : base(clientId, clientSecret, accessToken) { }

    /// <summary>
    /// 创建多多礼金
    /// </summary>
    public async Task<CreateDdkCashgiftResponse> CreateDdkCashgiftAsync(CreateDdkCashgift createDdkCashgift)
    {
        var result = await PostAsync<CreateDdkCashgift, CreateDdkCashgiftResponse>("pdd.ddk.cashgift.create", createDdkCashgift);
        return result;
    }

    /// <summary>
    /// 查询多多礼金效果数据
    /// </summary>
    public async Task<QueryDdkCashgiftDataResponse> QueryDdkCashgiftDataAsync(QueryDdkCashgiftData queryDdkCashgiftData)
    {
        var result = await PostAsync<QueryDdkCashgiftData, QueryDdkCashgiftDataResponse>("pdd.ddk.cashgift.data.query", queryDdkCashgiftData);
        return result;
    }

    /// <summary>
    /// 多多礼金状态更新
    /// </summary>
    public async Task<UpdateDdkCashgiftStatusResponse> UpdateDdkCashgiftStatusAsync(UpdateDdkCashgiftStatus updateDdkCashgiftStatus)
    {
        var result = await PostAsync<UpdateDdkCashgiftStatus, UpdateDdkCashgiftStatusResponse>("pdd.ddk.cashgift.status.update", updateDdkCashgiftStatus);
        return result;
    }

    /// <summary>
    /// 生成商城-频道推广链接
    /// </summary>
    public async Task<GenerateDdkCmsPromUrlResponse> GenerateDdkCmsPromUrlAsync(GenerateDdkCmsPromUrl generateDdkCmsPromUrl)
    {
        var result = await PostAsync<GenerateDdkCmsPromUrl, GenerateDdkCmsPromUrlResponse>("pdd.ddk.cms.prom.url.generate", generateDdkCmsPromUrl);
        return result;
    }

    /// <summary>
    /// 多多进宝商品详情查询
    /// </summary>
    public async Task<DetailDdkGoodsResponse> DetailDdkGoodsAsync(DetailDdkGoods detailDdkGoods)
    {
        var result = await PostAsync<DetailDdkGoods, DetailDdkGoodsResponse>("pdd.ddk.goods.detail", detailDdkGoods);
        return result;
    }

    /// <summary>
    /// 创建多多进宝推广位
    /// </summary>
    public async Task<GenerateDdkGoodsPidResponse> GenerateDdkGoodsPidAsync(GenerateDdkGoodsPid generateDdkGoodsPid)
    {
        var result = await PostAsync<GenerateDdkGoodsPid, GenerateDdkGoodsPidResponse>("pdd.ddk.goods.pid.generate", generateDdkGoodsPid);
        return result;
    }

    /// <summary>
    /// 查询已经生成的推广位信息
    /// </summary>
    public async Task<QueryDdkGoodsPidResponse> QueryDdkGoodsPidAsync(QueryDdkGoodsPid queryDdkGoodsPid)
    {
        var result = await PostAsync<QueryDdkGoodsPid, QueryDdkGoodsPidResponse>("pdd.ddk.goods.pid.query", queryDdkGoodsPid);
        return result;
    }

    /// <summary>
    /// 多多进宝推广链接生成
    /// </summary>
    public async Task<GenerateDdkGoodsPromotionUrlResponse> GenerateDdkGoodsPromotionUrlAsync(GenerateDdkGoodsPromotionUrl generateDdkGoodsPromotionUrl)
    {
        var result = await PostAsync<GenerateDdkGoodsPromotionUrl, GenerateDdkGoodsPromotionUrlResponse>("pdd.ddk.goods.promotion.url.generate", generateDdkGoodsPromotionUrl);
        return result;
    }

    /// <summary>
    /// 多多进宝商品推荐API
    /// </summary>
    public async Task<GetDdkGoodsRecommendResponse> GetDdkGoodsRecommendAsync(GetDdkGoodsRecommend getDdkGoodsRecommend)
    {
        var result = await PostAsync<GetDdkGoodsRecommend, GetDdkGoodsRecommendResponse>("pdd.ddk.goods.recommend.get", getDdkGoodsRecommend);
        return result;
    }

    /// <summary>
    /// 多多进宝商品查询
    /// </summary>
    public async Task<SearchDdkGoodsResponse> SearchDdkGoodsAsync(SearchDdkGoods searchDdkGoods)
    {
        var result = await PostAsync<SearchDdkGoods, SearchDdkGoodsResponse>("pdd.ddk.goods.search", searchDdkGoods);
        return result;
    }

    /// <summary>
    /// 多多进宝转链接口
    /// </summary>
    public async Task<GenDdkGoodsZsUnitUrlResponse> GenDdkGoodsZsUnitUrlAsync(GenDdkGoodsZsUnitUrl genDdkGoodsZsUnitUrl)
    {
        var result = await PostAsync<GenDdkGoodsZsUnitUrl, GenDdkGoodsZsUnitUrlResponse>("pdd.ddk.goods.zs.unit.url.gen", genDdkGoodsZsUnitUrl);
        return result;
    }

    /// <summary>
    /// 查询是否绑定备案
    /// </summary>
    public async Task<QueryDdkMemberAuthorityResponse> QueryDdkMemberAuthorityAsync(QueryDdkMemberAuthority queryDdkMemberAuthority)
    {
        var result = await PostAsync<QueryDdkMemberAuthority, QueryDdkMemberAuthorityResponse>("pdd.ddk.member.authority.query", queryDdkMemberAuthority);
        return result;
    }

    /// <summary>
    /// 查询订单详情
    /// </summary>
    public async Task<GetDdkOrderDetailResponse> GetDdkOrderDetailAsync(GetDdkOrderDetail getDdkOrderDetail)
    {
        var result = await PostAsync<GetDdkOrderDetail, GetDdkOrderDetailResponse>("pdd.ddk.order.detail.get", getDdkOrderDetail);
        return result;
    }

    /// <summary>
    /// 最后更新时间段增量同步推广订单信息
    /// </summary>
    public async Task<GetDdkOrderListIncrementResponse> GetDdkOrderListIncrementAsync(GetDdkOrderListIncrement getDdkOrderListIncrement)
    {
        var result = await PostAsync<GetDdkOrderListIncrement, GetDdkOrderListIncrementResponse>("pdd.ddk.order.list.increment.get", getDdkOrderListIncrement);
        return result;
    }

    /// <summary>
    /// 用时间段查询推广订单接口
    /// </summary>
    public async Task<GetDdkOrderListRangeResponse> GetDdkOrderListRangeAsync(GetDdkOrderListRange getDdkOrderListRange)
    {
        var result = await PostAsync<GetDdkOrderListRange, GetDdkOrderListRangeResponse>("pdd.ddk.order.list.range.get", getDdkOrderListRange);
        return result;
    }

    /// <summary>
    /// 批量绑定推广位的媒体id
    /// </summary>
    public async Task<BindDdkPidMediaidResponse> BindDdkPidMediaidAsync(BindDdkPidMediaid bindDdkPidMediaid)
    {
        var result = await PostAsync<BindDdkPidMediaid, BindDdkPidMediaidResponse>("pdd.ddk.pid.mediaid.bind", bindDdkPidMediaid);
        return result;
    }

    /// <summary>
    /// 生成多多进宝频道推广
    /// </summary>
    public async Task<GenDdkResourceUrlResponse> GenDdkResourceUrlAsync(GenDdkResourceUrl genDdkResourceUrl)
    {
        var result = await PostAsync<GenDdkResourceUrl, GenDdkResourceUrlResponse>("pdd.ddk.resource.url.gen", genDdkResourceUrl);
        return result;
    }

    /// <summary>
    /// 生成营销工具推广链接
    /// </summary>
    public async Task<GenerateDdkRpPromUrlResponse> GenerateDdkRpPromUrlAsync(GenerateDdkRpPromUrl generateDdkRpPromUrl)
    {
        var result = await PostAsync<GenerateDdkRpPromUrl, GenerateDdkRpPromUrlResponse>("pdd.ddk.rp.prom.url.generate", generateDdkRpPromUrl);
        return result;
    }

}
