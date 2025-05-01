using DevFreela.Core.Entities;

namespace DevFreela.Core.Models
{
    public class SkillViewModel
    {
        public string Description { get; set; }

        public static SkillViewModel FromEntity(Skill entity)
        {
            return new SkillViewModel { Description = entity.Description };
        }
    }
}
