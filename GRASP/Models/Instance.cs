namespace GRASP.Models
{
    public class Instance
    {
        public int ID { get; set; }

        public float X { get; set; }

        public float Y { get; set; }

        public float Demand { get; set; }

        public float ReadyTime { get; set; }

        public float DueTime { get; set; }

        public float ServiceTime { get; set; }

        public bool IsDone { get; set; }

        public override string ToString()
        {
            return $"ID: {ID}\n X: {X}\n Y: {Y}\nDemand: {Demand}\nReady Time: {ReadyTime}\nDue Time: {DueTime}\nService Time: {ServiceTime}";
        }
    }
}
