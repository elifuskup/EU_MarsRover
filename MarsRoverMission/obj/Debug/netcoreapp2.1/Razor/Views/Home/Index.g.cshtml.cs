#pragma checksum "C:\Users\PRO2841\Desktop\Mission\MarsRoverMission\MarsRoverMission\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8c0a246e88a8c79dad70f71e87c5bfd38ba30c19"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\PRO2841\Desktop\Mission\MarsRoverMission\MarsRoverMission\Views\_ViewImports.cshtml"
using MarsRoverMission;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c0a246e88a8c79dad70f71e87c5bfd38ba30c19", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2e1288d5cfbc442fbff6a6af5beb810d20051d9", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\PRO2841\Desktop\Mission\MarsRoverMission\MarsRoverMission\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page of Mars";

#line default
#line hidden
            BeginContext(53, 2816, true);
            WriteLiteral(@"
<div class=""content"">
    <div style=""text-align: center; margin-bottom: 30px;""><h1>Mission : Mars Rover</h1></div>
    <div style=""padding-bottom: 30px;"" class=""row"">
        <div id=""div_form"">
            <div class=""form-group"">
                <label>The upper-right coordinates of the plateau</label>
                <input class=""form-control"" id=""coordinates"" name=""coordinates"" aria-describedby=""coordHelp"" placeholder=""Enter coordinates"">
                <small id=""coordHelp"" class=""form-text text-muted"">The lower-left coordinates are assumed to be (0,0).</small>
            </div>
            <div class=""form-group"">
                <label>1st rover’s position</label>
                <input class=""form-control"" id=""pos_r_1"" name=""pos_r_1"" aria-describedby=""pos_r_1Help"" placeholder=""Enter position"">
                <small id=""pos_r_1Help"" class=""form-text text-muted"">The position is made up of two integers and a letter separated by spaces, corresponding to the x and y co-ordinates and the ");
            WriteLiteral(@"rover’s orientation. (e.g., 1 2 N)</small>
            </div>
            <div class=""form-group"">
                <label>1st rover’s movements</label>
                <input class=""form-control"" id=""move_r_1"" name=""move_r_1"" aria-describedby=""move_r_1Help"" placeholder=""Enter movements"">
                <small id=""move_r_1Help"" class=""form-text text-muted"">Series of instructions telling the rover how to explore the plateau. L : Left, R: Right, M : Move forward (e.g., LMLMLMLMM)</small>
            </div>
            <div class=""form-group"">
                <label>2nd rover’s position</label>
                <input class=""form-control"" id=""pos_r_2"" name=""pos_r_2"" aria-describedby=""pos_r_2Help"" placeholder=""Enter position"">
                <small id=""pos_r_2Help"" class=""form-text text-muted"">The position is made up of two integers and a letter separated by spaces, corresponding to the x and y co-ordinates and the rover’s orientation. (e.g., 1 2 N)</small>
            </div>
            <div class=""f");
            WriteLiteral(@"orm-group"">
                <label>2nd rover’s position</label>
                <input class=""form-control"" id=""move_r_2"" name=""move_r_2"" aria-describedby=""move_r_2Help"" placeholder=""Enter movements"">
                <small id=""move_r_2Help"" class=""form-text text-muted"">Series of instructions telling the rover how to explore the plateau. L : Left, R: Right, M : Move forward (e.g., LMLMLMLMM)</small>
            </div>
            <button type=""submit"" class=""btn btn-primary"" onclick=""InitializeRovers();"">Send them to Mars</button>
        </div>
    </div>
    <div class=""row"">
        <div style=""padding-bottom: 30px;"" class=""col-sm-6"" id=""rover_1"">
        </div>
        <div class=""col-sm-6"" id=""rover_2"">
        </div>
    </div>
</div>

");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2887, 898, true);
                WriteLiteral(@"
    <script type=""text/javascript"">

        var InitializeRovers = function () {
            RenderRover('#rover_1', $('#pos_r_1').val(), $('#move_r_1').val());
            RenderRover('#rover_2', $('#pos_r_2').val(), $('#move_r_2').val());
        };

        var RenderRover = function (roverDiv, position, movements) {
            var data = {};
            data.coordinates = $('#coordinates').val();
            data.pos_r_1 = position;
            data.move_r_1 = movements;

            $.ajax({
                type: ""POST"",
                dataType: ""html"",
                data: data,
                url: ""/Home/Rover"",
                error: function (err) {
                    var a = 42;
                },
                success: function (data) {
                    $(roverDiv).html(data);
                }
            });
        };
    </script>
");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
