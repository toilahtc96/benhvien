using DataAccessLayer.Abstract;
using DataAccessLayer.DataModel;
using System;
using System.Collections.Generic;
using WCF.BussinessObject.EntityObject;

namespace DataAccessLayer.Dao
{
    public interface IOrderDetailRepository : DaoInterface<OrderDetailObject> {
        List<OrderDetailObject> GetOrderDetailByOID(Guid? orderID);
        int getQuantity(List<OrderDetailObject> listODD);
    }

    public class OrderDetailRepository : IOrderDetailRepository
    {
        private furniShopEntities db = new furniShopEntities();

        public OrderDetailObject Add(OrderDetailObject entity)
        {
            db.SP_OrderDetails_INSERT(entity.OrderDetailID, entity.ProductID, entity.OrderID, entity.Quantity);
            return entity;
        }

        public void Delete(Guid id)
        {
            db.SP_OrderDetails_DELETE(id);
        }

        public List<OrderDetailObject> GetAll(string[] includes = null)
        {
            var listOrderDetail = db.SP_OrderDetails_GetAll();
            List<OrderDetailObject> ListOrderDetail = new List<OrderDetailObject>();
            foreach (var item in listOrderDetail)
            {
                OrderDetailObject odo = new OrderDetailObject();
                odo.OrderDetailID = item.OrderDetailID;
                odo.ProductID = item.ProductID;
                odo.OrderID = item.OrderID;
                odo.Quantity = item.Quantity;
            }
            return ListOrderDetail;
        }

        public OrderDetailObject GetByID(Guid id)
        {
            var listOrderDetail = db.SP_OrderDetails_GetByOrderDetailID(id);
            OrderDetailObject odo = new OrderDetailObject();
            foreach (var item in listOrderDetail)
            {
                odo.OrderDetailID = item.OrderDetailID;
                odo.ProductID = item.ProductID;
                odo.OrderID = item.OrderID;
                odo.Quantity = item.Quantity;
            }
            return odo;
        }

        public List<OrderDetailObject> GetOrderDetailByOID(Guid? orderID)
        {
            var listOrderDetail = db.SP_OrderDetails_GetAll();
            List<OrderDetailObject> ListOrderDt = new List<OrderDetailObject>();
            foreach(var item in listOrderDetail)
            {
                if(item.OrderID == orderID)
                {
                    OrderDetailObject odo = new OrderDetailObject();

                    odo.OrderDetailID = item.OrderDetailID;
                    odo.ProductID = item.ProductID;
                    odo.OrderID = item.OrderID;
                    odo.Quantity = item.Quantity;
                    ListOrderDt.Add(odo);
                }
            }
            return ListOrderDt;
        }

        public int getQuantity(List<OrderDetailObject> listODD)
        {
            int qtt = 0;
                foreach(var item in listODD)
            {
                qtt += (int)item.Quantity;
            }
            return qtt;
        }

        public void Update(OrderDetailObject entity)
        {
            db.SP_OrderDetails_UPDATE(entity.OrderDetailID, entity.ProductID, entity.OrderID, entity.Quantity);
        }
    }
}