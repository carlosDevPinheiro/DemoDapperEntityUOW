﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperEntityFramework.UWO
{
    public interface IUnitOfWork: IDisposable
    {
        void Commit();
        void Roolback();

    }
}
