using Microsoft.AspNetCore.Components;

namespace Blazor1.Pages
{
    public partial class Counter //partial// часть основного класса
    {
        [Inject] SingletonService  singleton { get; set; } //changed @inject private SingletonService singleton
        [Inject] TrinsientService transient { get; set; }
        
        private int currentCount = 0;

        private void IncrementCount()
        {
            currentCount++;

            singleton.Value = currentCount;
            transient.Value = currentCount;
        }
    }
}