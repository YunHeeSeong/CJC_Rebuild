using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Net;
using System.IO;
using DataAccessLibrary;
using DataAccessLibrary.Model;
using System.Net.Sockets;
using Microsoft.AspNetCore.WebUtilities;
using System.Text;
using DataAccessLibrary.Data;
using System.Security.Claims;

namespace GMINWEB_CJC.Areas.Identity.Pages.Account
{

    [AllowAnonymous]
    public class foundPWDModel : PageModel
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly ILogger<LoginModel> _logger;
        private readonly IUserData _db;
        //ClaimsPrincipal CurrentUser;
        public List<UserModel> userList;
        public foundPWDModel(SignInManager<IdentityUser> signInManager,
            ILogger<LoginModel> logger,
            UserManager<IdentityUser> userManager,
            IUserData db)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _db = db;
        }

        [BindProperty]
        public InputModel Input { get; set; }
      
        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        public string ReturnUrl { get; set; }
        public  UserModel userModel { get; set; }

        [TempData]

        public string ErrorMessage { get; set; }
        [TempData]
        public string StatusMessage { get; set; }

        public class InputModel
        {
            [Required(ErrorMessage = "이메일을 입력하여 주십시오.")]
            [EmailAddress(ErrorMessage = "올바른 이메일 형식으로 입력하여 주십시오.")]
            public string Email { get; set; }

            //public string Code { get; set; }
            public string Password { get; set; } //패스워드 정보 
        }

        public class UserModel
        {
            public string Password { get; set; }
            
        }

        public async Task OnGetAsync(string returnUrl = null)
        {
            if (!string.IsNullOrEmpty(ErrorMessage))
            {
                ModelState.AddModelError(string.Empty, ErrorMessage);
            }

            returnUrl ??= Url.Content("~/");

            // Clear the existing external cookie to ensure a clean login process
            await HttpContext.SignOutAsync(IdentityConstants.ExternalScheme);

            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();

            ReturnUrl = returnUrl;
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl)
        {
            returnUrl ??= Url.Content("~/");
            try
            {
                List<DataAccessLibrary.Model.UserModel> userModels = await _db.PasswordInfo(Input.Email); // List<UserModel> usermodels
                StatusMessage = Input.Email + "님의 비밀번호는: " + userModels[0].LoginPw + "입니다."; //LoginPW정보만 가져오기때문에 [0]번째 index 고정
                return RedirectToPage(); //현재 페이지로 리다이렉션 

            }catch(Exception ex)
            {
                StatusMessage = "등록된 회원이아닙니다.";
            }

            // If we got this far, something failed, redisplay form (실패시 form 다시로드)
            return Page();

        }

        //public string GetEncodePassword(string s) //랜덤으로 생성된 텍스트를 인코딩
        //{

        //    byte[] bytes = Encoding.Unicode.GetBytes(s);
        //    string base64 = Convert.ToBase64String(bytes);
        //    return base64;

        //}

    }

}
