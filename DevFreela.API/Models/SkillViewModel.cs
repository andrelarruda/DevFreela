using DevFreela.API.Entities;

namespace DevFreela.API.Models
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
