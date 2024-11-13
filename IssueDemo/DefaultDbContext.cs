using Furion.DatabaseAccessor;
using Microsoft.EntityFrameworkCore;

namespace IssueDemo
{
    public class User2 : EntityBase
    {
        // 无需定义 Id 属性

        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }
    }

    [AppDbContext("DefaultConnection", DbProvider.SqlServer)]
    public class DefaultDbContext : AppDbContext<DefaultDbContext>
    {
        //SQL Server中频繁出现死锁时，可考虑在数据库执行ALTER DATABASE CURRENT SET ALLOW_SNAPSHOT_ISOLATION ON;  开启快照
        public DefaultDbContext(DbContextOptions<DefaultDbContext> options) : base(options)
        {
            Database.SetCommandTimeout(60);//默认数据库操作超时时间为30秒，可修改
            //忽略空值的更新
            //InsertOrUpdateIgnoreNullValues = true;  
        }
    }
}
