using System.ComponentModel.DataAnnotations;

namespace MyWebProject.Models.MobilePhones
{
    public class PhoneListingViewModel
    {
        public int Id { get; set; }

        public string Brand { get; set; }

        public decimal? Price { get; set; }

        public int? Year { get; set; }

        public string Url { get; set; }

        public string PhoneModels { get; set; }

    }
}
