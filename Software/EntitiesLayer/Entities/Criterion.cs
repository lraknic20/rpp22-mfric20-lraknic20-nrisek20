namespace EntitiesLayer.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Criterion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Criterion()
        {
            Competitions = new HashSet<Competition>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(30)]
        public string name { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string description { get; set; }

        public int grade { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Competition> Competitions { get; set; }
    }
}
