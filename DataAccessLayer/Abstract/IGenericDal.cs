﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T : class
    {


        List<T> GetAllList();

        T GetById(int id);

        void Delete(T t);
        void Insert(T t);
        void Update(T t);



    }
}
