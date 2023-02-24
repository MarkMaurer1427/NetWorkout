namespace NetWorkout.Models
{
    public class CardioEx
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public CardioEx(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
