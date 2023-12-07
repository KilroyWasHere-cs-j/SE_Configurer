using System.Globalization;

namespace SE_Configurer.Data;

public struct Configuration
{
    public string Title { get; set; }
    public string AppName { get; set; }
    public string AppVersion { get; set; }
    public string ComboDefault { get; set; }
    public string ClickCountLabel { get; set; }
    public List<Trackable> Trackables { get; set; }
}
