﻿using AOPTest.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace AOPTest.Data.Repositories
{
    public class InvoiceRepository : IInvoiceRepository
    {
        private InvoicingContext _ctx;

        public InvoiceRepository(InvoicingContext ctx)
        {
            _ctx = ctx;
        }

        public IEnumerable<Invoice> GetAll()
        {
            return _ctx.Invoices.ToList();
        }

        public void AddInvoice(Invoice invoice)
        {
            _ctx.Invoices.Add(invoice);
        }

        public override string ToString()
        {
            return GetType().Name;
        }
    }
}