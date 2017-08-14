﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Util.Datas.Ef.Core;
using Util.Domains;

namespace Util.Datas.Ef.PgSql {
    /// <summary>
    /// 映射配置
    /// </summary>
    /// <typeparam name="TEntity">聚合根类型</typeparam>
    public abstract class Map<TEntity> : MapBase<TEntity>, IMap where TEntity : class, IVersion {
        /// <summary>
        /// 映射乐观离线锁
        /// </summary>
        protected override void MapVersion( EntityTypeBuilder<TEntity> builder ) {
            builder.Property( t => t.Version ).IsConcurrencyToken();
        }
    }
}