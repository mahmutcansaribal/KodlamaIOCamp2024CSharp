﻿using CrudOperation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudOperation.Business.Abstract;

public interface ICategoryService
{
    void Add(Category category);
    void Update(Category category);
    void Delete(Category category);
    List<Category> GetAll();
}
