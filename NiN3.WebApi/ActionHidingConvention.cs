using Microsoft.AspNetCore.Mvc.ApplicationModels;
using System.Collections;

namespace NiN3.WebApi;



// This class implements the IActionModelConvention interface and is used to hide actions from the routing system. It checks if the action is marked with the [Hidden] attribute and sets the IsHidden property of the ActionModel to true if it is. This prevents the action from being included in the routing system.
public class ActionHidingConvention : IActionModelConvention
{

    private readonly System.Collections.ArrayList _controllers_to_exclude;

    // This code creates a constructor for the ActionHidingConvention class, which takes an ArrayList of controllers to exclude as an argument. 
    public ActionHidingConvention(ArrayList controllers_to_exclude)
    {
        // Assign the argument to the class variable _controllers_to_exclude
        _controllers_to_exclude = controllers_to_exclude;
    }

    // This method applies a given action to a controller
    public void Apply(ActionModel action)
    {
        // Check if the controller name is in the list of controllers to exclude
        if (_controllers_to_exclude.Contains(action.Controller.ControllerName))
        {
            // If so, set the ApiExplorer visibility to false
            action.ApiExplorer.IsVisible = false;
        }
    }
}
