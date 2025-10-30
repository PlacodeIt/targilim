using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication1
{
    class Car
    {
        //attributes
        string _color, _model;
        int _price;
        bool _sold;
        const int MIN_PRICE = 50;
        //c-tors
        Car (string color, string model) 
        {
            _color=color; 
            _model=model; 
	         
        }

        Car(string color, string model, int price)
        {
            _color = color;
            _model = model;
            _price = price;
            
        }
        //methods
        string GetColor() 
        {
            return _color;
        }
        
        string GetModel() 
        {
            return _model;
        } 
        
        void SetPrice(int price) 
        {
            _price = price; 
        }

        int GetPrice()
        {
            return _price;
        }

        void PrintDetails () 
        {
	        Console.WriteLine(_color +" "+_model+ ":"+ _price);  
        }

        bool Sell() 
        {
            if (!_sold  && _price > MIN_PRICE)
            {
                _sold = true;
                PrintDetails();
                return _sold;
            }
            else return _sold;
        }
	    
        public static void Main(string[] args) 
        {
            Console.WriteLine("please enter the color of the car");
            string color = Console.ReadLine();
		    Car c = new Car ( color, "Mazda"); 
		    c.SetPrice(100);
		    bool sold = c.Sell(); 
            if (sold)
                Console.WriteLine("sold: Mazda " + c.GetColor());
            Car d = new Car (color, "BMW",140);
            d.PrintDetails();
            d.SetPrice(200);
            d.PrintDetails();
            d.SetPrice(300);
            d.PrintDetails();
            //string s = c.GetColor();
            Console.WriteLine("the BMW is: " + c.GetColor());
            //get cars in the loop, cell the first car which is more expensive than d and exit
            while (true)
            {
                Console.WriteLine("Please enter the color, model and price of the car");
                c = new Car(Console.ReadLine(), Console.ReadLine(), int.Parse(Console.ReadLine()));
                //int price1 = d.GetPrice();
                //int price2 = c.GetPrice();
                //if (price1 < price2)
                if (d.GetModel() == c.GetModel() && d.GetColor() == c.GetColor() && d.GetPrice() < c.GetPrice())
                {
                    if (c.Sell())
                        break;
                }
            }
            Console.ReadKey();
        }
    } 
}
