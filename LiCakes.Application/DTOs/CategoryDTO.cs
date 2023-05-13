namespace LiCakes.Infra.Data.DTOs
{
  public class CategoryDTO
  {
    public string Name { get; set; }

    public CategoryDTO(string name)
    {
      Name = name;
    }
  }
}
