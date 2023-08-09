using GMINWEB_Rebuild.Model;
using System;
using System.Collections.Generic;

namespace GMINWEB_Rebuild
{
    public interface IMenuService
    {
        IEnumerable<Menu> Menus { get; }

        IEnumerable<Menu> Filter(string term);
        Menu FindCurrent(Uri uri);
        string TitleFor(Menu menu);
    }
}