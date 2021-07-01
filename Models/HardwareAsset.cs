namespace SnipeIt.Models
{
    public class HardwareAsset
    {
        public int id { get; set; }
        public string name { get; set; }
        public string asset_tag { get; set; }
        public string serial { get; set; }
        public Model model { get; set; }
        public string model_number { get; set; }
        public StatusLabel status_label { get; set; }
    }

    public class Model 
    {
        public int id { get; set; }
        public string name { get; set; }
    }

    public class StatusLabel
    {
        public int id { get; set; }
        public string name { get; set; }
        public string status_type { get; set; }
    }
}
