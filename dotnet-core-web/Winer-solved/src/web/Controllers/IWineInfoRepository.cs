public interface IWineInfoRepository 
{
    WineInfo GetWineInfo(int id);
}

public class WineInfo
{
    public string Name { get; set; }
    public string Vintage { get; set; }
    public string Country { get; set; }
}