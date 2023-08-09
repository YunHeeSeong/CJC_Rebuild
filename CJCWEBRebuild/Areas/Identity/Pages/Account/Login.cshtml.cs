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
using System.Threading;

namespace GMINWEB_CJC.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class LoginModel : PageModel
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly ILogger<LoginModel> _logger;

        public LoginModel(SignInManager<IdentityUser> signInManager,
            ILogger<LoginModel> logger,
            UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        public string ReturnUrl { get; set; }

        [TempData]
        public string ErrorMessage { get; set; }

        public class InputModel
        {
            [Required(ErrorMessage = "이메일을 입력하여 주십시오.")]
            [EmailAddress(ErrorMessage = "올바른 이메일 형식으로 입력하여 주십시오.")]
            public string Email { get; set; }

            [Required(ErrorMessage = "비밀번호를 입력하여 주십시오.")]
            [DataType(DataType.Password)]
            public string Password { get; set; }

            [Display(Name = "Remember me?")]
            public bool RememberMe { get; set; }
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

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl ??= Url.Content("~/");

            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();

            if (ModelState.IsValid)
            {
                // This doesn't count login failures towards account lockout
                // To enable password failures to trigger account lockout, set lockoutOnFailure: true
                var result = await _signInManager.PasswordSignInAsync(Input.Email, Input.Password, Input.RememberMe, lockoutOnFailure: false); //아이디(이메일), 패스워드 정보, 로그인 실패시 계정잠금 여부확인
                if (result.Succeeded) //로그인 정보가 올바를때
                {
                    
                    _logger.LogInformation("User logged in.");
                    /* 로그인 정보 (User ID)받아 전송 
                     Pantom 2022-09-29*/
                    Info(Input.Email); 
                    //await jsRuntime.InvokeAsync<string>("console.log", "hello world");

                    return LocalRedirect(returnUrl);
                }
                if (result.RequiresTwoFactor)
                {
                    return RedirectToPage("./LoginWith2fa", new { ReturnUrl = returnUrl, RememberMe = Input.RememberMe });
                }
                if (result.IsLockedOut)
                {
                    _logger.LogWarning("User account locked out.");
                    return RedirectToPage("./Lockout");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "이메일 또는 비밀번호가 일치하지 않습니다.");
                    return Page();
                }
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }

        public static string GetIp() //IpAddr 정보 받아오는 코드
        {
            IPHostEntry ipHost = Dns.GetHostEntry(Dns.GetHostName());
            string ip = String.Empty;
            for (int i = 0; i < ipHost.AddressList.Length; i++)
            {
                if (ipHost.AddressList[i].AddressFamily == AddressFamily.InterNetwork)
                    ip = ipHost.AddressList[i].ToString();
            }
            return ip;
        }

        /* pantom 
          Day:2022-09-29 */
        public static void Info(string ID) 
        {

            try
            {
                //로그인 정보 로그기록 남기기
                //추후 로그 데이터를 모아 정해진 시점에 전송 고려
                string url = "https://log.smart-factory.kr/apisvc/sendLogDataXML.do";
                string prefix = "logData=";
                GlobalVar.IpAddr = GetIp(); //IP접속 주소 값
                GlobalVar.UserId = ID; // Login 시 입력한 Email(ID)값 
                var data = "<logData>"; //로그기록전송 코드 (XML 형태)
                data += "<crtfcKey>" + System.Web.HttpUtility.UrlEncode("$5$API$s1rQDi4MOpTc2GIE5ZWQYRKIszkadhdUPfkgMUund9.") + "</crtfcKey>";
                data += "<logDt>" + System.Web.HttpUtility.UrlEncode(DateTime.Now.ToString("yyyy-MM-dd HH:MM:dd.fff")) + "</logDt>";
                data += "<useSe>" + System.Web.HttpUtility.UrlEncode("접속") + "</useSe>";
                data += "<sysUser>" + System.Web.HttpUtility.UrlEncode(GlobalVar.UserId) + "</sysUser>";
                data += "<conectIp>" + System.Web.HttpUtility.UrlEncode(GlobalVar.IpAddr) + "</conectIp>";
                data += "<dataUsgqty>" + System.Web.HttpUtility.UrlEncode("22222") + "</dataUsgqty>";
                data += "</logData>";



            //호출
            HttpWebRequest reque = (HttpWebRequest)WebRequest.Create(url);
                

                //urlencode
                string encodedt = System.Web.HttpUtility.UrlEncode(data);

                //byte로 변경
                byte[] reqInFormOfBytes = System.Text.Encoding.ASCII.GetBytes(prefix + encodedt);

                //속성설정
                reque.Method = "POST";
                reque.ContentType = "application/x-www-form-urlencoded";
                reque.ContentLength = reqInFormOfBytes.Length;
                reque.Timeout = 180000;

                //Thread.Sleep(180000);
                //stream 호출 및 전송
                System.IO.Stream reqStream = reque.GetRequestStream();
                reqStream.Write(reqInFormOfBytes, 0, reqInFormOfBytes.Length);
                reqStream.Close();

                /*응답 (응답 성공여부 확인 부분) 
                result: OK
                Code: 200*/
                HttpWebResponse resp = (HttpWebResponse)reque.GetResponse();

                //streamReader 호출 및 문자열 처리
                StreamReader respStream = new StreamReader(resp.GetResponseStream(), System.Text.Encoding.Default);

                //확인용(전송결과) Code: AP1002 성공
                string receresp = respStream.ReadToEnd();
                //xmlReader 호출
                System.Xml.XmlReader reader = System.Xml.XmlReader.Create(new StringReader(receresp));
                respStream.Close();
                resp.Close();

                //string SendResult = receresp; //전송결과(성공여부) 문자열 
                //string LogData = data;

                //using (StreamWriter outputFile = new StreamWriter(@"..\..\New_TEXT_File.txt", true))
                //{
                //    //foreach (string line in lines)
                //    //{
                //    // 
                //    //}
                //    outputFile.WriteLine(LogData);
                //    outputFile.WriteLine(SendResult);
                //}
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("성공");
            }
        }

        //로그기록 텍스트 저장
        public static void LogText()
        {
           
        }
    }
}
