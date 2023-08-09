using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;
using DataAccessLibrary.Data;
using DataAccessLibrary.Model;
using System.Text.RegularExpressions;

namespace GMINWEB_Rebuild.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class RegisterModel : PageModel
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ILogger<RegisterModel> _logger;
        private readonly IEmailSender _emailSender;
        private readonly IUserData _db;

        public RegisterModel(
            UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager,
            ILogger<RegisterModel> logger,
            IEmailSender emailSender,
            IUserData db)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _emailSender = emailSender;
            _db = db;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public string ReturnUrl { get; set; }

        public UserModel userModel { get; set; }

        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        [TempData]
        public string StatusMessage { get; set; }

        public class InputModel
        {
            [Required(ErrorMessage ="이메일을 입력하여 주십시오.")]
            [EmailAddress(ErrorMessage = "올바른 이메일 형식으로 입력하여 주십시오.")]
            [Display(Name = "Email")]
            public string Email { get; set; }

            [Required]
            [StringLength(100, ErrorMessage = "암호는 6자 이상 100자 이내여야 합니다.", MinimumLength = 6)]
            
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Confirm password")]
            [Compare("Password", ErrorMessage = "비밀번호와 확인 비밀번호가 일치하지 않습니다.")]
            public string ConfirmPassword { get; set; }

            [Required(ErrorMessage ="사용자명을 입력하여 주십시오.")]
            [Display(Name = "UserNm")]
            public string UserNm { get; set; }

          
            [Required(ErrorMessage = "-을 제외하고 전화번호를 입력하여 주십시오.")]
            [Display(Name = "PhoneNumber")]
            [RegularExpression("^[0-9]*$", ErrorMessage = "-(하이픈)을 제외한 숫자만 허용됩니다.")]
            public string PhoneNumber { get; set; }
        }
        

        public async Task OnGetAsync(string returnUrl = null)
        {
            ReturnUrl = returnUrl;
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl ??= Url.Content("~/");
            var user = new IdentityUser { UserName = Input.Email, Email = Input.Email };
       
            //회원가입시 전화번호 저장되는 부분
            var phoneNumber = await _userManager.GetPhoneNumberAsync(user);
            Regex regex = new Regex("^[0-9]*$"); //숫자만 입력되었는지 체크하는 정규식
            bool hipen = regex.IsMatch(Input.PhoneNumber); // 전화번호가 숫자만 입력되었는지 체크(정규식적용)

            if (Input.PhoneNumber != phoneNumber) //회원가입전 저장된 전화번호가 없으므로 무조건 true 사실상 없어도 되는 로직
            {
                if (hipen) //정규식 체크가 true면 전화번호 기입
                {
                    ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
                    var result = await _userManager.CreateAsync(user, Input.Password);
                    var setPhoneResult = await _userManager.SetPhoneNumberAsync(user, Input.PhoneNumber);
                    
                    await _db.UpdateUserName(user.Email, user.UserName);

                    if (!setPhoneResult.Succeeded)
                    {
                        StatusMessage = "Unexpected error when trying to set phone number.";
                        return RedirectToPage();
                    }


                    //tb_user에 회원가입 유저 정보 기입
                    if (ModelState.IsValid)
                    {
                        if (result.Succeeded)
                        {
                            _logger.LogInformation("User created a new account with password.");

                            var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                            code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));

                            userModel = new UserModel
                            {
                                UserNm = Input.UserNm,
                                UserId = user.Id,
                                LoginId = user.Email,
                                LoginPw = Input.Password,
                                PhoneNo = Input.PhoneNumber // 전화번호 데이터 추가
                            };

                            //관리를 위해 자체 테이블 (TB_User)에 이중 Insert
                            await _db.InsertData(userModel);

                            //var callbackUrl = Url.Page(
                            //    "/Account/ConfirmEmail",
                            //    pageHandler: null,
                            //    values: new { area = "Identity", userId = user.Id, code = code, returnUrl = returnUrl },
                            //    protocol: Request.Scheme);

                            //await _emailSender.SendEmailAsync(Input.Email, "Confirm your email",
                            //    $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");

                            if (_userManager.Options.SignIn.RequireConfirmedAccount)
                            {
                                return RedirectToPage("RegisterConfirmation", new { email = Input.Email, returnUrl = returnUrl });
                            }
                            else
                            {
                                await _signInManager.SignInAsync(user, isPersistent: false);
                                return LocalRedirect(returnUrl);
                            }
                        }
                        foreach (var error in result.Errors)
                        {
                            switch (error.Code)
                            {
                                case "PasswordRequiresNonAlphanumeric":
                                    error.Description = "암호에는 영숫자가 아닌 문자가 하나 이상 있어야 합니다.";
                                    break;

                                case "PasswordRequiresLower":
                                    error.Description = "암호에는 하나 이상의 소문자('a'-'z')가 있어야 합니다.";
                                    break;

                                case "PasswordRequiresUpper":
                                    error.Description = "암호에는 하나 이상의 대문자('A'-'Z')가 있어야 합니다.";
                                    break;


                                default:
                                    break;
                            }

                            ModelState.AddModelError(string.Empty, error.Description);
                        }
                    }
                }

                else if (!hipen) // False면 다시 입력
                {
                    StatusMessage = "-(하이픈)을 제외하고 숫자만 입력하여주십시오";
                    
                    return RedirectToPage();
                }

            }
            // If we got this far, something failed, redisplay form
            return Page();
        }
    }
}
