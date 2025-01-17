﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.Abstract
{
    public interface IEntityRepository<TEntity> where TEntity : class, IEntity, new()
    {
        void Add(TEntity entity);
        List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter=null);
        TEntity GetById(int id);
        
    }
}
