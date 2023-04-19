using AkarBusiness.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace AkarBusiness.Concrete
{
    public class GenericManager<T> : IGenericService<T>
    {
        private readonly IGenericService<T> _genericService;
        public GenericManager(IGenericService<T> genericService)
        {
            _genericService = genericService;
        }

        public void Add(T item)
        { 
            _genericService.Add(item);
        }

        public bool ForceDelete(T item)
        {
            return _genericService.ForceDelete(item);  
        }

        public T Get(Expression<Func<T, bool>> where = null, Expression<Func<T, object>>[] include = null)
        {
            return _genericService.Get(where, include);
        }

        public List<T> GetEnum(Expression<Func<T, bool>> where = null, Expression<Func<T, object>>[] include = null)
        {
            return _genericService.GetEnum(where, include);
        }

        public bool SafeDelete(T item)
        {
            return _genericService.SafeDelete(item);
        }

        public void Update(T item)
        {
            _genericService.Update(item);
        }
    }
}
