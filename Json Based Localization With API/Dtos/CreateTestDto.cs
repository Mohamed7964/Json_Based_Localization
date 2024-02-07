using System.ComponentModel.DataAnnotations;

namespace Json_Based_Localization_With_API.Dtos
{
    public class CreateTestDto
    {
        [Display(Name = "name"), Required(ErrorMessage = "required")]
        public string Name { get; set; }
    }
}
