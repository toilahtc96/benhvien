using DataAccessLayer.Abstract;
using DataAccessLayer.DataModel;
using System;
using System.Collections.Generic;
using WCF.BussinessObject.EntityObject;

namespace DataAccessLayer.Dao
{
    public interface IOrderRepository : DaoInterface<OrderObject> {
        List<OrderObject> GetOrderByUserID(Guid userID);

    }

    public class OrderRepository : IOrderRepository
    {
        private furniShopEntities db = new furniShopEntities();

        public OrderObject Add(OrderObject entity)
        {
            db.SP_Orders_INSERT(entity.OrderID, entity.UserID, entity.CreateDate, entity.CreateBy);
            return entity;
        }

        public void Delete(Guid id)
        {
            db.SP_Orders_DELETE(id);
        }

        public List<OrderObject> GetAll(string[] includes = null)
        {
            var listOrder = db.SP_Orders_GetAll();
            List<OrderObject> ListOrderObject = new List<OrderObject>();
            foreach (var item in listOrder)
            {
                OrderObject odo = new OrderObject();
                odo.OrderID = item.OrderID;
                odo.UserID = item.UserID;
                odo.CreateBy = item.CreateBy;
                odo.CreateDate = item.DateTime;
            }
            return ListOrderObject;
        }

        public OrderObject GetByID(Guid id)
        {
            var listOrder = db.SP_Orders_GetByOrderID(id);
            OrderObject odo = new OrderObject();
            foreach (var item in listOrder)
            {
                odo.OrderID = item.OrderID;
                odo.UserID = item.UserID;
                odo.CreateBy = item.CreateBy;
                odo.CreateDate = item.DateTime;
            }
            return odo;
        }

        public List<OrderObject> GetOrderByUserID(Guid userID)
        {
            var listOrder = db.SP_Orders_GetAll();
            List<OrderObject> ListOrder = new List<OrderObject>();
            foreach (var item in listOrder)
            {
                if (item.UserID == userID)
                {
                    OrderObject odo = new OrderObject();
                    odo.OrderID = item.OrderID;
                    odo.UserID = item.UserID;
                    odo.CreateBy = item.CreateBy;
                    odo.CreateDate = item.DateTime;
                    ListOrder.Add(odo);
                }
            }
            return ListOrder;
        }
        public void Update(OrderObject entity)
        {
            db.SP_Orders_UPDATE(entity.OrderID, entity.UserID, entity.CreateDate, entity.CreateBy);
        }
    }
}