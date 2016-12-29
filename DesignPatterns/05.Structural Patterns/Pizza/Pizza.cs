using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    public interface Pizza
    {
        string Description { get; }

        double Cost { get; }
    }


    /* 
    public abstract class Pizza{

	
	    public abstract void setDescription(String newDescription);
	    public abstract String getDescription();
	
	    public abstract void setCost(double newCost);
	    public abstract double getCost();
	
	    // I could use getter and setter methods for every 
	    // potential Pizza topping
	
    }
    */
}
