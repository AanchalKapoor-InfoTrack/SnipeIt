using SnipeIt.Models;

namespace SnipeIt.Services
{
    public interface IHardwareService 
    {
        public HardwareAsset GetHardware(int id);
    }
    public class HardwareService: IHardwareService
    {
        public HardwareAsset GetHardware(int id) 
        {
            return null;
        }
    }
}
