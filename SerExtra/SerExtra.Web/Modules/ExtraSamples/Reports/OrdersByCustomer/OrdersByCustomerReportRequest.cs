﻿
namespace SerExtra.ExtraSamples
{
    using _Ext;
    using Serenity.ComponentModel;
    using Serenity.Services;
    using SerExtra.Northwind.Entities;
    using System;
    using System.ComponentModel;

    [FormScript("ExtraSamples.OrdersByCustomerReportRequestForm")]
    public class OrdersByCustomerReportRequestForm
    {
        [DisplayName("Customer"), Required]
        [LookupEditor(typeof(CustomerRow))]
        public Int32 CustomerId { get; set; }
    }

    public class OrdersByCustomerReportRequest : ServiceRequest
    {
        public Int32 CustomerId { get; set; }
    }
}