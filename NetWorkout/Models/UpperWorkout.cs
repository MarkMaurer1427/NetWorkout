namespace NetWorkout.Models
{
    public class UpperWorkout
    {
        /*
         * MachineBank and FreeBank are nullable. If present, only exercise ids included will be used 
         * to generate workout. If null, all available exercises will be used.
         */
        public int Id { get; set; }
        public string Name { get; set; }
        public List<UpperMachine> Machines { get; set; }
        public int[]? MachineBank { get; set; }
        public List<UpperFree> FreeWeights { get; set; }
        public int[]? FreeBank { get; set; }
        public List<CoreExercise> CoreExercises { get; set; }
        public CardioEx CardioExercise { get; set; }
        public int CardioTime { get; set; }

        int repIndex;

        int[] reps = { 6, 8, 10, 12 };



    }
}
