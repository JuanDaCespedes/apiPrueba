﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfases;

public interface IUsuarioRepository : IGenericRepository<Usuario>
{
    Task<Usuario> GetByUsernameAsync(string username);
}