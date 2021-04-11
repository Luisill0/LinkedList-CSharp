﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Reto
{
    public interface Iterator<G>
    {
        bool hasNext();
        G next();
    }
}
