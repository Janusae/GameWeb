using Microsoft.AspNetCore.Mvc;

namespace MyTestProject.ViewComponents
{
    public class TrendingListViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View("Index");
        }
    }
}
