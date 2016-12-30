namespace WebAPI.Projects.Setup.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProjectSkill")]
    public partial class ProjectSkill
    {
        public long ProjectSkillId { get; set; }

        public long ProjectId { get; set; }

        public int SkillId { get; set; }

        public virtual Project Project { get; set; }

        public virtual Skill Skill { get; set; }
    }
}
