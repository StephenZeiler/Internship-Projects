using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class ChefsController : ControllerBase
{

    private RestaurantContext _chefContext;

    public ChefsController(RestaurantContext context)
    {
        _chefContext = context;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Chef>> Get()
    {
        return _chefContext.Chef.ToList();
    }

    [HttpGet("{Id}")]
    public ActionResult<IEnumerable<Chef>> GetById(int id)
    {
        List<Chef> chefs = new List<Chef>();
        var chef = _chefContext.Chef.FirstOrDefault(t => t.Id == id);
        Console.WriteLine(chef);
        if (chef != null)
        {
            chefs.Add(chef);
        }

        return chefs.ToList();
    }

    [HttpPost]
    public void Post([FromBody] Chef values)
    {
        _chefContext.Chef.Add(values);
        _chefContext.SaveChanges();
    }

    [HttpDelete("{id}")]
    public void Delete(int id)
    {
        var chef = _chefContext.Chef.FirstOrDefault(t => t.Id == id);
        if (chef != null)
        {
            _chefContext.Chef.Remove(chef);
            _chefContext.SaveChanges();
        }
    }
    [HttpPut("{Id}")]
    public ActionResult<IEnumerable<Chef>> ReplaceChefs(int id)
    {
        var chef = _chefContext.Chef.FirstOrDefault(t => t.Id == id);
        List<Chef> chefs = new List<Chef>();
        if (chefs != null)
        {
            chefs.Add(chef);
        }
        return Ok(chefs);
    }

    [HttpPatch("{Id}")]
    public ActionResult<IEnumerable<Chef>> UpdateChef([FromBody] Chef chef)
    {
        List<Chef> chefs = new List<Chef>();
        if (chefs != null)
        {
            chefs.Add(chef);
            var chefPatch = chefs.Where(chefs => chefs.Id == chef.Id).FirstOrDefault();
            chefs[chefPatch.Id] = chef;
        }
        return Ok(chefs);
    }
}

