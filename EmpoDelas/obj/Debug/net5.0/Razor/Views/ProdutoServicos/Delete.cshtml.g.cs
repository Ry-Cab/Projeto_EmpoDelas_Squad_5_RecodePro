#pragma checksum "D:\RecodePRO\PROJETOS\Recode Projeto em grupo 3\Projeto_EmpoDelas_Squad_5_RecodePro\Empodelas\Views\ProdutoServicos\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aee1e3cbf6a0f40cb6fcb70cc8b3d4e6df9ec0fa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ProdutoServicos_Delete), @"mvc.1.0.view", @"/Views/ProdutoServicos/Delete.cshtml")]
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
#line 1 "D:\RecodePRO\PROJETOS\Recode Projeto em grupo 3\Projeto_EmpoDelas_Squad_5_RecodePro\Empodelas\Views\_ViewImports.cshtml"
using EmpoDelas;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\RecodePRO\PROJETOS\Recode Projeto em grupo 3\Projeto_EmpoDelas_Squad_5_RecodePro\Empodelas\Views\_ViewImports.cshtml"
using EmpoDelas.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aee1e3cbf6a0f40cb6fcb70cc8b3d4e6df9ec0fa", @"/Views/ProdutoServicos/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ac4018d048943df21a73a0b636350302b83ba95", @"/Views/_ViewImports.cshtml")]
    public class Views_ProdutoServicos_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<empodelas.Models.ProdutoServico>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\RecodePRO\PROJETOS\Recode Projeto em grupo 3\Projeto_EmpoDelas_Squad_5_RecodePro\Empodelas\Views\ProdutoServicos\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Delete um produto ou serviço</h1>

<h3>Você realmente quer deletar um produto ou serviço?</h3>
<div>
    <h4>ProdutoServico</h4>
    <hr />
    <dl class=""row"">
        <dt class = ""col-sm-2"">
            <label>Código do produto/serviço</label>
        </dt>
        <dd class = ""col-sm-10"">
            ");
#nullable restore
#line 18 "D:\RecodePRO\PROJETOS\Recode Projeto em grupo 3\Projeto_EmpoDelas_Squad_5_RecodePro\Empodelas\Views\ProdutoServicos\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Codigo_produtoServico));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 21 "D:\RecodePRO\PROJETOS\Recode Projeto em grupo 3\Projeto_EmpoDelas_Squad_5_RecodePro\Empodelas\Views\ProdutoServicos\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Tipo_produtoServico));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 24 "D:\RecodePRO\PROJETOS\Recode Projeto em grupo 3\Projeto_EmpoDelas_Squad_5_RecodePro\Empodelas\Views\ProdutoServicos\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Tipo_produtoServico));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 27 "D:\RecodePRO\PROJETOS\Recode Projeto em grupo 3\Projeto_EmpoDelas_Squad_5_RecodePro\Empodelas\Views\ProdutoServicos\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Nome_produtoServico));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 30 "D:\RecodePRO\PROJETOS\Recode Projeto em grupo 3\Projeto_EmpoDelas_Squad_5_RecodePro\Empodelas\Views\ProdutoServicos\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Nome_produtoServico));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 33 "D:\RecodePRO\PROJETOS\Recode Projeto em grupo 3\Projeto_EmpoDelas_Squad_5_RecodePro\Empodelas\Views\ProdutoServicos\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Descricao_produtoServico));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 36 "D:\RecodePRO\PROJETOS\Recode Projeto em grupo 3\Projeto_EmpoDelas_Squad_5_RecodePro\Empodelas\Views\ProdutoServicos\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Descricao_produtoServico));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 39 "D:\RecodePRO\PROJETOS\Recode Projeto em grupo 3\Projeto_EmpoDelas_Squad_5_RecodePro\Empodelas\Views\ProdutoServicos\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Imagem_produtoServico));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 42 "D:\RecodePRO\PROJETOS\Recode Projeto em grupo 3\Projeto_EmpoDelas_Squad_5_RecodePro\Empodelas\Views\ProdutoServicos\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Imagem_produtoServico));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 45 "D:\RecodePRO\PROJETOS\Recode Projeto em grupo 3\Projeto_EmpoDelas_Squad_5_RecodePro\Empodelas\Views\ProdutoServicos\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Preco_produtoServico));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 48 "D:\RecodePRO\PROJETOS\Recode Projeto em grupo 3\Projeto_EmpoDelas_Squad_5_RecodePro\Empodelas\Views\ProdutoServicos\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Preco_produtoServico));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 51 "D:\RecodePRO\PROJETOS\Recode Projeto em grupo 3\Projeto_EmpoDelas_Squad_5_RecodePro\Empodelas\Views\ProdutoServicos\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.NomeNegocio_autonoma));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 54 "D:\RecodePRO\PROJETOS\Recode Projeto em grupo 3\Projeto_EmpoDelas_Squad_5_RecodePro\Empodelas\Views\ProdutoServicos\Delete.cshtml"
       Write(Html.DisplayFor(model => model.NomeNegocio_autonoma));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 57 "D:\RecodePRO\PROJETOS\Recode Projeto em grupo 3\Projeto_EmpoDelas_Squad_5_RecodePro\Empodelas\Views\ProdutoServicos\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.FK_id_autonoma));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 60 "D:\RecodePRO\PROJETOS\Recode Projeto em grupo 3\Projeto_EmpoDelas_Squad_5_RecodePro\Empodelas\Views\ProdutoServicos\Delete.cshtml"
       Write(Html.DisplayFor(model => model.FK_id_autonoma));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aee1e3cbf6a0f40cb6fcb70cc8b3d4e6df9ec0fa10901", async() => {
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "aee1e3cbf6a0f40cb6fcb70cc8b3d4e6df9ec0fa11168", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 65 "D:\RecodePRO\PROJETOS\Recode Projeto em grupo 3\Projeto_EmpoDelas_Squad_5_RecodePro\Empodelas\Views\ProdutoServicos\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id_produtoServico);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aee1e3cbf6a0f40cb6fcb70cc8b3d4e6df9ec0fa13020", async() => {
                    WriteLiteral("Volte para lista de produtos");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
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
