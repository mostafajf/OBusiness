
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


using OBusiness.Core.Domain.Models;
using OBusiness.Core.Dto;

namespace Abacus.SelfOrder.App.ObjectFactory
{
    public class MenuFactory
    {

        public List<MenuDto> ToMenuDto(List<Menu> menus)
        {
            var menuDtos = new List<MenuDto>();
            foreach (var menu in menus)
            {
                menuDtos.Add(CreateMenu(menu));
            }
            return menuDtos;
        }

        private MenuDto CreateMenu(Menu menu)
        {
            MenuDto menuDto = new MenuDto();
            var categories = new List<CategoryDto>();
            menuDto.Categories = ListCategories(menu.Doc);
            menuDto.MenuID = menu.Doc.MenuID;
            return menuDto;
        }

        private List<CategoryDto> ListCategories(MenuDoc menu)
        {
            var categorieDtos = new List<CategoryDto>();
            foreach (var category in menu.Categories)
            {
                var categoryDto = CategoryToCategoryDto(category, menu.Products);

                var productDtos = new List<ProductDto>();
                var productIds = category.SubMenuItems.Select(sub => sub.ProductID).ToList();
                var products = menu.Products.Where(p => productIds.Contains(int.Parse(p.Key)));
                foreach (var product in products)
                {
                    var pp = product.Value;
                    var pDto = new ProductDto
                    {
                        ID = int.Parse(product.Key),
                        DisplayOrder = pp.DisplayOrder,
                        FullDescription = pp.FullDescription,
                        Name = pp.Name,
                        PhotoUrl = pp.PhotoUrl,
                        ProductCode = pp.ProductCode,
                        ShortDescription = pp.ShortDescription,
                        Status = pp.Status ?? 0,
                        TaxRate = pp.TaxRate,
                        ProductCategoryIDs = pp.ProductCategoryNames,
                        ProductTagIDs = pp.ProductTagIDs,
                    };
                    pDto.ModifierGroups = ModifierList(menu, product.Value, pDto);

                    var categoryProduct = category.SubMenuItems.FirstOrDefault(sItem => sItem.ProductID == pDto.ID);
                    pDto.Price = categoryProduct.Price.Value;
                    pDto.Name = categoryProduct.Name;
                    productDtos.Add(pDto);
                }

                categoryDto.Products.AddRange(productDtos);
                if (category.SubMenuItems.Any())
                {
                    categorieDtos.Add(categoryDto);
                }
            }

            return categorieDtos;
        }

        private CategoryDto CategoryToCategoryDto(Category category, Dictionary<string, Product> products)
        {
            var categoryDto = new CategoryDto
            {
                ID = category.ID,
                Name = category.Name
            };

            return categoryDto;
        }

        public List<ModifierGroupDto> ModifierList(MenuDoc menu, Product product, ProductDto productDto)
        {
            var modifierGroupsList = new List<ModifierGroupDto>();
            var productModifierGroups = menu.ModifierGroups.Where(mg => product.ModifierGroups.Contains(mg.Key)).OrderBy(o => o.Value.DisplayOrder);
            foreach (var item in productModifierGroups)
            {
                var mgDto = ModifierGrouptoModifierGroupDto(item.Key, item.Value, menu, false);
                mgDto.Product = productDto;
                modifierGroupsList.Add(mgDto);
            }

            return modifierGroupsList;
        }

        private ModifierGroupDto ModifierGrouptoModifierGroupDto(string key, ModifierGroup mg, MenuDoc menu, bool cancel)
        {
            if (mg.MaximumSelection == 0)
            {
                mg.MaximumSelection = null;
            }

            if (mg.MaximumSelection.HasValue && mg.MinimumSelection.HasValue && mg.MaximumSelection.Value < mg.MinimumSelection.Value)
            {
                mg.MaximumSelection = mg.MinimumSelection;
            }

            var mgDto = new ModifierGroupDto
            {
                ID = key,
                DisplayOrder = mg.DisplayOrder,
                IsAutoSel = mg.IsAutoSel,
                IsForceSel = mg.IsForceSel,
                IsSingleSel = mg.IsSingleSel,
                IsCollapsed = mg.IsCollapsed.HasValue ? mg.IsCollapsed.Value : false,
                Name = mg.Name,
                IsPromptSel = mg.IsPromptSel.HasValue ? mg.IsPromptSel.Value : false,
                MaximumSelection = mg.MaximumSelection,
                MinimumSelection = mg.MinimumSelection,
                IncludeQuantity = mg.IncludeQuantity,
            };
            foreach (var mod in mg.Modifiers.OrderBy(o => o.DisplayOrder))
            {
                var mDto = new ModifierDto
                {
                    Code = mod.Code,
                    DisplayName = mod.DisplayName,
                    DisplayOrder = mod.DisplayOrder,
                    ID = mod.ID,
                    MaxQty = mod.MaxQty,
                    MinQty = mod.MinQty,
                    Name = mod.Name,
                    Status = mod.Status,
                    OldState = mod.Status,
                    PhotoUrl = mod.PhotoURL,
                    Price = mod.Price,
                    TaxRate = mod.TaxRate,
                    LinkedProductID = mod.LinkedProductId,
                    ModifierGroupId = int.Parse(mgDto.ID),
                    ModifierGroup = mgDto,
                };
                if (!string.IsNullOrEmpty(mod.LinkedProductId))
                {
                    var linkedProduct = menu.Products.Where(p => p.Key == mod.LinkedProductId).FirstOrDefault();
                    if (linkedProduct.Key != null)
                    {
                        mDto.Status = linkedProduct.Value.Status ?? 0;
                        mDto.OldState = linkedProduct.Value.Status == 3 ? 0 : linkedProduct.Value.Status;
                        if (!cancel)
                        {
                            var linkedModifierGroups = menu.ModifierGroups.Where(group => linkedProduct.Value.ModifierGroups.Contains(group.Key)).OrderBy(o => o.Value.DisplayOrder);
                            foreach (var linkedGroup in linkedModifierGroups)
                            {
                                var currentMdg = ModifierGrouptoModifierGroupDto(linkedGroup.Key, linkedGroup.Value, menu, true);
                                mDto.SubModifiers.Add(currentMdg);
                                currentMdg.ParentModifier = mDto;
                            }
                        }
                    }
                }

                mgDto.ModifiersList.Add(mDto);
            }

            return mgDto;
        }

    }
}
