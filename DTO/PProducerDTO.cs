using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PProducerDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
   
        public string Origin { get; set; }
        public int Prices { get; set; }
        public int ProducerId { get; set; }
        public string Image { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }


        public PProducerDTO() {
            DateTime currentTime = DateTime.Now;
            CreatedAt = currentTime;
            UpdatedAt = currentTime;
        }
        public PProducerDTO(int Id, string Name, int CategoryId, string Origin, int Prices, int ProducerId, string Image, DateTime CreatedAt, DateTime UpdatedAt) {
            this.Id = Id;
            this.Name = Name;
            this.CategoryId = CategoryId;
            this.Origin = Origin;
            this.Prices = Prices;
            this.ProducerId = ProducerId;
            this.Image = Image;
            this.CreatedAt = CreatedAt;
            this.UpdatedAt = UpdatedAt;
        }
    }
}
