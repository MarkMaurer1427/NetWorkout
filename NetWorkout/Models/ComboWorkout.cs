namespace NetWorkout.Models
{
    public class ComboWorkout
    {
        /*
         * MachineBank and FreeBank are nullable. If present, only exercise ids included will be used 
         * to generate workout. If null, all available exercises will be used.
         */
        public int Id { get; set; }
        public string Name { get; set; }
        public List<UpperMachine> UpperMachines { get; set; }
        public int[]? UpperMachineBank { get; set; }
        public List<UpperFree> UpperFreeWeights { get; set; }
        public int[]? UpperFreeBank { get; set; }
        public List<LowerMachine> LowerMachines { get; set; }
        public int[]? LowerMachineBank { get; set; }
        public List<LowerFree> LowerFreeWeights { get; set; }
        public int[]? LowerFreeBank { get; set; }
        public List<CoreExercise> CoreExercises { get; set; }
        public CardioEx CardioExercise { get; set; }
        public int CardioTime { get; set; }

        int repIndex;

        int[] reps = { 6, 8, 10, 12 };



    }
}
