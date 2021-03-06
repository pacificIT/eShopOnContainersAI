﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.eShopOnContainers.WebDashboardRazor.Extensions;

namespace Microsoft.eShopOnContainers.WebDashboardRazor.Infrastructure
{
    public static class API
    {
        public static class Catalog
        {
            private static string urlAISuffix = "/catalog-ai-api/v1/CatalogAI";
            private static string urlSuffix = "/api/v1/c/catalog";

            public static string ControllerUrl(string baseUrl)
            {
                return $"{baseUrl.TrimEndSlash()}{urlAISuffix}";
            }
            public static string ProductInfo(string baseUrl, string format="json")
            {
                return $"{baseUrl.TrimEndSlash()}{urlAISuffix}/dumpToCSV?format={format}";
            }
            public static string SimilarProducts(string baseUrl, string description)
            {
                return $"{baseUrl.TrimEndSlash()}{urlAISuffix}/productSetDetailsByDescription?description={description}";
            }
            public static string ProductPicture(string baseUrl, string id)
            {
                return $"{baseUrl.TrimEndSlash()}{urlSuffix}/items/{id}/pic";
            }
        }

        public static class Ordering
        {
            private static string urlSuffix = "/ordering-ai-api/v1/OrdersAI";
            public static string ControllerUrl(string baseUrl)
            {
                return $"{baseUrl.TrimEndSlash()}{urlSuffix}";
            }

            public static string ProductSales(string baseUrl, string format="csv")
            {
                return $"{baseUrl.TrimEndSlash()}{urlSuffix}/dumpToCSV?format={format}";
            }

            public static string ProductStats(string baseUrl, string format="csv")
            {
                return $"{baseUrl.TrimEndSlash()}{urlSuffix}/product/stats?format={format}";
            }

            public static string CountryStats(string baseUrl)
            {
                return $"{baseUrl.TrimEndSlash()}{urlSuffix}/country/stats";
            }

            public static string ProductsDepths(string baseUrl, IEnumerable<string> productIds)
            {
                return $"{baseUrl.TrimEndSlash()}{urlSuffix}/product/depth?products={String.Join(',',productIds)}";
            }
        }

        public static class Forecasting
        {
            private static string urlSuffix = "/forecasting-mlnet-api/v1/ForecastingAI";
            public static string ControllerUrl(string baseUrl)
            {
                return $"{baseUrl.TrimEndSlash()}{urlSuffix}";
            }
        }

        public static class Identity
        {
            private static string urlSuffix = "/identity-ai-api/v1/AccountAI";

            public static string UserInfo(string baseUrl)
            {
                return $"{baseUrl.TrimEndSlash()}{urlSuffix}/dumpToCSV";
            }
        }
    }
}
