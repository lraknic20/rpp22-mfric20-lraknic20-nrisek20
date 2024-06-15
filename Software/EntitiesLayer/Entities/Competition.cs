namespace EntitiesLayer.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Competition
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Competition()
        {
            Applications = new HashSet<Application>();
            Criteria = new HashSet<Criterion>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(30)]
        public string name { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string description { get; set; }

        public DateTime creation_date { get; set; }

        public DateTime due_date { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string needed_documentation { get; set; }

        public bool opened { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Application> Applications { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Criterion> Criteria { get; set; }
    }
}
