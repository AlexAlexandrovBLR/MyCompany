using System.ComponentModel.DataAnnotations;

namespace MyCompany.Domain.Entities
{
    public class ServiceItem : EntityBase
    {
        [Required(ErrorMessage = "Заполните навык")]
        [Display(Name = "Название навыка")]
        public override string Title { get; set; }

        [Display(Name = "Краткое описание навыка")]
        public override string Subtitle { get; set; }

        [Display(Name = "Полное описание навыка")]
        public override string Text { get; set; }
    }
}
