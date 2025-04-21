using e_comm.Models.Orders;

namespace e_comm.Repository
{
    public interface IOrderRepository
    {
        void RemoveCartItemsByCartId(int cartId);
        int PlaceOrderByOrderId(int orderId, string shippingAddress, PaymentStatus paymentStatus, int cartId);
        int CancelOrder(int orderId);
        Order GetOrderByOrderId(int orderId);
        List<Order> GetOrders();
        List<Order> GetOrderByUserId(int userId);
        int UpdateOrder(int orderId, Order order);
        OrderStatus CalculateOrderStatus(Order order);
        OrderStatus GetOrderStatus(int orderId);
        bool UpdateTotalCalculations(int orderId);


    }
}