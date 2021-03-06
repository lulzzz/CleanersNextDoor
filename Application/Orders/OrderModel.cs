﻿using Application.Common.Mappings;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Orders
{
    public class OrderModel : IMapFrom<Order>
    {
        public string Note { get; set; }
        public decimal Total { get; set; }
        public int OrderStatusTypeID { get; set; }
        public int MerchantID { get; set; }
        public int? CustomerID { get; set; }
    }
}
