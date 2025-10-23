namespace NorelyPoc.BlazorApp.Logic
{
    public class CounterLogic
    {
        public int CurrentCount { get; private set; } = 0;

        public void IncrementCount()
        {
            CurrentCount++;
        }
    }
}