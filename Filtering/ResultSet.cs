﻿namespace PeinearyDevelopment.Framework.Filtering
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    public class ResultSet<TFilterable> where TFilterable : class, IFilterable
    {
        [JsonProperty(ItemTypeNameHandling = TypeNameHandling.Auto)]
        public int? TotalNumberOfResults { get; set; }
        [JsonProperty(ItemTypeNameHandling = TypeNameHandling.Auto)]
        public IEnumerable<TFilterable> Results { get; set; }
        [JsonProperty(ItemTypeNameHandling = TypeNameHandling.Auto)]
        public bool HasMoreResults { get; set; }

        public ResultSet()
        {
        }

        public ResultSet(IEnumerable<TFilterable> results, int? totalNumberOfResults) : this(results, totalNumberOfResults, false)
        {
        }

        public ResultSet(IEnumerable<TFilterable> results, int? totalNumberOfResults, bool hasMoreResults)
        {
            TotalNumberOfResults = totalNumberOfResults;
            Results = results;
            HasMoreResults = hasMoreResults;
        }
    }
}
