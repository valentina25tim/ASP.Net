using System;

namespace FirstAPI.Controllers
{
    public class Certificate
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string IssuedBy { get; set; }
        public DateTime Date { get; set; }
    }
}
