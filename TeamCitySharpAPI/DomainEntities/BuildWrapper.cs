﻿using System.Collections.Generic;

namespace TeamCitySharpAPI.DomainEntities
{
    public class BuildWrapper
    {
        public string Count { get; set; }
        public List<Build> BuildType { get; set; }
    }
}