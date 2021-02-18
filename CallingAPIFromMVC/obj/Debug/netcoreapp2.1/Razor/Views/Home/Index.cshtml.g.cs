#pragma checksum "C:\Users\hrist\Desktop\CallingAPIFromMVC\APIFromMVCExcample\CallingAPIFromMVC\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fede455d4964d706158e890c576d2567b51ec4c4"
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
#line 1 "C:\Users\hrist\Desktop\CallingAPIFromMVC\APIFromMVCExcample\CallingAPIFromMVC\Views\_ViewImports.cshtml"
using CallingAPIFromMVC;

#line default
#line hidden
#line 2 "C:\Users\hrist\Desktop\CallingAPIFromMVC\APIFromMVCExcample\CallingAPIFromMVC\Views\_ViewImports.cshtml"
using CallingAPIFromMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fede455d4964d706158e890c576d2567b51ec4c4", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3afd61d1e1a22da925bf946dca3b5ad6000aef30", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\hrist\Desktop\CallingAPIFromMVC\APIFromMVCExcample\CallingAPIFromMVC\Views\Home\Index.cshtml"
  
    ViewBag.Title = "Student";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(86, 55, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "045d6da4ad214f6c879ab0077f2e119c", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(141, 2991, true);
            WriteLiteral(@"

<h2>Add a student</h2>
<div class=""form-group"" style=""display:none;"">
    <input id=""txtStudentId"" class=""form-control"" name=""StudentId"" />
</div>
<div class=""form-group"">
    <label for=""Name"">Name: </label>
    <input id=""txtStudentName"" class=""form-control"" name=""Name"" />
</div>
<div class=""form-group"">
    <label for=""Roll"">Roll: </label>
    <input id=""txtStudentRoll"" class=""form-control"" name=""Roll"" />
</div>
<div class=""text-center panel-body"">
    <button id=""btnSave"" class=""btn btn-sm btn-primary"">Save</button>
</div>

<button onclick=""GetAllStudents()"" class=""btn btn-primary"">Load Students</button>

<br />

<h2>Student List</h2>
<table id=""tblStudent"" class=""table table-sm table-striped table-bordered m-2"">
    <thead>
        <tr>
            <th>Student Id</th>
            <th>Name</th>
            <th>Roll</th>
            <th>Action</th>
        </tr>
    </thead>

</table>

<script type=""text/javascript"">
    $(document).ready(function () {

    });
    ");
            WriteLiteral(@"function GetAllStudents() {
        $.getJSON(""/Students/GetAllStudents"", function (students) {
            $(""#tblStudent tbody tr"").remove();
            $.map(students, function (student) {
                $(""#tblStudent tbody"").append(""<tr>""
                    + "" <td>"" + student.studentId + ""</td""
                    + "" <td>"" + student.name + ""</td""
                    + "" <td>"" + student.roll + ""</td""
                    + "" <td>""
                    + "" <button class = 'btn-success' onclick='Edit("" + student.studentId + "")'style='margin-right:5px>""
                    + "" <button class = 'btn-danger' onclick='Delete("" + student.studentId + "")'.Delete</button""
                    + "" </td> ""
                    + "" </tr> "");

            });
        });
    }
    function Edit(studentId) {
        if (studentId>0) {
            $.getJSON(""/Students/GetById?StudentId="" + studentId, function (student){
                $(""#txtStudentId"").val(student.studentId);
                $(""#tx");
            WriteLiteral(@"tStudentName"").val(student.name);
                $(""#txtStudentRoll"").val(student.roll);

            });
        }
    }
    function Delete(studentId) {
        if (studentId > 0) {
            $.ajax({
                url: '/Students/Delete?studentId=' + studentId,
                type: 'DELETE',
                dataType: 'json',
                success: function (data) {

                },
                error: function (ex) {
                    console.log('Error in operation');
                }

            });
        }
    }


    $(""#btnSave"").click(function () {
        var oStudent = {
            StudentId: $(""#txtStudentId"").val,
            Name: $(""#txtStudentName"").val,
            Roll: $(""#txtStudentRoll"").val,
        }

        $.post(""/Students/AddUpdateStudent"", oStudent)
            .done(function () {
                GetAllStudents
            });
    })
</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
