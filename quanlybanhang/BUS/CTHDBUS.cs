﻿using DAO;
using DTO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class CTHDBUS
    {
        CTHDDAO ct = new CTHDDAO();
        public void Add(List<CTHDDTO> entity)
        {

            ct.Add(entity);
        }
    }
}
