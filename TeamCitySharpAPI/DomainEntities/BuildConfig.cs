﻿namespace TeamCitySharpAPI.DomainEntities
{
    public class BuildConfig
    {
        public override string ToString()
        {
            return Name;
        }

        public bool Paused { get; set; }
        public string Description { get; set; }
        public string Href { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public string WebUrl { get; set; }
    }
}