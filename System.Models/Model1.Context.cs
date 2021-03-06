﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace System.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Threading;
    using System.Threading.Tasks;

    public partial class XJFMessageEntities : DbContext
    {
        public XJFMessageEntities()
            : base("name=XJFMessageEntities")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
        /// <summary>
        /// 重写保存方法 
        /// 将sql语句写入日志文件中
        /// </summary>
        /// <returns></returns>
        public override int SaveChanges()
        {
            string sql = "";
            
            this.Database.Log = (a) =>
            {
                sql += a;
            };
            LogTools.EFWrite.WriteSQL(sql);
            return base.SaveChanges();
        }
        /// <summary>
        /// 重写保存方法 
        /// 将sql语句写入日志文件中
        /// </summary>
        /// <returns></returns>
        public override Task<int> SaveChangesAsync()
        {
            string sql = "";
            this.Database.Log = (a) =>
            {
                sql += a;
            };
            LogTools.EFWrite.WriteSQL(sql);
            return base.SaveChangesAsync();
        }
        /// <summary>
        /// 重写保存方法 
        /// 将sql语句写入日志文件中
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken)
        {
            string sql = "";
            this.Database.Log = (a) =>
            {
                sql += a;
            };
            LogTools.EFWrite.WriteSQL(sql);
            return base.SaveChangesAsync(cancellationToken);
        }

        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<XJFAdmin> XJFAdmin { get; set; }
        public virtual DbSet<XJFAuthority> XJFAuthority { get; set; }
        public virtual DbSet<XJFMenu> XJFMenu { get; set; }
        public virtual DbSet<XJFRole> XJFRole { get; set; }
    }
}
