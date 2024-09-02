using Freelancer.Models.ViewModels;

using Microsoft.AspNetCore.Mvc;

namespace Freelancer.Components;

[ViewComponent(Name = "Contact")]
public class ContactViewComponent : ViewComponent
{
    public IViewComponentResult Invoke(ContantViewModel model)
    {
        model ??= new ContantViewModel();
        return View(model);
    }
}