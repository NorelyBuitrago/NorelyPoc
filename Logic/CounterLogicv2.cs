namespace NorelyPoc.BlazorApp.Logic
{
    public class CounterLogicv2
    {
        public int CurrentCount { get; private set; } = 0;

        public void IncrementCount()
        {
            CurrentCount++;
        }
    }
}