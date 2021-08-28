using Blazor1.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.VisualBasic;
using static Blazor1.Shared.MainLayout;

namespace Blazor1.Pages
{
    public partial class Counter //partial// часть основного класса
    {
        [Inject] SingletonService  singleton { get; set; } //changed @inject private SingletonService singleton
        [Inject] TrinsientService transient { get; set; }
        
        
        // [CascadingParameter(Name = "Color")] public string Color { get; set; }
        // [CascadingParameter(Name = "size")] public string Size { get; set; }
        
        [CascadingParameter] public AppStyle Styles { get; set; }
        private int currentCount = 0;

        private void IncrementCount()
        {
            currentCount++;

            singleton.Value = currentCount;
            transient.Value = currentCount;
        }
    }
}