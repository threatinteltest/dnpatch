﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dnlib.DotNet.Emit;

namespace dnpatch
{
    public partial class Target
    {
        public string Namespace { get; set; }
        public string Class { get; set; }
        public string Method { get; set; }
    }

    public partial class Target
    {
        public int[] Indexes { get; set; }
        public Instruction[] Instructions { get; set; }
    }

    public partial class Target
    {
        public int Index { get; set; } = -1;
        public Instruction Instruction { get; set; }
    }

    public partial class Target
    {
        public string[] NestedClasses { get; set; }
    }

    public partial class Target
    {
        public string NestedClass { get; set; }
    }
}
