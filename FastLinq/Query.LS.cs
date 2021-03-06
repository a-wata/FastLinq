﻿ 
using System;
using System.Linq.Expressions;

namespace FastLinq.LinqToSql
{
    public class Query<TDB> : QueryBase<TDB>
        where TDB : System.Data.Linq.DataContext
    {
			
		public override Func<TDB, TR> Compiled<TR>(Expression<Func<TDB, TR>> query)
        {
            return System.Data.Linq.CompiledQuery.Compile(query);
        }
			
		public override Func<TDB, T1,TR> Compiled<T1,TR>(Expression<Func<TDB, T1,TR>> query)
        {
            return System.Data.Linq.CompiledQuery.Compile(query);
        }
			
		public override Func<TDB, T1,T2,TR> Compiled<T1,T2,TR>(Expression<Func<TDB, T1,T2,TR>> query)
        {
            return System.Data.Linq.CompiledQuery.Compile(query);
        }
			
		public override Func<TDB, T1,T2,T3,TR> Compiled<T1,T2,T3,TR>(Expression<Func<TDB, T1,T2,T3,TR>> query)
        {
            return System.Data.Linq.CompiledQuery.Compile(query);
        }
		
    }
}