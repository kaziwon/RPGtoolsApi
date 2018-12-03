namespace RpgTools.Model
{
    public class ActionModel 
    {
        public ActionModel(int id,string name,string description)
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}