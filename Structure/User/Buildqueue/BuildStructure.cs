namespace SilverBot.UserVillages
{
    public class BuildStructure
    {
        public string id { get; set; }
        public string name { get; set; }
        public bool upgrade { get; set; }
        public double lefttime { get; set; }
        public double maxtime { get; set; }
        public bool isupgrading { get; set; }
        public string idtoskip { get; set; }
    }
}