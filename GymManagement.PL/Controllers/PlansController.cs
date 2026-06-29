using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GymManagement.DAL.Repositories.Interfaces;



namespace GymManagement.Controllers
{
    public class PlansController : Controller
    {

        private readonly IPlanRepository planRepository;
        public PlansController(IPlanRepository planRepository)
        {
            this.planRepository = planRepository;
        }

        public async Task<IActionResult> Index(CancellationToken ct)
        {
            var plans = await planRepository.GetAllAsync(ct: ct);
            return View(plans);
        }
        public async Task<IActionResult> Details(int id, CancellationToken ct)
        {
            var plan = await planRepository.GetByIdAsync(id, ct);
            if (plan is null)
                return RedirectToAction(nameof(Index));
            return View(plan);
        }
       
    }
}