namespace WebAPI.Projects.Setup.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Skill")]
    public partial class Skill
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Skill()
        {
            ProjectSkills = new HashSet<ProjectSkill>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        [StringLength(100)]
        public string Version { get; set; }

        [Column(TypeName = "ntext")]
        public string Description { get; set; }

        public bool Archived { get; set; }

        public DateTime Created { get; set; }

        public DateTime? LastModified { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProjectSkill> ProjectSkills { get; set; }
    }
}
