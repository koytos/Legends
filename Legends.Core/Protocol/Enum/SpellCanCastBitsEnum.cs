﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Legends.Core.Protocol.Enum
{
    public enum SpellCanCastBitsEnum : uint
    {
        Spell0 =  1 << 1,
        Spell1 = 1 << 2,
        Spell2 = 1 << 3,
        Spell3 =  1 << 4,
    }
}
