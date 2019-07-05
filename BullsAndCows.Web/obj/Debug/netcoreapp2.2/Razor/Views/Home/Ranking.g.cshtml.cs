#pragma checksum "C:\Users\volenpopov\Desktop\Project\ASP.NET-BullsAndCows\BullsAndCows.Web\Views\Home\Ranking.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dcee63c678b872bb60172798dde6973d87284edf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Ranking), @"mvc.1.0.view", @"/Views/Home/Ranking.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Ranking.cshtml", typeof(AspNetCore.Views_Home_Ranking))]
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
#line 1 "C:\Users\volenpopov\Desktop\Project\ASP.NET-BullsAndCows\BullsAndCows.Web\Views\_ViewImports.cshtml"
using BullsAndCows;

#line default
#line hidden
#line 2 "C:\Users\volenpopov\Desktop\Project\ASP.NET-BullsAndCows\BullsAndCows.Web\Views\_ViewImports.cshtml"
using BullsAndCows.Models;

#line default
#line hidden
#line 3 "C:\Users\volenpopov\Desktop\Project\ASP.NET-BullsAndCows\BullsAndCows.Web\Views\_ViewImports.cshtml"
using BullsAndCows.Web;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dcee63c678b872bb60172798dde6973d87284edf", @"/Views/Home/Ranking.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9dd9cbfcd9924ba8f870196adc3fc1b74e4522d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Ranking : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BullsAndCows.Models.ViewModels.UserListRankingViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(65, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\volenpopov\Desktop\Project\ASP.NET-BullsAndCows\BullsAndCows.Web\Views\Home\Ranking.cshtml"
  
    ViewData["Title"] = "Ranking";

#line default
#line hidden
            BeginContext(110, 568, true);
            WriteLiteral(@"
<div class=""container"">
    <div class=""table-responsive"">
        <table class=""table table-striped my-5"">
            <thead>
                <tr>
                    <th scope=""col"">#</th>
                    <th scope=""col"">Username</th>
                    <th scope=""col"">Wins</th>
                    <th scope=""col"">Losses</th>
                    <th scope=""col"">Win Ratio</th>
                    <th scope=""col"">Points</th>
                    <th scope=""col"">Total Games</th>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 22 "C:\Users\volenpopov\Desktop\Project\ASP.NET-BullsAndCows\BullsAndCows.Web\Views\Home\Ranking.cshtml"
                 for (int i = 0; i < Model.Users.Count(); i++)
                {

#line default
#line hidden
            BeginContext(761, 66, true);
            WriteLiteral("                    <tr>\r\n                        <th scope=\"row\">");
            EndContext();
            BeginContext(829, 5, false);
#line 25 "C:\Users\volenpopov\Desktop\Project\ASP.NET-BullsAndCows\BullsAndCows.Web\Views\Home\Ranking.cshtml"
                                    Write(i + 1);

#line default
#line hidden
            EndContext();
            BeginContext(835, 7, true);
            WriteLiteral("</th>\r\n");
            EndContext();
#line 26 "C:\Users\volenpopov\Desktop\Project\ASP.NET-BullsAndCows\BullsAndCows.Web\Views\Home\Ranking.cshtml"
                         if (i == 0)
                        {

#line default
#line hidden
            BeginContext(907, 91, true);
            WriteLiteral("                            <td class=\"font-weight-bold\"><i class=\"fas fa-crown mr-1\"></i> ");
            EndContext();
            BeginContext(999, 23, false);
#line 28 "C:\Users\volenpopov\Desktop\Project\ASP.NET-BullsAndCows\BullsAndCows.Web\Views\Home\Ranking.cshtml"
                                                                                      Write(Model.Users[i].Username);

#line default
#line hidden
            EndContext();
            BeginContext(1022, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 29 "C:\Users\volenpopov\Desktop\Project\ASP.NET-BullsAndCows\BullsAndCows.Web\Views\Home\Ranking.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(1113, 32, true);
            WriteLiteral("                            <td>");
            EndContext();
            BeginContext(1146, 23, false);
#line 32 "C:\Users\volenpopov\Desktop\Project\ASP.NET-BullsAndCows\BullsAndCows.Web\Views\Home\Ranking.cshtml"
                           Write(Model.Users[i].Username);

#line default
#line hidden
            EndContext();
            BeginContext(1169, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 33 "C:\Users\volenpopov\Desktop\Project\ASP.NET-BullsAndCows\BullsAndCows.Web\Views\Home\Ranking.cshtml"
                        }

#line default
#line hidden
            BeginContext(1203, 28, true);
            WriteLiteral("                        <td>");
            EndContext();
            BeginContext(1232, 19, false);
#line 34 "C:\Users\volenpopov\Desktop\Project\ASP.NET-BullsAndCows\BullsAndCows.Web\Views\Home\Ranking.cshtml"
                       Write(Model.Users[i].Wins);

#line default
#line hidden
            EndContext();
            BeginContext(1251, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1287, 21, false);
#line 35 "C:\Users\volenpopov\Desktop\Project\ASP.NET-BullsAndCows\BullsAndCows.Web\Views\Home\Ranking.cshtml"
                       Write(Model.Users[i].Losses);

#line default
#line hidden
            EndContext();
            BeginContext(1308, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1344, 27, false);
#line 36 "C:\Users\volenpopov\Desktop\Project\ASP.NET-BullsAndCows\BullsAndCows.Web\Views\Home\Ranking.cshtml"
                       Write(Model.Users[i].WinLossRatio);

#line default
#line hidden
            EndContext();
            BeginContext(1371, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1407, 26, false);
#line 37 "C:\Users\volenpopov\Desktop\Project\ASP.NET-BullsAndCows\BullsAndCows.Web\Views\Home\Ranking.cshtml"
                       Write(Model.Users[i].TotalPoints);

#line default
#line hidden
            EndContext();
            BeginContext(1433, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1469, 25, false);
#line 38 "C:\Users\volenpopov\Desktop\Project\ASP.NET-BullsAndCows\BullsAndCows.Web\Views\Home\Ranking.cshtml"
                       Write(Model.Users[i].TotalGames);

#line default
#line hidden
            EndContext();
            BeginContext(1494, 34, true);
            WriteLiteral("</td>\r\n                    </tr>\r\n");
            EndContext();
#line 40 "C:\Users\volenpopov\Desktop\Project\ASP.NET-BullsAndCows\BullsAndCows.Web\Views\Home\Ranking.cshtml"
                }

#line default
#line hidden
            BeginContext(1547, 60, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BullsAndCows.Models.ViewModels.UserListRankingViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
