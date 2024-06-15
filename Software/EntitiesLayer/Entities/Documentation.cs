namespace EntitiesLayer.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Documentation
    {
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string name { get; set; }

        [Required]
        [StringLength(200)]
        public string url { get; set; }

        public int users_id { get; set; }

        public int competitions_id { get; set; }

        public virtual Application Application { get; set; }
    }
}
