using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using shopapp.business.Abstract;
using shopapp.entity;
using shopapp.webui.Extensions;
using shopapp.webui.Identity;
using shopapp.webui.Models;

namespace shopapp.webui.Controllers
{

    [Authorize(Roles="admin")]
    public class AdminController: Controller
    {
        private IProductService _productService;
        private ICategoryService _categoryService;
        private RoleManager<IdentityRole> _roleManager;
        private UserManager<User> _userManager;
        private IBrandService _brandService;
        public AdminController(IProductService productService,
                               ICategoryService categoryService,
                               IBrandService brandService,
                               RoleManager<IdentityRole> roleManager,
                               UserManager<User> userManager)
        {
            _productService = productService;
            _categoryService = categoryService;
            _brandService = brandService;
            _roleManager = roleManager;
            _userManager = userManager;
        }

         public IActionResult BrandList()
        {
            return View(new BrandListViewModel()
            {
                Brands = _brandService.GetAll()
            });
        }

        // Marka Oluşturma
        public IActionResult BrandCreate()
        {
            return View();
        }

        [HttpPost]
        public IActionResult BrandCreate(BrandModel model)
        {
            if (ModelState.IsValid)
            {
                var entity = new Brand()
                {
                    BrandName = model.BrandName,
                };

                _brandService.Create(entity);

                TempData.Put("message", new AlertMessage()
                {
                    Title = "Brand added successfully!",
                    Message = $"Added brand named {entity.BrandName}",
                    AlertType = "success"
                });

                return RedirectToAction("BrandList");
            }
            return View(model);
        }



        
        // public IActionResult BrandEdit(int? id)
        // {
        //     if (id == null)
        //     {
        //         return NotFound();
        //     }

        //     var entity = _brandService.GetById((int)id);

        //     if (entity == null)
        //     {
        //         return NotFound();
        //     }

        //     var model = new BrandModel()
        //     {
        //         BrandId = entity.BrandId,
        //         BrandName = entity.BrandName
        //     };
        //     return View(model);
        // }

    public IActionResult BrandEdit(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var entity = _brandService.GetById((int)id);
        if (entity == null)
        {
            return NotFound();
        }

        var products = _productService.GetProductsByBrandId((int)id)
                          ?.Select(p => new ProductModel 
                          {
                              ProductId = p.ProductId,
                              ImageUrl = p.ImageUrl,
                              Name = p.Name,
                              Price = p.Price,
                              BrandName = p.BrandName,
                              StockQuantity = p.StockQuantity,
                              IsApproved = p.IsApproved
                          }).ToList() ?? new List<ProductModel>();

        var model = new BrandModel()
        {
            BrandId = entity.BrandId,
            BrandName = entity.BrandName,
            Products = products
        };

        return View(model);
    }

    [HttpPost]
    public IActionResult BrandEdit(BrandModel model)
    {
        if (ModelState.IsValid)
        {
            var entity = _brandService.GetById(model.BrandId);
            if (entity == null)
            {
                return NotFound();
            }

            entity.BrandName = model.BrandName;
            _brandService.Update(entity);

            TempData.Put("message", new AlertMessage()
            {
                Title = "Brand updated successfully!",
                Message = $"The brand named {entity.BrandName} has been updated!",
                AlertType = "success"
            });

            return RedirectToAction("BrandList");
        }

        return View(model);
    }


        // [HttpPost]
        // public IActionResult BrandEdit(BrandModel model)
        // {
        //     if (ModelState.IsValid)
        //     {
        //         var entity = _brandService.GetById(model.BrandId);
        //         if (entity == null)
        //         {
        //             return NotFound();
        //         }
        //         entity.BrandName = model.BrandName;

        //         _brandService.Update(entity);

        //         TempData.Put("message", new AlertMessage()
        //         {
        //             Title = "Brand updated successfully!",
        //             Message = $"The brand named {entity.BrandName} has been updated!",
        //             AlertType = "success"
        //         });

