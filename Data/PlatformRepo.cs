using PlatformService.Models;

namespace PlatformService.Data
{
  public class PlatformRepo : IPlatformRepo
  {
    private readonly AppDbContext _context;

    public PlatformRepo(AppDbContext context)
    {
      _context = context;
    }
    public void CreatePlateform(Platform platform)
    {
      if (platform == null)
      {
        throw new ArgumentException(nameof(platform));
      }

      _context.Plateforms.Add(platform);
    }

    public List<Platform> GetAllPlatforms()
    {
      return _context.Plateforms.ToList();
    }

    public Platform GetPlatformById(int id)
    {
      return _context.Plateforms.FirstOrDefault(i => i.Id == id)!;
    }

    public bool SaveChanges()
    {
      return (_context.SaveChanges() >= 0);
    }
  }
}