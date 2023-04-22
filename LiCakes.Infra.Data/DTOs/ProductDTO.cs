using LiCakes.Domain.Enums;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace LiCakes.Infra.Data.DTOs
{
  public class ProductDTO
  {
    [Required]
    [MaxLength(120)]
    public string Name { get; set; }

    [MaxLength(300)]
    public string? Description { get; set; }

    public decimal Price { get; set; }

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public EnumCategory Category { get; set; }
  }
}
