using Microsoft.AspNetCore.Mvc;
using StudentLearningHub.Models;

namespace StudentLearningHub.Controllers;

public class CoursesController : Controller
{
    // Lab 1: This is temporary in-memory sample data.
    private static readonly List<Course> Courses =
    [
        new(1, "ASP.NET Core MVC", "Controllers, routing and Razor views", 8),
        new(2, "C# Fundamentals", "Classes, collections and LINQ", 10),
        new(3, "Databases", "Relational data and SQL", 6)
    ];

    public IActionResult Index()
    {
        return View(Courses);
    }

    // TODO LAB 1, TASK 1:
    // Implement public IActionResult Details(int id).
    // Return NotFound() if there is no matching course.
    // Otherwise return View(course).

    // TODO LAB 1, TASK 2:
    // Implement public IActionResult ByDuration(int minWeeks).
    // Filter Courses by DurationWeeks >= minWeeks.
    // Return View("Index", filteredCourses).
}
