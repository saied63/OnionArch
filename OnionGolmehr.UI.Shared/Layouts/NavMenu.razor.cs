using Microsoft.AspNetCore.Components;

namespace OnionGolmehr.UI.Shared.Layouts
{
    public partial class NavMenu : ComponentBase
    {
        private bool collapseNavMenu = true;

        protected string? NavMenuCssClass => collapseNavMenu ? "collapsed" : null;

        protected void ToggleNavMenu() => collapseNavMenu = !collapseNavMenu;
    }
}
