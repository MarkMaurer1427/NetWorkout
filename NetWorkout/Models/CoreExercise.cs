namespace NetWorkout.Models
{
    public class CoreExercise
    {
        public int Id {get; set;}
        public string Name{get; set;}
        public int[] Reps { get; set; }
        public int[]? Weights { get; set; }

        
        public CoreExercise(int id, string name, int[] reps, int[] weights)
        {
            Id = id;
            Name = name;
            Reps = reps;
            Weights = weights;
        }
    }
}
