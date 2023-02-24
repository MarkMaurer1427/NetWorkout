namespace NetWorkout.Models
{
    public class UpperMachine
    {
        public int Id { get; set; }
        public string FlexorEx { get; set; }
        public string ExtensorEx { get; set; }
        public int[] Weights { get; set; }

        public UpperMachine(int id, string flexor, string extensor, int[] weights) 
        {
            this.Id = id;
            this.FlexorEx = flexor; 
            this.ExtensorEx = extensor;
            this.Weights = weights;
        }
    }
}
