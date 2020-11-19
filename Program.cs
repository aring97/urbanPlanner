using System;

namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            Building one=new Building("111 1st Street");
            one.Width=1;
            one.Depth=1;
            one.Stories=1;
            one.Construct();
            one.Purchase("Mr. Alpha");
            Building two=new Building("222 2nd Street");
            two.Width=2;
            two.Depth=2;
            two.Stories=2;
            two.Construct();
            two.Purchase("Mr. Bravo");
            Building three=new Building("333 3rd Street");
            three.Width=3;
            three.Depth=3;
            three.Stories=3;
            three.Construct();
            three.Purchase("Mr. Charlie");
            Building four=new Building("444 4th Street");
            four.Width=4;
            four.Depth=4;
            four.Stories=4;
            four.Construct();
            four.Purchase("Mr. Delta");

            City cityOne=new City("City one", "Mr. First");
            cityOne.addBuilding(one);
            cityOne.addBuilding(two);
            cityOne.addBuilding(three);
            cityOne.addBuilding(four);
            foreach(Building Building in cityOne.Buildings){
                Building.toString();
            }
        }
    }
}
