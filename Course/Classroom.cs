namespace Course
{
    public class Classroom
    {
        private int number;
        private string ownerName;
        private double square;
        private bool safety;
        private string department;
        private int capacity;
        private string image;
        public Classroom() { }
        public Classroom(int number, string ownerName, double square, bool safety, string department, int capacity)
        {
            this.number = number;
            this.ownerName = ownerName;
            this.square = square;
            this.safety = safety;
            this.department = department;
            this.capacity = capacity;
        }
        public Classroom(int number, string ownerName, double square, bool safety, string department, int capacity, string image)
        {
            this.number = number;
            this.ownerName = ownerName;
            this.square = square;
            this.safety = safety;
            this.department = department;
            this.capacity = capacity;
            this.image = image;
        }
        public int Capacity { get => capacity; set => capacity = value; }
        public string Department { get => department; set => department = value; }
        public int Number { get => number; set => number = value; }
        public string OwnerName { get => ownerName; set => ownerName = value; }
        public bool Safety { get => safety; set => safety = value; }
        public double Square { get => square; set => square = value; }
        public string Image { get => image; set => image = value; }
        public bool IsValid()
        {
            try
            {
                if (string.IsNullOrEmpty(ownerName))return false;
                if (square < 0.0) return false;
                if (string.IsNullOrEmpty(department)) return false;
                if (capacity < 0) return false;
                return true;
            }
            catch
            {
                return false;
            }
        }
        public override string ToString() => this.number + ";" + this.ownerName + ";" + this.square + ";" + this.safety + ";" + this.department + ";" + this.capacity + ";" + this.image;
    }

}
