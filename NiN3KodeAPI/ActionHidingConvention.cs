using Microsoft.AspNetCore.Mvc.ApplicationModels;
using System.Collections;

namespace NiN3KodeAPI
{
    public class ActionHidingConvention : IActionModelConvention
    {

        private readonly System.Collections.ArrayList _controllers_to_exclude;

        public ActionHidingConvention(ArrayList controllers_to_exclude)
        {
            _controllers_to_exclude = controllers_to_exclude;
        }

        public void Apply(ActionModel action)
        {
            // Replace with any logic you want
            if (_controllers_to_exclude.Contains(action.Controller.ControllerName))
            {
                action.ApiExplorer.IsVisible = false;
            }
        }
    }
}
