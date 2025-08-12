
using Microsoft.AspNetCore.Components;

namespace OnionGolmehr.UI.Shared.Pages
{
    public partial class Home : ComponentBase
    {
        public int count = 0;

        public void IncrementCount() => count++;
    }
}
