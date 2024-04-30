using System;


namespace R5T.R0015.Construction.Client
{
    public class PageRoutes : IPageRoutes
    {
        #region Infrastructure

        public static IPageRoutes Instance { get; } = new PageRoutes();


        private PageRoutes()
        {
        }

        #endregion
    }
}
