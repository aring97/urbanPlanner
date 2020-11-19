using System;
using System.Collections.Generic;
namespace Planner{
    public class City{
    public City(){}
    public City(String name, string mayor){
        _name=name;
        _mayor=mayor;
        _established=DateTime.Now;
    }
    private string _name {get; set;}
    private string _mayor{get; set;}
    private DateTime _established{get; set;}
    public List<Building> Buildings{get;}=new List<Building>();
    public void addBuilding(Building building){
        Buildings.Add(building);
    }
    
    }
}