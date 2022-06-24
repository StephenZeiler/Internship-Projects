using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class DishesController : ControllerBase
{
    List<Dish> dishes = new List<Dish>{ //why cant I add dishes to list using add or listing their names?? 
        new Dish(0, 60, new string[] {"tomatoes", "onions", "ground beef", "marinara", "cheese"}, "prep, cook, eat after 10 minutes", "Spaghetti"),
        new Dish(1, 25, new string[] {"tomatoes", "pepperoni", "olives", "marinara", "peppers"}, "perheat oven, cook, enjoy!", "Pizza"),
        new Dish(2, 35, new string[] {"tomatoes", "lettuce", "mustard", "ketchup", "bun", "ground beef"}, "preheat grill, cook, add condiments, eat", "Burger")
    };

    [HttpGet]
    public IActionResult Get()
    {

        return (
            Ok(dishes)
            );
    }
    [HttpGet("{Id}")]
    public IActionResult GetById(int id)
    {
        return Ok(dishes.Where(dishes => dishes.Id == id));

    }
    [HttpPost]
    public IActionResult AddDishes([FromBody] Dish dish)
    {
        dishes.Add(dish);

        return
        Created("/Dishes/{id}", dishes);
    }

    [HttpPut("{Id}")]
    public IActionResult ReplaceDishes([FromBody] Dish dish)
    {
        var dishRemove = dishes.Where(dishes => dishes.Id == dish.Id).FirstOrDefault();
        dishes.Remove(dishRemove);
        dishes.Add(dishRemove);
        return
        Ok(dishes);

    }
    [HttpPut("{Id}/DishName")]
    public IActionResult ReplaceDishes(int id, [FromBody] Dish dish, string dishName)
    {
        var dishEdit = dishes.Where(dishes => dishes.Id == dish.Id).FirstOrDefault();
        dishes.Remove(dishEdit);
        dishEdit.DishName = dishName;
        dishes.Add(dishEdit);
        return
        Ok(dishes);

    }
    [HttpPatch("{Id}")]
    public IActionResult UpdateDishes([FromBody] Dish dish)
    {
        var dishPatch = dishes.Where(dishes => dishes.Id == dish.Id).FirstOrDefault();
        dishes[dishPatch.Id] = dish;
        return
        Ok(dishes);
    }
    [HttpDelete("{Id}")]
    public IActionResult DeleteDishesById([FromBody] Dish dish)
    {
        var dishesDelete = dishes.Where(dishes => dishes.Id == dish.Id).FirstOrDefault();
        dishes.Remove(dishesDelete);
        Console.WriteLine(dishes.Count);

        return
        Ok(dishes);
    }
}


