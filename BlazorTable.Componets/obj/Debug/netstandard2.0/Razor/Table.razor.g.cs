#pragma checksum "C:\Users\b_e_t\Documents\00PROJECTS\BlazorTable\BlazorTable.Componets\Table.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "373e5b2e14139ab3b74dd442f1f4e6a6919dfe33"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorTable.Componets
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "C:\Users\b_e_t\Documents\00PROJECTS\BlazorTable\BlazorTable.Componets\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
    public partial class Table<T> : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "table");
            __builder.AddMultipleAttributes(1, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, object>>>(
#line 3 "C:\Users\b_e_t\Documents\00PROJECTS\BlazorTable\BlazorTable.Componets\Table.razor"
                    AdditionalAttributes

#line default
#line hidden
            ));
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "thead");
            __builder.AddMarkupContent(4, "\r\n        ");
            __builder.OpenElement(5, "tr");
            __builder.AddMarkupContent(6, "\r\n");
#line 6 "C:\Users\b_e_t\Documents\00PROJECTS\BlazorTable\BlazorTable.Componets\Table.razor"
             if (Head != null)
            {
                

#line default
#line hidden
#line 8 "C:\Users\b_e_t\Documents\00PROJECTS\BlazorTable\BlazorTable.Componets\Table.razor"
__builder.AddContent(7, Head);

#line default
#line hidden
#line 8 "C:\Users\b_e_t\Documents\00PROJECTS\BlazorTable\BlazorTable.Componets\Table.razor"
                     
            }
            else
            {
                

#line default
#line hidden
#line 12 "C:\Users\b_e_t\Documents\00PROJECTS\BlazorTable\BlazorTable.Componets\Table.razor"
__builder.AddContent(8, DefaultHead);

#line default
#line hidden
#line 12 "C:\Users\b_e_t\Documents\00PROJECTS\BlazorTable\BlazorTable.Componets\Table.razor"
                            
            }

#line default
#line hidden
            __builder.AddContent(9, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n    ");
            __builder.OpenElement(12, "tbody");
            __builder.AddMarkupContent(13, "\r\n");
#line 17 "C:\Users\b_e_t\Documents\00PROJECTS\BlazorTable\BlazorTable.Componets\Table.razor"
         if (Body != null)
        {
            foreach (var Item in Items)
            {

#line default
#line hidden
            __builder.AddContent(14, "                ");
            __builder.OpenElement(15, "tr");
            __builder.AddMarkupContent(16, "\r\n                    ");
#line 22 "C:\Users\b_e_t\Documents\00PROJECTS\BlazorTable\BlazorTable.Componets\Table.razor"
__builder.AddContent(17, this.Body(Item));

#line default
#line hidden
            __builder.AddMarkupContent(18, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n");
#line 24 "C:\Users\b_e_t\Documents\00PROJECTS\BlazorTable\BlazorTable.Componets\Table.razor"
            }
        }
        else
        {
            

#line default
#line hidden
#line 28 "C:\Users\b_e_t\Documents\00PROJECTS\BlazorTable\BlazorTable.Componets\Table.razor"
__builder.AddContent(20, DefaultBody);

#line default
#line hidden
#line 28 "C:\Users\b_e_t\Documents\00PROJECTS\BlazorTable\BlazorTable.Componets\Table.razor"
                        
        }

#line default
#line hidden
            __builder.AddContent(21, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
