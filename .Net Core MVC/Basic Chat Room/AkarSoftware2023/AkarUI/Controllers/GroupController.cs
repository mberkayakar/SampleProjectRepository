using AkarBusiness.Abstract;
using AkarEntities.Dtos;
using AkarEntities.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AkarUI.Controllers
{
    public class GroupController : Controller
    {
        private readonly IGroupService _groupService;
        private readonly IUserService _userservice;

        public GroupController(IGroupService groupService, IUserService userservice)
        {
            _groupService = groupService;
            _userservice = userservice;

        }
        public IActionResult Index()
        {
            if (HttpContext.User.Identity.IsAuthenticated == true)
            {
                // Sistemde bir user var 
                var model = _groupService.GroupList(x => x.GecerliFlg == true, include: new System.Linq.Expressions.Expression<System.Func<Group, object>>[] { x => x.MembersList });
                var username = HttpContext.User.Claims.FirstOrDefault().Value;

                foreach (var item in model)
                {
                    foreach (var item2 in item.MembersList)
                    {
                        if (item2.UserName == username || item.IsPublicOrPrivate == false )
                        {
                            item.KatilimSaglanabilirmi = false;
                        }
                        else
                        {
                            item.KatilimSaglanabilirmi = true;
                        }
                    }
                }
               
                return View(model);
            }
            else
            {
                // Sistemde bir user yok ziyaretçi modu 
                var model = _groupService.GroupList(x => x.GecerliFlg == true, include: new System.Linq.Expressions.Expression<System.Func<Group, object>>[] { x => x.MembersList });
                return View(model);
            }
        }


        [HttpPost]
        public IActionResult CreateGroup(CreateGroupDto dto)
        {
            var username = HttpContext.User.Claims.FirstOrDefault().Value;
            var user = _userservice.Get(x => x.UserName == username);
            if (user != null)
            {
                Group grup = new Group
                {
                    MembersList = new List<User> { user },
                    GroupName = dto.GroupName,
                    IsPublicOrPrivate = (dto.IsPublicOrPrivate == "on") ? true : false,
                };

                _groupService.Add(grup);
                return RedirectToAction("Index", "Group");
            }
            else
            {
                return NotFound();
            }

        }
    }
}


