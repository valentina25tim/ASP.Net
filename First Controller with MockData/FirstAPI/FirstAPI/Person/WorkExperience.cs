using System;

namespace FirstAPI.Controllers
{
    public class WorkExperience
    {
        public string Id { get; set; }
        public string NameCompany { get; set; }
        public string UrlCompany { get; set; }
        public string Role { get; set; }
        public string TypeJob { get; set; }
        public DateTime Started { get; set; }
        public DateTime Unemployed { get; set; }
        public int Duration { get; set; }
    }
}