        //         return RedirectToAction("BrandList");
        //     }
        //     return View(model);
        // }

        
        public IActionResult DeleteBrand(int brandId)
        {
            var entity = _brandService.GetById(brandId);

            if (entity != null)
            {
                _brandService.Delete(entity);

                var msg = new AlertMessage()
                {
                    Message = $"The brand named {entity.BrandName} has been deleted!",
                    AlertType = "danger"
                };

                TempData["message"] = JsonConvert.SerializeObject(msg);
            }

            return RedirectToAction("BrandList");
        }





        public async Task<IActionResult> UserEdit(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            if(user!=null)
            {
                var selectedRoles = await _userManager.GetRolesAsync(user);
                var roles = _roleManager.Roles.Select(i=>i.Name);

                ViewBag.Roles = roles;
                return View(new UserDetailsModel(){
                    UserId = user.Id,
                    UserName = user.UserName,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Email = user.Email,
                    EmailConfirmed = user.EmailConfirmed,
                    SelectedRoles = selectedRoles
                });
            }
            return Redirect("~/admin/user/list");
        }


        [HttpPost]
        public async Task<IActionResult> UserEdit(UserDetailsModel model,string[] selectedRoles)
        {
            if(ModelState.IsValid)
            {
                var user = await _userManager.FindByIdAsync(model.UserId);
                if(user!=null)
                {
                    user.FirstName = model.FirstName;
                    user.LastName = model.LastName;
                    user.UserName = model.UserName;
                    user.Email = model.Email;
                    user.EmailConfirmed = model.EmailConfirmed;

                    var result = await _userManager.UpdateAsync(user);

                    if(result.Succeeded)
                    {
                        var userRoles = await _userManager.GetRolesAsync(user);
                        selectedRoles = selectedRoles?? new string[]{};
                        await _userManager.AddToRolesAsync(user,selectedRoles.Except(userRoles).ToArray<string>());
                        await _userManager.RemoveFromRolesAsync(user,userRoles.Except(selectedRoles).ToArray<string>());

                        return Redirect("/admin/user/list");
                    }
                }
                return Redirect("/admin/user/list");
            }

            return View(model);

        }
        
        public IActionResult UserList()
        {
            return View(_userManager.Users);
        }

        public async Task<IActionResult> RoleEdit(string id)
        {
            var role = await _roleManager.FindByIdAsync(id);

            var members = new List<User>();
            var nonmembers = new List<User>();

            foreach (var user in _userManager.Users)
            {
                var list = await _userManager.IsInRoleAsync(user,role.Name)
                                ?members:nonmembers;
                list.Add(user);
            }
            var model = new RoleDetails()
            {
                Role = role,
                Members = members,
                NonMembers = nonmembers
            };
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> RoleEdit(RoleEditModel model)
        {
            if(ModelState.IsValid)
            {
                foreach (var userId in model.IdsToAdd ?? new string[]{})
                {
                    var user = await _userManager.FindByIdAsync(userId);
                    if(user!=null)
                    {
                        var result = await _userManager.AddToRoleAsync(user,model.RoleName);
                        if(!result.Succeeded)
                        {
                              foreach (var error in result.Errors)
                              { 
                                ModelState.AddModelError("", error.Description);  
                              }  
                        }
                    }
                }
          
                foreach (var userId in model.IdsToDelete ?? new string[]{})
                {
                    var user = await _userManager.FindByIdAsync(userId);
                    if(user!=null)
                    {
                        var result = await _userManager.RemoveFromRoleAsync(user,model.RoleName);
                        if(!result.Succeeded)
                        {
                              foreach (var error in result.Errors)
                              { 
                                ModelState.AddModelError("", error.Description);  
                              }  
                        }
                    }
                }
            }
            return Redirect("/admin/role/"+model.RoleId);
        }
        
        public IActionResult RoleList()
        {
            return View(_roleManager.Roles);
        }

        public IActionResult RoleCreate()
        {
            return View();
        }
        [HttpPost]        
        public async Task<IActionResult> RoleCreate(RoleModel model)
        {
            if(ModelState.IsValid)
            {
                var result = await _roleManager.CreateAsync(new IdentityRole(model.Name));
                if(result.Succeeded)
                {
                    return RedirectToAction("RoleList");
                }else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("",error.Description);
                    }
                }
            }
            return View(model);
        }
        
        
        public IActionResult ProductList()
        {
            return View(new ProductListViewModel()
            {
                Products = _productService.GetAll()
            });
        }
        public IActionResult CategoryList()
        {
            return View(new CategoryListViewModel()
            {
                Categories = _categoryService.GetAll()
            });
        }
        public IActionResult ProductCreate()
        {
            var productModel = new ProductModel();
            productModel.Brands = _brandService.GetAll(); 
            return View(productModel);
        }

