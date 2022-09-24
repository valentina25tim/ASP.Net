namespace FirstAPI.Controllers
{
    public class CurrentStatus
    {
        // select from WorkExperience (-> "now ")
        public string Id { get; set; }
        public bool WaitOffer { get; set; }
        public string SectorJob { get; set; }
        public string Role { get; set; }
        public string TypeJob { get; set; }
    }
}