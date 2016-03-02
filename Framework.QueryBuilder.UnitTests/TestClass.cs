﻿namespace Framework.QueryBuilder.UnitTests
{
    using System;

    public class TestClass : IFilterable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTimeOffset EndDateTimeOffset { get; set; }
        public bool IsActive { get; set; }
    }
}
