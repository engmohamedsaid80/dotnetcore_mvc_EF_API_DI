﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DomainModel
{
    public interface IRepo
    {
        BusService GetService();
    }
}
