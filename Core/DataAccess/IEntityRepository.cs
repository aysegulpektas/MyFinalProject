using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    //generic constraint generic kısıt demek
    //clas: referans tip
    //IEntity: IEntity olabılır veya IEntity implemente eden bir nesne olabilir
    //new: newlenebilir olmalı..IEntity newleneemz olduğu için IEntity gelemez
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
