using System.ComponentModel.DataAnnotations;

namespace Json_Based_Localization.Web.ViewModel
{
    public class CreateTestViewModel
    {
        [Display(Name = "name"),Required(ErrorMessage ="required")]
        public string Name { get; set; }
    }
}
