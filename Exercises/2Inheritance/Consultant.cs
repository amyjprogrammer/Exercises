namespace Exercises._1Classes
{
    class Consultant : Person
    {
        public Consultant(string name, decimal hourlyRate, int hoursReported) : base(name)
        {
            HourlyRate = hourlyRate;
            hoursReported = HoursReported;
        }
        public decimal HourlyRate { get; set; }
        public int HoursReported { get; set; }
    }
}
