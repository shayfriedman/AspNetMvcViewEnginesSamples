using System;
using System.Text.RegularExpressions;
using System.Web.Mvc;
using Antlr3.ST;

namespace MvcDemo
{
    /// <summary>
    /// The ViewEngine for StringTemplate Views
    /// </summary>
    public class StringTemplateViewEngine : IViewEngine
    {
        #region Properties
        /// <summary>
        /// The default group that will hold the cached templates
        /// </summary>
        public static StringTemplateGroup Group { get; private set; }
        #endregion

        #region .ctors
        /// <summary>
        /// Creates a new instance of the StringTemplateViewEngine
        /// </summary>
        /// <param name="viewPath">The physical path to the root views directory</param>
        public StringTemplateViewEngine(string viewPath)
        {
            Group = new StringTemplateGroup("views", viewPath);
        }
        #endregion

        #region IViewEngine Members
        /// <summary>
        /// Locates a view.
        /// </summary>
        /// <param name="controllerContext"></param>
        /// <param name="partialViewName"></param>
        /// <param name="useCache"></param>
        /// <returns></returns>
        public ViewEngineResult FindPartialView(ControllerContext controllerContext, string partialViewName, bool useCache)
        {
            return LoadView(controllerContext, partialViewName);
        }

        /// <summary>
        /// Locates a view
        /// </summary>
        /// <param name="controllerContext"></param>
        /// <param name="viewName"></param>
        /// <param name="masterName"></param>
        /// <param name="useCache"></param>
        /// <returns></returns>
        public ViewEngineResult FindView(ControllerContext controllerContext, string viewName, string masterName, bool useCache)
        {
            return LoadView(controllerContext, viewName);
        }

        /// <summary>
        /// Loads a view instance from the Group object
        /// </summary>
        /// <param name="controllerContext">The calling controller</param>
        /// <param name="viewName">The name of the view</param>
        /// <returns>a ViewEngineResult</returns>
        private ViewEngineResult LoadView(ControllerContext controllerContext, string viewName)
        {
            //load template from loader
            StringTemplate template;
            var match = Regex.Match(viewName, "^~/?(.*)");
            if (match.Success)
            {
                template = Group.GetInstanceOf(match.Groups[1].Value);
            }
            else
            {
                var controllerName = controllerContext.Controller.GetType().Name.Replace("Controller", "");
                template = Group.GetInstanceOf(string.Format("{0}/{1}", controllerName, viewName));
            }

            //return view result
            return new ViewEngineResult(new StringTemplateView(template), this);
        }

        /// <summary>
        /// Not used. String templates are cached by the static group object.
        /// </summary>
        /// <param name="controllerContext"></param>
        /// <param name="view"></param>
        public void ReleaseView(ControllerContext controllerContext, IView view) { }
        #endregion
    }
}