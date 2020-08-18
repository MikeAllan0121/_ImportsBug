#pragma checksum "E:\Programs\OneDrive\Programs\cSharp\MyWebsite\MyWebsite\Client\Pages\MineSweeper\MineSweeperPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "db399d5de62ef4223a2611e7c4ac924aba86401b"
// <auto-generated/>
#pragma warning disable 1591
namespace MyWebsite.Client.Pages.MineSweeper
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\Programs\OneDrive\Programs\cSharp\MyWebsite\MyWebsite\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Programs\OneDrive\Programs\cSharp\MyWebsite\MyWebsite\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Programs\OneDrive\Programs\cSharp\MyWebsite\MyWebsite\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Programs\OneDrive\Programs\cSharp\MyWebsite\MyWebsite\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Programs\OneDrive\Programs\cSharp\MyWebsite\MyWebsite\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\Programs\OneDrive\Programs\cSharp\MyWebsite\MyWebsite\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\Programs\OneDrive\Programs\cSharp\MyWebsite\MyWebsite\Client\_Imports.razor"
using MyWebsite.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\Programs\OneDrive\Programs\cSharp\MyWebsite\MyWebsite\Client\_Imports.razor"
using MyWebsite.Client.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "E:\Programs\OneDrive\Programs\cSharp\MyWebsite\MyWebsite\Client\_Imports.razor"
using MyWebsite.Client.StandardComponents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "E:\Programs\OneDrive\Programs\cSharp\MyWebsite\MyWebsite\Client\_Imports.razor"
using MyWebsite.Client.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "E:\Programs\OneDrive\Programs\cSharp\MyWebsite\MyWebsite\Client\_Imports.razor"
using MyWebsite.Shared.PageMakeup;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Programs\OneDrive\Programs\cSharp\MyWebsite\MyWebsite\Client\Pages\MineSweeper\MineSweeperPage.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Programs\OneDrive\Programs\cSharp\MyWebsite\MyWebsite\Client\Pages\MineSweeper\MineSweeperPage.razor"
using MyWebsite.Client.Pages.MineSweeper.Makeup;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/minesweeper")]
    public partial class MineSweeperPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page-minesweeper");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "set-absolutecenter minesweeper-canvas");
            __builder.AddMarkupContent(5, "\r\n");
#nullable restore
#line 7 "E:\Programs\OneDrive\Programs\cSharp\MyWebsite\MyWebsite\Client\Pages\MineSweeper\MineSweeperPage.razor"
         if (gameManager.GameOver)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(6, "        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "overlay set-flexcenter");
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "content");
            __builder.AddMarkupContent(12, "\r\n                ");
            __builder.AddMarkupContent(13, "<h3>Unlucky!</h3>\r\n                ");
            __builder.OpenElement(14, "button");
            __builder.AddAttribute(15, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "E:\Programs\OneDrive\Programs\cSharp\MyWebsite\MyWebsite\Client\Pages\MineSweeper\MineSweeperPage.razor"
                                  () => gameManager.SetGame()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(16, "Try again?");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n");
#nullable restore
#line 15 "E:\Programs\OneDrive\Programs\cSharp\MyWebsite\MyWebsite\Client\Pages\MineSweeper\MineSweeperPage.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(20, "        ");
            __builder.AddContent(21, 
#nullable restore
#line 16 "E:\Programs\OneDrive\Programs\cSharp\MyWebsite\MyWebsite\Client\Pages\MineSweeper\MineSweeperPage.razor"
          (MarkupString)gameManager.Board.GetHtmlMarkup

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(22, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 19 "E:\Programs\OneDrive\Programs\cSharp\MyWebsite\MyWebsite\Client\Pages\MineSweeper\MineSweeperPage.razor"
       
    GameManager gameManager = new GameManager();
    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        var dotnet = DotNetObjectReference.Create(this);

        await jsRuntime.InvokeVoidAsync("BlazorExtensions.SetupMineSweeper", dotnet);
    }
    [JSInvokable]
    public void BoxLeftClicked(string id)
    {
        gameManager.ClickedBox(id, true);
        this.StateHasChanged();
    }
    [JSInvokable]
    public void BoxRightClicked(string id)
    {
        gameManager.ClickedBox(id, false);
        this.StateHasChanged();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsRuntime { get; set; }
    }
}
#pragma warning restore 1591
