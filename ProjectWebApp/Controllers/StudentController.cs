using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectWebApp.Data;
using ProjectWebApp.Models;
using ProjectWebApp.Models.Domain;
using System.Threading.Tasks;

namespace ProjectWebApp.Controllers
{
    public class StudentController : Controller

    {
        private readonly MVCDbContext mVCDbContext;

        public StudentController(MVCDbContext mVCDbContext)
        {
            this.mVCDbContext = mVCDbContext;
        }
        [HttpGet]
        public async Task<IActionResult>Index()
        {
          var student= await mVCDbContext.students.ToListAsync();
            return View(student);
            
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
      
        [HttpPost]
        public async Task<IActionResult> Add(AddStudentViewModel addStudentRequest)
        {
            var student = new Student()
            {
                Id = Guid.NewGuid(),
                FirstName = addStudentRequest.FirstName,
                LastName = addStudentRequest.LastName,
                EnrollmentDate = addStudentRequest.EnrollmentDate,
                Department = addStudentRequest.Department
            };
            await mVCDbContext.students.AddAsync(student);
            await mVCDbContext.SaveChangesAsync();  
            return RedirectToAction("Add");

        }
        [HttpGet]
        public async Task<IActionResult> View(Guid Id)
        {
           var student= await mVCDbContext.students.FirstOrDefaultAsync(x => x.Id == Id);
            if (student != null)
            {
                var ViewModel = new UpdateStudentViewModel()
                {
                    Id = student.Id,
                    FirstName = student.FirstName,
                    LastName = student.LastName,
                    EnrollmentDate = student.EnrollmentDate,
                    Department = student.Department
                };
                return await Task.Run(() => View("View", ViewModel));
            }
            return RedirectToAction("Index");
        }
        [HttpPost]
        public async Task<IActionResult>View(UpdateStudentViewModel model)
        {
            var student = await mVCDbContext.students.FindAsync(model.Id);
            if(student!=null)
            {
                student.FirstName = model.FirstName;
                student.LastName = model.LastName;
                student.EnrollmentDate = model.EnrollmentDate;
                student.Department = model.Department;
                await mVCDbContext.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }
        [HttpPost]
        public async Task<IActionResult>Delete(UpdateStudentViewModel model)
        {
            var student = await mVCDbContext.students.FindAsync(model.Id);
            if(student!=null)
            {
            mVCDbContext.students.Remove(student);
                await mVCDbContext.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }
      
    }
}
