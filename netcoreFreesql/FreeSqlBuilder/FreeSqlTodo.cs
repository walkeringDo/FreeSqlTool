using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace netcoreFreesql.FreeSqlBuilder
{
    public class FreeSqlTodo
    {
        public static IFreeSql fsql = new FreeSql.FreeSqlBuilder().UseConnectionString(FreeSql.DataType.PostgreSQL, @"Host = 119.45.49.172;Port=15432;Username=postgres;Password=20110812;Database=Test_wk;Pooling=true;Maximum Pool Size=2").UseAutoSyncStructure (true).Build ();
    }
}
