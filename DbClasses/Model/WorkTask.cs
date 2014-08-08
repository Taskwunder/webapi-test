namespace DbClasses.Model
{
    public class WorkTask : BaseEntity
    {
        public string Description { get; set; }
        public virtual User Owner { get; set; }
    }
}
