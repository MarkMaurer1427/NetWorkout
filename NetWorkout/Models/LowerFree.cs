namespace NetWorkout.Models
{
    public class LowerFree
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int[] Weights { get; set; }

        public LowerFree(int id, string name, int[] weights)
        {
            Id = id;
            Name = name;
            Weights = weights;
        }
    }
}
