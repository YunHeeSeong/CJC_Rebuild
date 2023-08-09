using GMINWEB_Rebuild.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GMINWEB_Rebuild
{
    public class MenuService : IMenuService
    {
        Menu[] allMenus = new[] {
            new Menu()
            {
                Name = "홈",
                Path = "/",
                Icon = "&#xe88a"
            },
            new Menu()
            {
                Name = "시스템관리",
                Path = "/",
                Icon = "&#xe84e",
                 Children = new [] {
                    new Menu
                    {
                        Name = "사용자등록",
                        Path="/UserManagment",
                    },
                    new Menu
                    {
                        Name = "사용자조회",
                        Path="/ReadUser",
                    },
                   new Menu
                    {
                        Name = "매장등록",
                        Path = "/BizUnitManagement_store",
                    },
                   new Menu
                    {
                        Name = "매장조회",
                        Path = "/ReadBizUnitStore",
                    },
                    new Menu
                    {
                        Name = "공장등록",
                        Path = "/BizUnitManagement_factory",
                    },
                    new Menu
                    {
                        Name = "공장조회",
                        Path = "/ReadBizUnitFactory",
                    },
                    new Menu
                    {
                        Name = "권한등록",
                        Path = "/RoleManagment",
                    },
                    new Menu
                    {
                        Name = "권한조회",
                        Path = "/ReadRole",
                    },
                    new Menu
                    {
                        Name = "조직등록",
                        Path = "/GroupManagement",
                    },
                  new Menu
                    {
                        Name = "조직조회",
                        Path = "/ReadGroup",
                    },
                    new Menu
                    {
                        Name = "공통코드등록",
                        Path = "/CommonCodeManagement",
                    },
                    new Menu
                    {
                        Name = "공통코드조회",
                        Path = "/ReadCommonCode",
                    },
                    new Menu
                    {
                        Name = "공지사항등록",
                        Path = "/NoticeManagement",
                    },
                    new Menu
                    {
                        Name = "공지사항조회",
                        Path = "/ReadNotice",
                    },
                    new Menu
                    {
                        Name = "파일관리",
                        Path = "/FileManagement",
                    },
                }
            },
            new Menu
            {
                Name = "생산관리",
                Path = "/",
                Icon="construction",
                 Children = new [] {
                    new Menu
                    {
                        Name = "생산계획등록",
                        Path = "/WorkPlanManagement",
                    },
                    new Menu
                    {
                        Name = "생산계획조회",
                        Path = "/ReadWorkPlan",
                    },
                    new Menu
                    {
                        Name = "작업지시등록",
                        Path = "/WorkOrderManagement",
                    },
                    new Menu
                    {
                        Name = "작업지시조회",
                        Path = "/ReadWorkOrder",
                    },
                    new Menu
                    {
                        Name = "생산실적등록",
                        Path = "/WorkManagement",
                    },
                    new Menu
                    {
                        Name = "생산실적조회",
                        Path = "/ReadWork",
                    },
                }
            },
            new Menu
            {
                Name = "구매/재고관리",
                Path = "/",
                Icon="shopping_cart",
                Children = new []
                {
                    new Menu
                    {
                        Name = "발주서등록",
                        Path = "/pOrderManagement",
                    },
                    new Menu
                    {
                        Name = "발주서조회",
                        Path = "/ReadpOrder",
                    },
                   new Menu
                    {
                        Name = "발주서상세조회",
                        Path = "/ReadPOrderDetail",
                    },
                    new Menu
                    {
                        Name = "구매입고등록",
                        Path = "POInItemManagement",
                    },
                    new Menu
                    {
                        Name = "구매입고조회",
                        Path = "ReadPOInItem",
                    },
                   new Menu
                    {
                        Name = "출하등록(공장)",
                        Path = "/FactOutItemManagement",
                    },
                   new Menu
                    {
                        Name = "출하조회(공장)",
                        Path = "/ReadFactOutItem",
                    },
                    new Menu
                    {
                        Name = "출하등록(매장)",
                        Path = "/StoreOutItemManagement",
                    },
                    new Menu
                    {
                        Name = "출하조회(매장)",
                        Path = "/ReadStoreOutItem",
                    },
                   new Menu
                    {
                        Name = "매장별재고실사",
                        Path = "/StoreInventoryCheck",
                    },
                   new Menu
                    {
                        Name = "매장별재고현황",
                        Path = "/StoreInventory",
                    },
                   new Menu
                    {
                        Name = "공장별재고실사",
                        Path = "/FactInventoryCheck",
                    },
                    new Menu
                    {
                        Name = "공장별재고현황",
                        Path = "/FactInventory",
                    },
                   new Menu
                    {
                        Name = "전체재고현황",
                        Path = "/ALLInventory",

                    },
                }
            },
            new Menu
            {
                Name = "품목관리",
                Path = "/",
                Icon="category",
                 Children = new []
                {
                    new Menu
                    {
                        Name = "제품등록",
                        Path = "/PDItemManagement",
                    },
                    new Menu
                    {
                        Name = "제품조회",
                        Path = "/ReadPDItem",
                    },
                    new Menu
                    {
                        Name = "품목등록",
                        Path = "/ItemManagement",
                    },
                    new Menu
                    {
                        Name = "품목조회",
                        Path = "/ReadItem",
                    },
                    new Menu
                    {
                        Name = "BOM등록",
                        Path = "/BomManagement",
                    },
                    new Menu
                    {
                        Name = "BOM조회",
                        Path = "/ReadBom",
                    },
                }
            },
            new Menu
            {
                Name = "고객관리",
                Path = "/",
                Icon="groups",
                Children = new []
                {
                    new Menu
                    {
                        Name = "고객등록",
                        Path = "/CustomerManagement",
                    },
                    new Menu
                    {
                        Name = "고객조회",
                        Path = "/ReadCustomer",
                    },
                    new Menu
                    {
                        Name = "주문현황모니터링",
                        Path = "/OrderMonitoring",
                    },
                    new Menu
                    {
                        Name = "주문등록(제품)",
                        Path = "/OrderManagement",
                    },
                    new Menu
                    {
                        Name = "주문조회(제품)",
                        Path = "/ReadOrder",
                    },
                    new Menu
                    {
                        Name = "주문등록(품목)",
                        Path = "/ItemOrderManagement",
                    },
                    new Menu
                    {
                        Name = "주문조회(품목)",
                        Path = "/ReadItemOrder",
                    },
                    new Menu
                    {
                        Name = "이용이력등록",
                        Path = "/CustHisManagement",
                    },
                    new Menu
                    {
                        Name = "이용이력조회",
                        Path = "/ReadCustHis",
                    },
                    new Menu
                    {
                        Name = "AS등록",
                        Path = "/ASManagement",
                    },
                    new Menu
                    {
                        Name = "AS조회",
                        Path = "/ReadAS",
                    },
                    new Menu
                    {
                        Name = "VOC등록",
                        Path = "/VOCManagement",
                    },
                    new Menu
                    {
                        Name = "VOC조회",
                        Path = "/ReadVOC",
                    },
                }
            },
            new Menu
            {
                Name = "영업관리",
                Path = "/",
                Icon="speaker_notes",
                Children = new []
                {
                    new Menu
                    {
                        Name = "전체매출현황등록",
                        Path = "/AllSales",
                    },
                    new Menu
                    {
                        Name = "매장별매출현황조회",
                        Path = "/StoreSales",
                    },
                    new Menu
                    {
                        Name = "공장별매출현황조회",
                        Path = "/FactSales",
                    },
                }
            },
         };

        public IEnumerable<Menu> Menus
        {
            get
            {
                return allMenus;
            }
        }

        public IEnumerable<Menu> Filter(string term)
        {
            bool contains(string value) => value.Contains(term, StringComparison.OrdinalIgnoreCase);

            bool filter(Menu menu) => contains(menu.Name) || (menu.Tags != null && menu.Tags.Any(contains));

            bool deepFilter(Menu menu) => filter(menu) || menu.Children?.Any(filter) == true;

            return Menus.Where(category => category.Children?.Any(deepFilter) == true)
                           .Select(category => new Menu
                           {
                               Name = category.Name,
                               Expanded = true,
                               Children = category.Children.Where(deepFilter).Select(menu => new Menu
                               {
                                   Name = menu.Name,
                                   Path = menu.Path,
                                   Icon = menu.Icon,
                                   Expanded = true,
                                   Children = menu.Children
                               }
                               ).ToArray()
                           }).ToList();
        }

        public Menu FindCurrent(Uri uri)
        {
            return Menus.SelectMany(menu => menu.Children ?? new[] { menu })
                           .FirstOrDefault(menu => menu.Path == uri.AbsolutePath || $"/{menu.Path}" == uri.AbsolutePath);
        }

        public string TitleFor(Menu menu)
        {
            if (menu != null && menu.Name != "홈")
            {
                return menu.Title ?? $" {menu.Name} | ";
            }

            return "by GMIN";
        }

    }
}
