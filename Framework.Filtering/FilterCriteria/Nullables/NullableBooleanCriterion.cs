﻿namespace PeinearyDevelopment.Framework.Filtering.FilterCriteria.Nullables
{
  using FilterTypes;

  using System;
  using System.Collections.Generic;
  using System.Data.SqlClient;
  using System.Linq.Expressions;

  public class NullableBooleanCriterion<TFilterableObject> : BaseCriterion<TFilterableObject, BooleanFilterType, bool?> where TFilterableObject : class, IFilterable
  {
    public NullableBooleanCriterion(string propertyName, BooleanFilterType filterType, bool? filterValue) : base(propertyName, filterType, filterValue)
    {
    }

    public NullableBooleanCriterion(Expression<Func<TFilterableObject, bool?>> propertyNameExpression, BooleanFilterType filterType, bool? filterValue) : base(propertyNameExpression, filterType, filterValue)
    {
    }

    internal override string CreateWhere(IDictionary<string, string> objectPropertyToColumnNameMapper, int parameterIndex)
    {
      throw new System.NotImplementedException();
    }

    internal override IEnumerable<SqlParameter> CreateParameters(int startingParameterIndex)
    {
      throw new System.NotImplementedException();
    }
  }
}
