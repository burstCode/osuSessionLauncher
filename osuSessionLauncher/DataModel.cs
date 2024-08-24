namespace osuSessionLauncherConfigurator
{
    public class DataModel
    {
        public string PathToOsu { get; set; }
        public string PathToOBS { get; set; }
        public string PathToSC { get; set; }

        public DataModel(string pathToOsu, string pathToOBS, string pathToSC)
        {
            PathToOsu = pathToOsu;
            PathToOBS = pathToOBS;
            PathToSC = pathToSC;
        }

        public DataModel() { }
    }
}
