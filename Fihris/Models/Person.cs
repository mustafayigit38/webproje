﻿using System;
using System.Collections.Generic;

namespace Fihris.Models;

public partial class Person
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public virtual ICollection<Info> Infos { get; set; } = new List<Info>();
}
