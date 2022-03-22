﻿// =============================
// Email: info@ebenmonney.com
// www.ebenmonney.com/templates
// =============================

using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Quick_Application1.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quick_Application1.Helpers
{
    public static class Extensions
    {
        public static void AddPagination(this HttpResponse response, int currentPage, int itemsPerPage, int totalItems, int totalPages)
        {
            response.Headers.Add("Pagination", JsonConvert.SerializeObject(new PageHeader(currentPage, itemsPerPage, totalItems, totalPages)));
            response.Headers.Add("access-control-expose-headers", "Pagination"); // CORS
        }

        public static void AddApplicationError(this HttpResponse response, string message)
        {
            response.Headers.Add("Application-Error", message);
            response.Headers.Add("access-control-expose-headers", "Application-Error");// CORS
        }
    }
}
