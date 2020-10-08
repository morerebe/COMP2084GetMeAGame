using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using COMP2084GetMeAGame.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

public class CategoriesController : Controller
{
    // GET: /<controller>/
    public IActionResult Index()
    {
        //use our category model & fake datat to pass to the view
        // make an empty list of categories
        var categories = new List<Category>();

        //use a loop to make 10 categories & add each one to the list
        for (var i = 1; i <= 10; i++)
        {
            categories.Add(new Category { Id = i, Name = "Category " + i.ToString() });
        }
        // pass the categories list to the view for display
        return View(categories);
    }

    public IActionResult Browse(string categoryName)
    {

        // take the category name passed in with the link & store it in the view bag for display
        ViewBag.categoryName = categoryName;

        // load the view / Views/Categories/Browse
        return View();
    }

    public IActionResult AddCategory()
    {
        //display an empty form where a user could add a new category
        return View();
    }
}