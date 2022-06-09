using PlatformService.Models;

namespace PlatformService.Data
{
  public interface IPlatformRepo
  {
    bool SaveChanges();
    List<Platform> GetAllPlatforms();
    Platform GetPlatformById(int id);
    void CreatePlateform(Platform platform);
  }
}