#pragma checksum "C:\Web API Projects\FindTutor\Views\Home\homePage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "382a854ab461cc3b88632d0e869e947ac88697ee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_homePage), @"mvc.1.0.view", @"/Views/Home/homePage.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"382a854ab461cc3b88632d0e869e947ac88697ee", @"/Views/Home/homePage.cshtml")]
    public class Views_Home_homePage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FindTutor.Models.registrationModel>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Web API Projects\FindTutor\Views\Home\homePage.cshtml"
  
     Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n<!DOCTYPE html>\r\n\r\n\r\n<html>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "382a854ab461cc3b88632d0e869e947ac88697ee2913", async() => {
                WriteLiteral(@"
    <!--<link rel=""stylesheet"" href=""homePageStyle.css"">!-->

    <!-- Latest compiled and minified CSS -->
    <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css"">

    <!-- jQuery library -->
    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js""></script>

    <!-- Popper JS -->
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js""></script>

    <!-- Latest compiled JavaScript -->
    <script src=""https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js""></script>
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.15.2/css/all.min.css"" integrity=""sha512-HK5fgLBL+xu6dm/Ii3z4xhlSUyZgTT9tuc/hSrtw6uzJOvgRr2a9jyxxT1ely+B+xFAmJKVSTbpM/CuL7qxO8w=="" crossorigin=""anonymous"" />

    <style>
        * {
            margin: 0;
            padding: 0;
        }
        
        .logo {
            width: 20%;
            display: flex;");
                WriteLiteral(@"
            align-items: center;
            justify-content: center;
        }
        
        .logo img {
            width: 33%;
            border: 3px solid white;
            border-radius: 70px;
        }
        
        .navbar {
            display: flex;
        }
        
        .nav-list {
            width: 80%;
            background-color: teal;
            display: flex;
            align-items: center;
        }
        
        .nav-list li {
            list-style: none;
            padding: 10px 20px;
            font-size: 20px;
            outline-color: white;
        }
        
        .nav-list li a:hover {
            text-decoration: none;
            color: grey;
            text-decoration: none;
        }
        
        .right_nav {
            width: 20%;
            background-color: teal;
            text-align: right;
            font-size: 18px;
        }
        
        .right_nav a {
            padding: 14px 28px;
       ");
                WriteLiteral(@"     background-color: inherit;
            text-decoration: none;
            align-items: center;
            color: black;
        }
    </style>



    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>Document</title>

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "382a854ab461cc3b88632d0e869e947ac88697ee6324", async() => {
                WriteLiteral(@"

    <nav class=""navbar"">
        <ul class=""nav-list"">
            <div class=""logo""> <img src=""../Images/headerLogo.jpg"" alt=""logo""> </div>
            <li><a href=""#Home"">Home</a></li>
            <li><a href=""#Courses"">Courses</a></li>
            <li><a href=""#Tutor Corner"">Tutor Corner</a></li>
            <li><a href=""#Forum and Discussion"">Forum and Discussion</a></li>
        </ul>

        <div class=""right_nav"">
            <a href=""#login"">Login</a>
            <button type=""button"" class=""btn btn-success"" data-toggle=""modal"" data-target=""#register_popup"">Register</button>

        </div>
    </nav>

    <div>
        <form action=""homePage/showingFromDB"" method=""POST"">
            <button type=""submit"">Check</button>
        </form>
    </div> 


    <div class=""modal fade"" role=""dialog"" id=""register_popup"">
        <div class=""modal-dialog"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h3>Find<strong>Tutor</");
                WriteLiteral(@"strong></h3>
                    <button type=""button"" class=""close"" data-dismiss=""modal"">&times</button>
                </div>

                <form  action=""homePage/showingFromDB"" method=""POST"">
                    <div class=""modal-body"">
                        <div class=""form-group"">
                            <input type=""text"" name=""firstName""  class=""form-control"" placeholder="" Full Name "">
                        </div>
                        <div class=""form-group"">
                            <input type=""text"" name=""lastName"" class=""form-control"" placeholder="" Full Name "">
                        </div>
                        <div class=""form-group "">
                            <input type=""text"" name=""user_Email"" class=""form-control "" placeholder=""Email "">
                        </div>
                        <div class=""form-group "">
                            <input type=""text"" name=""user_Password"" class=""form-control "" placeholder=""Enter Password "">
                 ");
                WriteLiteral(@"       </div>
                        <div class=""form-group "">
                            <input type=""text"" name=""retype_Password"" class=""form-control "" placeholder=""Re-enter Password "">
                        </div>
                        <button type=""submit"" >Register</button>

                    </div>
                    <div class=""modal-footer "">


                        
                        <div class=""text-center "">
                            <p>- Or Use These Accounts -</p>
                            <a class=""btn btn-social-icon btn-google ""><i class=""fa fa-google ""></i></a>
                            <a class=""btn btn-social-icon btn-facebook ""><i class=""fa fa-facebook ""></i></a>
                            <a class=""btn btn-social-icon btn-twitter ""><i class=""fa fa-twitter ""></i></a>
                            <a class=""btn btn-social-icon btn-linkedin ""><i class=""fa fa-linkedin ""></i></a>
                            <a class=""btn btn-social-icon btn-github ""><i cl");
                WriteLiteral(@"ass=""fa fa-github ""></i></a>
                            <a class=""btn btn-social-icon btn-dropbox ""><i class=""fa fa-dropbox ""></i></a>
                            <a class=""btn btn-social-icon btn-instagram ""><i class=""fa fa-instagram ""></i></a>
                            <a class=""btn btn-social-icon btn-tumblr ""><i class=""fa fa-tumblr ""></i></a>
                            <a class=""btn btn-social-icon btn-github ""><i class=""fa fa-apple ""></i></a>
                        </div>
                    </div>
                </form>

            </div>

        </div>

    </div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n\r\n</html>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FindTutor.Models.registrationModel> Html { get; private set; }
    }
}
#pragma warning restore 1591