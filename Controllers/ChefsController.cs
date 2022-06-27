using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class ChefsController : ControllerBase
{
    List<Chef> chefs = new List<Chef>{
        new Chef(0, 5, "Spaghetti", "David", "Wernery"),
        new Chef(1, 10, "Pizza", "Zac", "Cooper"),
        new Chef(1, 10, "Burger", "Krescens", "Kok")
    };

    [HttpGet]
    public IActionResult Get()
    {

        return (
            Ok(chefs)
            );
    }
    [HttpGet("{Id}")]
    public IActionResult GetById(int id)
    {
        return Ok(chefs.Where(chefs => chefs.Id == id));

    }
    [HttpPost]
    public IActionResult AddChefs([FromBody] Chef chef)
    {
        chefs.Add(chef);

        return
        Created("/Chefs/{id}", chefs);
    }

    [HttpPut("{Id}")]
    public IActionResult ReplaceChefs([FromBody] Chef chef)
    {
        var chefRemove = chefs.Where(chefs => chefs.Id == chef.Id).FirstOrDefault();
        chefs.Remove(chefRemove);
        chefs.Add(chefRemove);
        return
        Ok(chefs);

    }
    [HttpPut("{Id}/ChefName")]
    public IActionResult ReplaceChefs(int id, [FromBody] Chef chef, string chefName)
    {
        var chefEdit = chefs.Where(chefs => chefs.Id == chef.Id).FirstOrDefault();
        chefs.Remove(chefEdit);
        chefEdit.FirstName = chefName;
        chefs.Add(chefEdit);
        return
        Ok(chefs);

    }
    [HttpPatch("{Id}")]
    public IActionResult UpdateChefs([FromBody] Chef chef)
    {
        var chefPatch = chefs.Where(chefs => chefs.Id == chef.Id).FirstOrDefault();
        chefs[chefPatch.Id] = chef;
        return
        Ok(chefs);
    }

    [HttpDelete("{Id}")]
    public IActionResult DeleteChefsById([FromBody] Chef chef)
    {
        var chefsDelete = chefs.Where(chefs => chefs.Id == chef.Id).FirstOrDefault();
        chefs.Remove(chefsDelete);
        return
        Ok(chefs);
    }
}

