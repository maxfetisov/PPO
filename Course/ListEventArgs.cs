namespace Course
{
    public class ListEventArgs
    {
        private int oldCount;
        private int newCount;
        public ListEventArgs() { }
        public ListEventArgs(int oldCount, int newCount)
        {
            this.oldCount = oldCount;
            this.newCount = newCount;
        }
    }

}
