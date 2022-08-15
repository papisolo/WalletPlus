﻿using smartwallet1.web.Data.Entities;

namespace smartwallet1.web.Data.Repository.Interface
{
    public interface IRepository <TEntity,Tkey> where TEntity : BaseEntity<Tkey>
        {
            Task<IEnumerable<TEntity>> Get(string filter);

            Task<TEntity> Get(Tkey id);

            Task Add(TEntity entity);

            Task Update(TEntity entity);

            Task Delete(Tkey id);
        }
    }