        [HttpPost]
        public IActionResult ProductCreate(ProductModel model)
        {
            if(ModelState.IsValid)
            {
                var entity = new Product()
                {
                    Name = model.Name,
                    Url = model.Url,
                    Price = model.Price,
                    Description = model.Description,
                    ImageUrl = model.ImageUrl,
                    StockQuantity = model.StockQuantity,
                    BrandId = model.BrandId 
                };
                // _productService.Create(entity);
                
                if(_productService.Create(entity))
                {                    
                    TempData.Put("message", new AlertMessage()
                    {
                        Title="Record added successfully!",
                        Message="Record added successfully!",
                        AlertType="success"
                    });
                    return RedirectToAction("ProductList");
                }
                TempData.Put("message", new AlertMessage()
                {
                    Title="Error!",
                    Message=_productService.ErrorMessage,
                    AlertType="danger"
                });     
                
                 model.Brands = _brandService.GetAll(); // Markaları yeniden yükleyin
        return View(model);           

              
            }           
            model.Brands = _brandService.GetAll(); // Markaları yeniden yükleyin
    return View(model); 
               
        }
        public IActionResult CategoryCreate()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CategoryCreate(CategoryModel model)
        {
             if(ModelState.IsValid)
            {
                var entity = new Category()
                {
                    Name = model.Name,
                    Url = model.Url            
                };
                
                _categoryService.Create(entity);

                TempData.Put("message", new AlertMessage()
                {
                    Title="Record added successfully!",
                    Message=$" Added category named {entity.Name}",
                    AlertType="success"
                });             

                return RedirectToAction("CategoryList");
            }
            return View(model);
        }
        public IActionResult ProductEdit(int? id)
        {
            if(id==null)
            {
                return NotFound();
            }

            var entity = _productService.GetByIdWithCategories((int)id);

            if(entity==null)
            {
                 return NotFound();
            }

            var model = new ProductModel()
            {
                ProductId = entity.ProductId,
                Name = entity.Name,
                Url = entity.Url,
                Price = entity.Price,
                ImageUrl= entity.ImageUrl,
                Description = entity.Description,
                IsApproved = entity.IsApproved,
                IsHome = entity.IsHome,
                StockQuantity = entity.StockQuantity, 
                SelectedCategories = entity.ProductCategories.Select(i=>i.Category).ToList(),
                BrandId = entity.BrandId, // Marka Id'yi ekleyin
                Brands = _brandService.GetAll() 
            };

            ViewBag.Categories = _categoryService.GetAll();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> ProductEdit(ProductModel model,int[] categoryIds,IFormFile file)
        {
            if(ModelState.IsValid)
            {        
                var entity = _productService.GetById(model.ProductId);
                var brandname = _brandService.GetById(model.BrandId).BrandName;
                if(entity==null)
                {
                    return NotFound();
                }
                entity.Name = model.Name;
                entity.Price = model.Price;
                entity.Url = model.Url;
                entity.Description = model.Description;
                entity.IsHome = model.IsHome;
                entity.IsApproved = model.IsApproved;
                entity.StockQuantity = model.StockQuantity; 
                entity.BrandId = model.BrandId;
                entity.BrandName = brandname;

                if(file!=null)
                {
                    var extention = Path.GetExtension(file.FileName);
                    var randomName = string.Format($"{Guid.NewGuid()}{extention}");
                    entity.ImageUrl = randomName;
                    var path = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot\\img",randomName);

                    using(var stream = new FileStream(path,FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                    }
                }

                if(_productService.Update(entity,categoryIds))
                {                    
                     TempData.Put("message", new AlertMessage()
                    {
                        Title="Record Updated!",
                        Message="Record Updated!",
                        AlertType="success"
                    });  
                    return RedirectToAction("ProductList");
                }
                 TempData.Put("message", new AlertMessage()
                    {
                        Title="Error!",
                        Message=_productService.ErrorMessage,
                        AlertType="danger"
                    }); 
            }
            ViewBag.Categories = _categoryService.GetAll();
            model.Brands = _brandService.GetAll(); 
            return View(model);
        }
        public IActionResult CategoryEdit(int? id)
        {
            if(id==null)
            {
                return NotFound();
            }

            var entity = _categoryService.GetByIdWithProducts((int)id);

            if(entity==null)
            {
                 return NotFound();
            }

            var model = new CategoryModel()
            {
                CategoryId = entity.CategoryId,
                Name = entity.Name,
                Url = entity.Url,
                Products = entity.ProductCategories.Select(p=>p.Product).ToList()
            };
            return View(model);
        }
        
        [HttpPost]
        public IActionResult CategoryEdit(CategoryModel model)
        {
            if(ModelState.IsValid)
            {
                var entity = _categoryService.GetById(model.CategoryId);
                if(entity==null)
                {
                    return NotFound();
                }
                entity.Name = model.Name;
                entity.Url = model.Url;

                _categoryService.Update(entity);

                var msg = new AlertMessage()
                {            
                    Message = $"The category named {entity.Name}  has been updated!",
                    AlertType = "success"
                };

                TempData["message"] =  JsonConvert.SerializeObject(msg);

                return RedirectToAction("CategoryList");
            }
            return View(model);
        }
        public IActionResult DeleteProduct(int productId)
        {
            var entity = _productService.GetById(productId);

            if(entity!=null)
            {
                _productService.Delete(entity);
            }

              var msg = new AlertMessage()
            {            
                Message = $"The product named {entity.Name} has been deleted!",
                AlertType = "danger"
            };

            TempData["message"] =  JsonConvert.SerializeObject(msg);

            return RedirectToAction("ProductList");
        }
        public IActionResult DeleteCategory(int categoryId)
        {
            var entity = _categoryService.GetById(categoryId);

            if(entity!=null)
            {
                _categoryService.Delete(entity);
            }

              var msg = new AlertMessage()
            {            
                Message = $"The category named {entity.Name} has been deleted!",
                AlertType = "danger"
            };

            TempData["message"] =  JsonConvert.SerializeObject(msg);

            return RedirectToAction("CategoryList");
        }
    
        [HttpPost]
        public IActionResult DeleteFromCategory(int productId,int categoryId)
        {
            _categoryService.DeleteFromCategory(productId,categoryId);
            return Redirect("/admin/categories/"+categoryId);
        }

          public IActionResult UpdateStock(int id)
        {
            var product = _productService.GetById(id);
            if (product == null)
            {
                return NotFound();
            }

            var model = new ProductModel
            {
                ProductId = product.ProductId,
                Name = product.Name,
                StockQuantity = product.StockQuantity
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult UpdateStock(ProductModel model)
        {
            if (ModelState.IsValid)
            {
                var product = _productService.GetById(model.ProductId);
                if (product == null)
                {
                    return NotFound();
                }

                product.StockQuantity += model.StockQuantity;
                _productService.Update(product);

                TempData.Put("message", new AlertMessage()
                {
                    Title = "Stock Updated!",
                    Message = $"{product.Name} stock updated successfully!",
                    AlertType = "success"
                });

                return RedirectToAction("ProductList");
            }

            return View(model);
        }

    }
}