namespace Pro_Solution
{
    internal class Series
    {
        internal object value3;
        internal object points;
        private string v;

        public Series(string v)
        {
            this.v = v;
        }

        public object ChartType { get; internal set; }
        public object Points { get; internal set; }
    }
}