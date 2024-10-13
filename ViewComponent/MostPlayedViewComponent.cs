using Microsoft.AspNetCore.Mvc;

namespace MyTestProject.ViewComponents
{
    public class MostPlayedViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View("Index");
        }
    }
}
