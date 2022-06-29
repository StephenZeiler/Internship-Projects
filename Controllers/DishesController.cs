using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class DishesController : ControllerBase
{
    private RestaurantContext _dishContext;

    public DishesController(RestaurantContext context)
    {
        _dishContext = context;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Dish>> Get()
    {
        return _dishContext.Dish.ToList();
    }

    [HttpGet("{Id}")]
    public ActionResult<IEnumerable<Dish>> GetById(int id)
    {
        List<Dish> dishes = new List<Dish>();
        var dish = _dishContext.Dish.FirstOrDefault(t => t.Id == id);
        Console.WriteLine(dish);
        if (dish != null)
        {
            dishes.Add(dish);
        }

        return dishes.ToList();
    }

    [HttpPost]
    public void Post([FromBody] Dish values)
    {
        _dishContext.Dish.Add(values);
        _dishContext.SaveChanges();
    }

    [HttpDelete("{id}")]
    public void Delete(int id)
    {
        var dish = _dishContext.Dish.FirstOrDefault(t => t.Id == id);
        if (dish != null)
        {
            _dishContext.Dish.Remove(dish);
            _dishContext.SaveChanges();
        }
    }
    [HttpPut("{Id}")]
    public ActionResult<IEnumerable<Dish>> ReplaceDishes(int id)
    {
        var dish = _dishContext.Dish.FirstOrDefault(t => t.Id == id);
        List<Dish> dishes = new List<Dish>();
        if (dishes != null)
        {
            dishes.Add(dish);
        }
        return Ok(dishes);
    }

    [HttpPatch("{Id}")]
    public ActionResult<IEnumerable<Dish>> UpdateDishes([FromBody] Dish dish)
    {
        List<Dish> dishes = new List<Dish>();
        if (dishes != null)
        {
            dishes.Add(dish);
            var dishPatch = dishes.Where(dishes => dishes.Id == dish.Id).FirstOrDefault();
            dishes[dishPatch.Id] = dish;
        }
        return Ok(dishes);
    }
}


