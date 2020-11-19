using System;
namespace Planner{
    public class Building{
        public Building(){

        }
        public Building(string address){
            _address=address;
        }

        private string _designer="Austin Ring";
        private DateTime _dateConstructed{get; set;}
        private string _address{get; set;}
        private string _owner{get; set;}
        public int Stories{get; set;}
        public double Width{get; set;}
        public double Depth{get; set;}
        public double Volume{
            get{
                return Width*Depth*(3*Stories);
            }
        }
        public void Construct(){
            _dateConstructed=DateTime.Now;
        }
        public void Purchase(string owner){
            _owner=owner;
        }
        public void toString(){
            System.Console.WriteLine(_address);
            System.Console.WriteLine("---------------");
            System.Console.WriteLine($"Designed by {_designer}");
            System.Console.WriteLine($"Constructed on {_dateConstructed}");
            System.Console.WriteLine($"Owned by {_owner}");
            System.Console.WriteLine($"{Volume} cubic meter os space");
            System.Console.WriteLine();
        }
    }
}