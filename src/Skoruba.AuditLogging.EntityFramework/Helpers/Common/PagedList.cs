﻿using System.Collections.Generic;

namespace Skoruba.AuditLogging.EntityFramework.Helpers.Common
{
    public class PagedList<T> where T : class
    {
        public PagedList()
        {
            Data = [];
        }

        public List<T> Data { get; }

        public int TotalCount { get; set; }

        public int PageSize { get; set; }
    }
}