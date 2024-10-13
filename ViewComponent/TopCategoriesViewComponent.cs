using Microsoft.AspNetCore.Mvc;

namespace MyTestProject.ViewComponents
{
    public class TopCategoriesViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View("Index");
        }
    }
}
