
using PddOpenSdk.Models.Request.Order;
using PddOpenSdk.Models.Response.Order;
using System.Threading.Tasks;
namespace PddOpenSdk.Services.PddApi
{
    public class OrderApi : PddCommonApi
    {
        public OrderApi() { }
        public OrderApi(string clientId, string clientSecret, string accessToken) : base(clientId, clientSecret, accessToken) { }
        /// <summary>
        /// erp打单信息同步
        /// </summary>
        public async Task<SyncErpOrderResponseModel> SyncErpOrderAsync(SyncErpOrderRequestModel syncErpOrder)
        {
            var result = await PostAsync<SyncErpOrderRequestModel, SyncErpOrderResponseModel>("pdd.erp.order.sync", syncErpOrder);
            return result;
        }
        /// <summary>
        /// 订单基础信息列表查询接口（根据成交时间）
        /// </summary>
        public async Task<GetOrderBasicListResponseModel> GetOrderBasicListAsync(GetOrderBasicListRequestModel getOrderBasicList)
        {
            var result = await PostAsync<GetOrderBasicListRequestModel, GetOrderBasicListResponseModel>("pdd.order.basic.list.get", getOrderBasicList);
            return result;
        }
        /// <summary>
        /// 订单详情
        /// </summary>
        public async Task<GetOrderInformationResponseModel> GetOrderInformationAsync(GetOrderInformationRequestModel getOrderInformation)
        {
            var result = await PostAsync<GetOrderInformationRequestModel, GetOrderInformationResponseModel>("pdd.order.information.get", getOrderInformation);
            return result;
        }
        /// <summary>
        /// 订单列表查询接口（根据成交时间）
        /// </summary>
        public async Task<GetOrderListResponseModel> GetOrderListAsync(GetOrderListRequestModel getOrderList)
        {
            var result = await PostAsync<GetOrderListRequestModel, GetOrderListResponseModel>("pdd.order.list.get", getOrderList);
            return result;
        }
        /// <summary>
        /// 编辑商家订单备注
        /// </summary>
        public async Task<UpdateOrderNoteResponseModel> UpdateOrderNoteAsync(UpdateOrderNoteRequestModel updateOrderNote)
        {
            var result = await PostAsync<UpdateOrderNoteRequestModel, UpdateOrderNoteResponseModel>("pdd.order.note.update", updateOrderNote);
            return result;
        }
        /// <summary>
        /// 订单增量接口
        /// </summary>
        public async Task<GetOrderNumberListIncrementResponseModel> GetOrderNumberListIncrementAsync(GetOrderNumberListIncrementRequestModel getOrderNumberListIncrement)
        {
            var result = await PostAsync<GetOrderNumberListIncrementRequestModel, GetOrderNumberListIncrementResponseModel>("pdd.order.number.list.increment.get", getOrderNumberListIncrement);
            return result;
        }
        /// <summary>
        /// 查询订单承诺信息
        /// </summary>
        public async Task<GetOrderPromiseInfoResponseModel> GetOrderPromiseInfoAsync(GetOrderPromiseInfoRequestModel getOrderPromiseInfo)
        {
            var result = await PostAsync<GetOrderPromiseInfoRequestModel, GetOrderPromiseInfoResponseModel>("pdd.order.promise.info.get", getOrderPromiseInfo);
            return result;
        }
        /// <summary>
        /// 订单状态
        /// </summary>
        public async Task<GetOrderStatusResponseModel> GetOrderStatusAsync(GetOrderStatusRequestModel getOrderStatus)
        {
            var result = await PostAsync<GetOrderStatusRequestModel, GetOrderStatusResponseModel>("pdd.order.status.get", getOrderStatus);
            return result;
        }
        /// <summary>
        /// 修改订单收件地址接口
        /// </summary>
        public async Task<AddressOrderUpdateResponseModel> AddressOrderUpdateAsync(AddressOrderUpdateRequestModel addressOrderUpdate)
        {
            var result = await PostAsync<AddressOrderUpdateRequestModel, AddressOrderUpdateResponseModel>("pdd.order.update.address", addressOrderUpdate);
            return result;
        }
        /// <summary>
        /// 订单额外运单信息上传
        /// </summary>
        public async Task<LogisticsOrderUploadExtraResponseModel> LogisticsOrderUploadExtraAsync(LogisticsOrderUploadExtraRequestModel logisticsOrderUploadExtra)
        {
            var result = await PostAsync<LogisticsOrderUploadExtraRequestModel, LogisticsOrderUploadExtraResponseModel>("pdd.order.upload.extra.logistics", logisticsOrderUploadExtra);
            return result;
        }
        /// <summary>
        /// 虚拟业务信息查询接口
        /// </summary>
        public async Task<GetOrderVirtualInformationResponseModel> GetOrderVirtualInformationAsync(GetOrderVirtualInformationRequestModel getOrderVirtualInformation)
        {
            var result = await PostAsync<GetOrderVirtualInformationRequestModel, GetOrderVirtualInformationResponseModel>("pdd.order.virtual.information.get", getOrderVirtualInformation);
            return result;
        }

    }
}
