using System;

namespace FirstAPI.Controllers
{
    public class Education
    {
        public string Id { get; set; }
        public string NameEstablishment { get; set; }
        public string Speciality { get; set; }
        public string Degree { get; set; }
        public DateTime StudyBegin { get; set; }
        public DateTime StudyFinish { get; set; }
    }
}
