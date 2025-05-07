namespace Pro_Solution
{
    internal class ChartArea
    {
        private string v;

        public ChartArea(string v)
        {
            this.v = v;
        }

        public string Name { get; internal set; }
        public object AxisX { get; internal set; }
        public object AxisY { get; internal set; }
    }
}