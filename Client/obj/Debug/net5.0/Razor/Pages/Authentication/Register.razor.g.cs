#pragma checksum "C:\Users\saadr\OneDrive\Desktop\ead semester\Estore\Client\Pages\Authentication\Register.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "099ed8c8e7d1404522d2214d4a97ec99d1a70e1e"
// <auto-generated/>
#pragma warning disable 1591
namespace Estore.Client.Pages.Authentication
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\saadr\OneDrive\Desktop\ead semester\Estore\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\saadr\OneDrive\Desktop\ead semester\Estore\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\saadr\OneDrive\Desktop\ead semester\Estore\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\saadr\OneDrive\Desktop\ead semester\Estore\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\saadr\OneDrive\Desktop\ead semester\Estore\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\saadr\OneDrive\Desktop\ead semester\Estore\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\saadr\OneDrive\Desktop\ead semester\Estore\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\saadr\OneDrive\Desktop\ead semester\Estore\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\saadr\OneDrive\Desktop\ead semester\Estore\Client\_Imports.razor"
using Estore.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\saadr\OneDrive\Desktop\ead semester\Estore\Client\_Imports.razor"
using Estore.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\saadr\OneDrive\Desktop\ead semester\Estore\Client\Pages\Authentication\Register.razor"
using Estore.Client.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\saadr\OneDrive\Desktop\ead semester\Estore\Client\Pages\Authentication\Register.razor"
using Estore.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\saadr\OneDrive\Desktop\ead semester\Estore\Client\Pages\Authentication\Register.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(AuthLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/register")]
    public partial class Register : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row");
            __builder.AddMarkupContent(4, "<div class=\"col-md-3 col-lg-3 \"></div>\r\n        ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "col-6  my-3 card card-body bg-white p-3");
            __builder.AddMarkupContent(7, "<h1 class=\"text-center text-dark text-uppercase\">Sign up </h1>\r\n            ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "row my-3 ml-2");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "col-12");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(12);
            __builder.AddAttribute(13, "class", "form-signin");
            __builder.AddAttribute(14, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 16 "C:\Users\saadr\OneDrive\Desktop\ead semester\Estore\Client\Pages\Authentication\Register.razor"
                                                                 OnSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(15, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 16 "C:\Users\saadr\OneDrive\Desktop\ead semester\Estore\Client\Pages\Authentication\Register.razor"
                                                                                  registerRequest

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(17);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(18, "\r\n                        ");
                __builder2.OpenElement(19, "div");
                __builder2.AddAttribute(20, "class", "form-group");
                __builder2.AddMarkupContent(21, "<label for=\"inputemail\" class=\"sr-only\">Email</label>\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(22);
                __builder2.AddAttribute(23, "id", "inputemail");
                __builder2.AddAttribute(24, "class", "form-control");
                __builder2.AddAttribute(25, "placeholder", "Email");
                __builder2.AddAttribute(26, "autofocus", true);
                __builder2.AddAttribute(27, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 20 "C:\Users\saadr\OneDrive\Desktop\ead semester\Estore\Client\Pages\Authentication\Register.razor"
                                                                                                                        registerRequest.email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(28, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => registerRequest.email = __value, registerRequest.email))));
                __builder2.AddAttribute(29, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => registerRequest.email));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(30, "\r\n                            ");
                __Blazor.Estore.Client.Pages.Authentication.Register.TypeInference.CreateValidationMessage_0(__builder2, 31, 32, 
#nullable restore
#line 21 "C:\Users\saadr\OneDrive\Desktop\ead semester\Estore\Client\Pages\Authentication\Register.razor"
                                                      () => registerRequest.email

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(33, "\r\n                        ");
                __builder2.OpenElement(34, "div");
                __builder2.AddAttribute(35, "class", "form-group");
                __builder2.AddMarkupContent(36, "<label for=\"inputrole\" class=\"sr-only\">Role</label>\r\n                            ");
                __Blazor.Estore.Client.Pages.Authentication.Register.TypeInference.CreateInputSelect_1(__builder2, 37, 38, "form-control", 39, "inputrole", 40, "Role", 41, true, 42, 
#nullable restore
#line 25 "C:\Users\saadr\OneDrive\Desktop\ead semester\Estore\Client\Pages\Authentication\Register.razor"
                                                                                                                        registerRequest.Roleid

#line default
#line hidden
#nullable disable
                , 43, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => registerRequest.Roleid = __value, registerRequest.Roleid)), 44, () => registerRequest.Roleid, 45, (__builder3) => {
                    __builder3.AddMarkupContent(46, "<option value=\"2\">Seller</option>\r\n                                ");
                    __builder3.AddMarkupContent(47, "<option value=\"3\" selected>Buyer</option>");
                }
                );
                __builder2.AddMarkupContent(48, "\r\n\r\n                                    ");
                __Blazor.Estore.Client.Pages.Authentication.Register.TypeInference.CreateValidationMessage_2(__builder2, 49, 50, 
#nullable restore
#line 32 "C:\Users\saadr\OneDrive\Desktop\ead semester\Estore\Client\Pages\Authentication\Register.razor"
                                                              () => registerRequest.Roleid

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(51, "\r\n                        ");
                __builder2.OpenElement(52, "div");
                __builder2.AddAttribute(53, "class", "form-group");
                __builder2.AddMarkupContent(54, "<label for=\"inputPassword\" class=\"sr-only\">Password</label>\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(55);
                __builder2.AddAttribute(56, "type", "password");
                __builder2.AddAttribute(57, "id", "inputPassword");
                __builder2.AddAttribute(58, "class", "form-control");
                __builder2.AddAttribute(59, "placeholder", "Password");
                __builder2.AddAttribute(60, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 36 "C:\Users\saadr\OneDrive\Desktop\ead semester\Estore\Client\Pages\Authentication\Register.razor"
                                                                                                                                    registerRequest.password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(61, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => registerRequest.password = __value, registerRequest.password))));
                __builder2.AddAttribute(62, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => registerRequest.password));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(63, "\r\n                            ");
                __Blazor.Estore.Client.Pages.Authentication.Register.TypeInference.CreateValidationMessage_3(__builder2, 64, 65, 
#nullable restore
#line 37 "C:\Users\saadr\OneDrive\Desktop\ead semester\Estore\Client\Pages\Authentication\Register.razor"
                                                      () => registerRequest.password

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(66, "\r\n                        ");
                __builder2.OpenElement(67, "div");
                __builder2.AddAttribute(68, "class", "form-group");
                __builder2.AddMarkupContent(69, "<label for=\"inputPasswordConfirm\" class=\"sr-only\">Password Confirmation</label>\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(70);
                __builder2.AddAttribute(71, "type", "password");
                __builder2.AddAttribute(72, "id", "inputPasswordConfirm");
                __builder2.AddAttribute(73, "class", "form-control");
                __builder2.AddAttribute(74, "placeholder", "Password Confirmation");
                __builder2.AddAttribute(75, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 41 "C:\Users\saadr\OneDrive\Desktop\ead semester\Estore\Client\Pages\Authentication\Register.razor"
                                                                                                                                                        registerRequest.ConfirmPassword

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(76, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => registerRequest.ConfirmPassword = __value, registerRequest.ConfirmPassword))));
                __builder2.AddAttribute(77, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => registerRequest.ConfirmPassword));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(78, "\r\n                            ");
                __Blazor.Estore.Client.Pages.Authentication.Register.TypeInference.CreateValidationMessage_4(__builder2, 79, 80, 
#nullable restore
#line 42 "C:\Users\saadr\OneDrive\Desktop\ead semester\Estore\Client\Pages\Authentication\Register.razor"
                                                      () => registerRequest.ConfirmPassword

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(81, "\r\n                        ");
                __builder2.AddMarkupContent(82, "<button class=\"btn btn-lg btn-primary btn-block\" type=\"submit\">Create account</button>\r\n\r\n                        ");
                __builder2.OpenElement(83, "label");
                __builder2.AddAttribute(84, "class", "text-danger");
                __builder2.AddContent(85, 
#nullable restore
#line 46 "C:\Users\saadr\OneDrive\Desktop\ead semester\Estore\Client\Pages\Authentication\Register.razor"
                                                    error

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(86, "\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(87);
                __builder2.AddAttribute(88, "href", "login");
                __builder2.AddAttribute(89, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(90, "<h6 class=\"font-weight-normal text-center\">Already have an account? Click here to login</h6>");
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 61 "C:\Users\saadr\OneDrive\Desktop\ead semester\Estore\Client\Pages\Authentication\Register.razor"
           

    RegisterRequest registerRequest { get; set; } = new RegisterRequest();
    string error { get; set; }

    async Task OnSubmit()
    {
        error = null;
        try
        {
            await authStateProvider.Register(registerRequest);
            navigationManager.NavigateTo("");
        }
        catch (Exception ex)
        {
            error = ex.Message;
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CustomStateProvider authStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
    }
}
namespace __Blazor.Estore.Client.Pages.Authentication.Register
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, System.Object __arg2, int __seq3, System.Object __arg3, int __seq4, TValue __arg4, int __seq5, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg5, int __seq6, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg6, int __seq7, global::Microsoft.AspNetCore.Components.RenderFragment __arg7)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "id", __arg1);
        __builder.AddAttribute(__seq2, "placeholder", __arg2);
        __builder.AddAttribute(__seq3, "autofocus", __arg3);
        __builder.AddAttribute(__seq4, "Value", __arg4);
        __builder.AddAttribute(__seq5, "ValueChanged", __arg5);
        __builder.AddAttribute(__seq6, "ValueExpression", __arg6);
        __builder.AddAttribute(__seq7, "ChildContent", __arg7);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591