#pragma checksum "C:\Users\je_ss\OneDrive\Área de Trabalho\Projeto Mulheres\Projeto_EmpoDelas_Squad_5_RecodePro\EmpoDelas\Views\ProdutoServicos\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "19c05430f8204bcaba7ffb19a766b5a15dc0848b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ProdutoServicos_Details), @"mvc.1.0.view", @"/Views/ProdutoServicos/Details.cshtml")]
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
#nullable restore
#line 1 "C:\Users\je_ss\OneDrive\Área de Trabalho\Projeto Mulheres\Projeto_EmpoDelas_Squad_5_RecodePro\EmpoDelas\Views\_ViewImports.cshtml"
using EmpoDelas;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\je_ss\OneDrive\Área de Trabalho\Projeto Mulheres\Projeto_EmpoDelas_Squad_5_RecodePro\EmpoDelas\Views\_ViewImports.cshtml"
using EmpoDelas.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"19c05430f8204bcaba7ffb19a766b5a15dc0848b", @"/Views/ProdutoServicos/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ac4018d048943df21a73a0b636350302b83ba95", @"/Views/_ViewImports.cshtml")]
    public class Views_ProdutoServicos_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<empodelas.Models.ProdutoServico>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/produto.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\je_ss\OneDrive\Área de Trabalho\Projeto Mulheres\Projeto_EmpoDelas_Squad_5_RecodePro\EmpoDelas\Views\ProdutoServicos\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "19c05430f8204bcaba7ffb19a766b5a15dc0848b4756", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<h4>");
#nullable restore
#line 9 "C:\Users\je_ss\OneDrive\Área de Trabalho\Projeto Mulheres\Projeto_EmpoDelas_Squad_5_RecodePro\EmpoDelas\Views\ProdutoServicos\Details.cshtml"
Write(Html.DisplayFor(model => model.Tipo_produtoServico));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n<h1>");
#nullable restore
#line 10 "C:\Users\je_ss\OneDrive\Área de Trabalho\Projeto Mulheres\Projeto_EmpoDelas_Squad_5_RecodePro\EmpoDelas\Views\ProdutoServicos\Details.cshtml"
Write(Html.DisplayFor(model => model.Nome_produtoServico));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<hr />\r\n<div class=\"row\">\r\n    <div class=\"col\">\r\n        <img");
            BeginWriteAttribute("src", " src=\"", 327, "\"", 387, 1);
#nullable restore
#line 14 "C:\Users\je_ss\OneDrive\Área de Trabalho\Projeto Mulheres\Projeto_EmpoDelas_Squad_5_RecodePro\EmpoDelas\Views\ProdutoServicos\Details.cshtml"
WriteAttributeValue("", 333, Html.DisplayFor(model => model.Imagem_produtoServico), 333, 54, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    </div>\r\n    <div class=\"col\">\r\n        <dl class=\"row\">\r\n            <dt class=\"col-sm-10\">\r\n               Código:\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 22 "C:\Users\je_ss\OneDrive\Área de Trabalho\Projeto Mulheres\Projeto_EmpoDelas_Squad_5_RecodePro\EmpoDelas\Views\ProdutoServicos\Details.cshtml"
           Write(Html.DisplayFor(model => model.Codigo_produtoServico));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-10\">\r\n              Descrição:\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 28 "C:\Users\je_ss\OneDrive\Área de Trabalho\Projeto Mulheres\Projeto_EmpoDelas_Squad_5_RecodePro\EmpoDelas\Views\ProdutoServicos\Details.cshtml"
           Write(Html.DisplayFor(model => model.Descricao_produtoServico));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-10\">\r\n                Preço:\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 34 "C:\Users\je_ss\OneDrive\Área de Trabalho\Projeto Mulheres\Projeto_EmpoDelas_Squad_5_RecodePro\EmpoDelas\Views\ProdutoServicos\Details.cshtml"
           Write(Html.DisplayFor(model => model.Preco_produtoServico));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-10\">\r\n                Nome do negócio\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 40 "C:\Users\je_ss\OneDrive\Área de Trabalho\Projeto Mulheres\Projeto_EmpoDelas_Squad_5_RecodePro\EmpoDelas\Views\ProdutoServicos\Details.cshtml"
           Write(Html.DisplayFor(model => model.NomeNegocio_autonoma));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n        </dl>\r\n    </div>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "19c05430f8204bcaba7ffb19a766b5a15dc0848b9184", async() => {
                WriteLiteral("Voltar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<empodelas.Models.ProdutoServico> Html { get; private set; }
    }
}
#pragma warning restore 1591
