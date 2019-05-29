using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyTest.Models;
using MyTest.Repositories;
using RepositoryAndUnitOfWork.DataAccess.Repositories;
using IdentityServer4.Services;

namespace MyTest.Controllers
{
    public class HomeController : Controller
    {
        protected readonly ICustomerService _customerService;
        protected readonly IUnitOfWork _uow;
        private readonly TodoContext _customerDbEntities;
        private readonly IIdentityServerInteractionService _interaction;


        public HomeController(ICustomerService customerService, IUnitOfWork uow, TodoContext customerDbEntities)
        {
            _customerService = customerService;
            _uow = uow;
            _customerDbEntities = customerDbEntities;
        }
        public object Index()
        {
            var tt = _customerService.GetBestCustomers();
            var std = _uow.Students.GetAllStudents();
                var courses = _customerDbEntities.Courses.Include(x => x.Student).ToList();
            return Ok(std);
        }

        

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
