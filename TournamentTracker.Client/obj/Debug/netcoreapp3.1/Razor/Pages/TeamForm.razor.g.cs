#pragma checksum "C:\Users\Полина\source\repos\TournamentTracker\TournamentTracker.Client\Pages\TeamForm.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "356e4806ef6bb73aef957809d6a906b1c3d95e1a"
// <auto-generated/>
#pragma warning disable 1591
namespace TournamentTracker.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Полина\source\repos\TournamentTracker\TournamentTracker.Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Полина\source\repos\TournamentTracker\TournamentTracker.Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Полина\source\repos\TournamentTracker\TournamentTracker.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Полина\source\repos\TournamentTracker\TournamentTracker.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Полина\source\repos\TournamentTracker\TournamentTracker.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Полина\source\repos\TournamentTracker\TournamentTracker.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Полина\source\repos\TournamentTracker\TournamentTracker.Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Полина\source\repos\TournamentTracker\TournamentTracker.Client\_Imports.razor"
using TournamentTracker.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Полина\source\repos\TournamentTracker\TournamentTracker.Client\_Imports.razor"
using TournamentTracker.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Полина\source\repos\TournamentTracker\TournamentTracker.Client\Pages\TeamForm.razor"
using TournamentTracker.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Полина\source\repos\TournamentTracker\TournamentTracker.Client\Pages\TeamForm.razor"
using TournamentTracker.Client.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/TeamForm")]
    public partial class TeamForm : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 10 "C:\Users\Полина\source\repos\TournamentTracker\TournamentTracker.Client\Pages\TeamForm.razor"
                  Team

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 10 "C:\Users\Полина\source\repos\TournamentTracker\TournamentTracker.Client\Pages\TeamForm.razor"
                                        HandleSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "class", "w-50 mx-auto");
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(5, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(6);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(8);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(9, "\r\n    ");
                __builder2.AddMarkupContent(10, "<h2 class=\"text-primary\">Добавить команду</h2>\r\n    ");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "form-group");
                __builder2.AddMarkupContent(13, "\r\n        ");
                __builder2.AddMarkupContent(14, "<label class=\"w-100\" for=\"name\">Название команды:</label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(15);
                __builder2.AddAttribute(16, "class", "w-100 form-control");
                __builder2.AddAttribute(17, "id", "name");
                __builder2.AddAttribute(18, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 16 "C:\Users\Полина\source\repos\TournamentTracker\TournamentTracker.Client\Pages\TeamForm.razor"
                                                                     Team.TeamName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(19, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Team.TeamName = __value, Team.TeamName))));
                __builder2.AddAttribute(20, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Team.TeamName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(21, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, "\r\n\r\n");
#nullable restore
#line 19 "C:\Users\Полина\source\repos\TournamentTracker\TournamentTracker.Client\Pages\TeamForm.razor"
     if (AllMembers != null)
    {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(23, "        ");
                __builder2.OpenElement(24, "div");
                __builder2.AddAttribute(25, "class", "form-group");
                __builder2.AddMarkupContent(26, "\r\n            ");
                __builder2.OpenElement(27, "div");
                __builder2.AddMarkupContent(28, "\r\n                ");
                __builder2.AddMarkupContent(29, "<label class=\"w-40\" for=\"members\">Выберете участника:</label>\r\n                ");
                __builder2.OpenElement(30, "button");
                __builder2.AddAttribute(31, "class", "btn btn-btn-outline-secondary w-40");
                __builder2.AddAttribute(32, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 24 "C:\Users\Полина\source\repos\TournamentTracker\TournamentTracker.Client\Pages\TeamForm.razor"
                                                                             () => { ShowDialog = true; }

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(33, "Создать нового участника");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(34, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(35, "\r\n            \r\n            ");
                __Blazor.TournamentTracker.Client.Pages.TeamForm.TypeInference.CreateInputSelect_0(__builder2, 36, 37, "form-control w-100 mb-2", 38, "members", 39, 
#nullable restore
#line 27 "C:\Users\Полина\source\repos\TournamentTracker\TournamentTracker.Client\Pages\TeamForm.razor"
                                                                                    SelectedMemberId

#line default
#line hidden
#nullable disable
                , 40, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => SelectedMemberId = __value, SelectedMemberId)), 41, () => SelectedMemberId, 42, (__builder3) => {
                    __builder3.AddMarkupContent(43, "\r\n                ");
                    __builder3.AddMarkupContent(44, "<option value>Выберете участника ...</option>\r\n");
#nullable restore
#line 29 "C:\Users\Полина\source\repos\TournamentTracker\TournamentTracker.Client\Pages\TeamForm.razor"
                 foreach (var member in AllMembers)
                    {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(45, "                    ");
                    __builder3.OpenElement(46, "option");
                    __builder3.AddAttribute(47, "value", 
#nullable restore
#line 31 "C:\Users\Полина\source\repos\TournamentTracker\TournamentTracker.Client\Pages\TeamForm.razor"
                                    member.Id.ToString()

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(48, 
#nullable restore
#line 31 "C:\Users\Полина\source\repos\TournamentTracker\TournamentTracker.Client\Pages\TeamForm.razor"
                                                           member.FullName

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(49, "\r\n");
#nullable restore
#line 32 "C:\Users\Полина\source\repos\TournamentTracker\TournamentTracker.Client\Pages\TeamForm.razor"
                    }

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(50, "            ");
                }
                );
                __builder2.AddMarkupContent(51, "\r\n            ");
                __builder2.OpenElement(52, "button");
                __builder2.AddAttribute(53, "class", "btn btn-primary w-100 mb-2");
                __builder2.AddAttribute(54, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 34 "C:\Users\Полина\source\repos\TournamentTracker\TournamentTracker.Client\Pages\TeamForm.razor"
                                                                 addMemberToTeam

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(55, "disabled", 
#nullable restore
#line 34 "C:\Users\Полина\source\repos\TournamentTracker\TournamentTracker.Client\Pages\TeamForm.razor"
                                                                                              SelectedMemberId == null  ? true : false

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(56, "Добавить участника в команду");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(57, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(58, "\r\n");
#nullable restore
#line 36 "C:\Users\Полина\source\repos\TournamentTracker\TournamentTracker.Client\Pages\TeamForm.razor"
    }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(59, "    ");
                __builder2.OpenElement(60, "div");
                __builder2.AddAttribute(61, "class", "form-group");
                __builder2.AddMarkupContent(62, "\r\n        ");
                __builder2.OpenElement(63, "div");
                __builder2.AddMarkupContent(64, "\r\n            ");
                __builder2.AddMarkupContent(65, "<label class=\"w-49\" for=\"name\">Участники команды:</label>\r\n            ");
                __builder2.OpenElement(66, "button");
                __builder2.AddAttribute(67, "class", "btn btn-outline-danger float-right w-49 mb-2 ");
                __builder2.AddAttribute(68, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 40 "C:\Users\Полина\source\repos\TournamentTracker\TournamentTracker.Client\Pages\TeamForm.razor"
                                                                                    () => { Team.TeamMembers.Clear(); }

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(69, "Удалить всех участников");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(70, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(71, "\r\n        ");
                __builder2.OpenElement(72, "p");
                __builder2.AddAttribute(73, "class", "w-100");
                __builder2.AddMarkupContent(74, "\r\n");
#nullable restore
#line 43 "C:\Users\Полина\source\repos\TournamentTracker\TournamentTracker.Client\Pages\TeamForm.razor"
             foreach (var m in Team.TeamMembers)
                

#line default
#line hidden
#nullable disable
                __builder2.AddContent(75, 
#nullable restore
#line 44 "C:\Users\Полина\source\repos\TournamentTracker\TournamentTracker.Client\Pages\TeamForm.razor"
                  m.FullName + ", "

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(76, "        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(77, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(78, "\r\n\r\n    ");
                __builder2.AddMarkupContent(79, "<button type=\"submit\" class=\"w-100 btn btn-primary\">Создать команду</button>\r\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(80, "\r\n");
#nullable restore
#line 50 "C:\Users\Полина\source\repos\TournamentTracker\TournamentTracker.Client\Pages\TeamForm.razor"
 if (ShowDialog)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(81, "    ");
            __builder.OpenElement(82, "div");
            __builder.AddAttribute(83, "class", 
#nullable restore
#line 52 "C:\Users\Полина\source\repos\TournamentTracker\TournamentTracker.Client\Pages\TeamForm.razor"
                 ShowDialog ? "show modal fade" : "modal fade"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(84, "tabindex", "-1");
            __builder.AddAttribute(85, "role", "dialog");
            __builder.AddAttribute(86, "style", "display:" + " " + (
#nullable restore
#line 52 "C:\Users\Полина\source\repos\TournamentTracker\TournamentTracker.Client\Pages\TeamForm.razor"
                                                                                                              ShowDialog ? "block" : "none"

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(87, "\r\n        ");
            __builder.OpenElement(88, "div");
            __builder.AddAttribute(89, "class", "modal-dialog");
            __builder.AddAttribute(90, "role", "document");
            __builder.AddMarkupContent(91, "\r\n            ");
            __builder.OpenElement(92, "div");
            __builder.AddAttribute(93, "class", "modal-content");
            __builder.AddMarkupContent(94, "\r\n                ");
            __builder.OpenElement(95, "div");
            __builder.AddAttribute(96, "class", "modal-body");
            __builder.AddMarkupContent(97, "\r\n                    ");
            __builder.OpenComponent<TournamentTracker.Client.Pages.MemberForm>(98);
            __builder.AddAttribute(99, "CallBack", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 56 "C:\Users\Полина\source\repos\TournamentTracker\TournamentTracker.Client\Pages\TeamForm.razor"
                                           UpdateAllMembersList

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(100, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(101, "\r\n                ");
            __builder.OpenElement(102, "div");
            __builder.AddAttribute(103, "class", "modal-footer");
            __builder.AddMarkupContent(104, "\r\n                    ");
            __builder.OpenElement(105, "button");
            __builder.AddAttribute(106, "type", "button");
            __builder.AddAttribute(107, "class", "btn btn-secondary");
            __builder.AddAttribute(108, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 59 "C:\Users\Полина\source\repos\TournamentTracker\TournamentTracker.Client\Pages\TeamForm.razor"
                                                                              () => { ShowDialog = false;}

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(109, "Закрыть");
            __builder.CloseElement();
            __builder.AddMarkupContent(110, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(111, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(112, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(113, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(114, "\r\n");
#nullable restore
#line 64 "C:\Users\Полина\source\repos\TournamentTracker\TournamentTracker.Client\Pages\TeamForm.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 66 "C:\Users\Полина\source\repos\TournamentTracker\TournamentTracker.Client\Pages\TeamForm.razor"
       
    [Parameter]
    public EventCallback<bool> CallBack { get; set; }

    private bool ShouldUpdate = false;
    private Team Team = new Team();
    private EditContext editContext;
    private List<Person> AllMembers;
    private string SelectedMemberId;
    private bool showDialog;
    private bool ShowDialog
    {
        get => showDialog;
        set
        {
            showDialog = value;
            StateHasChanged();
        }
    }
    protected override async Task OnInitializedAsync()
    {
        await UpdateAllMembersList();
        editContext = new EditContext(Team);
    }
    private async Task UpdateAllMembersList(bool shoulUpdate = true)
    {
        AllMembers = await memberService.GetMembers();
        StateHasChanged();
    }

    private async Task HandleSubmit()
    {
        var isValid = editContext.Validate();

        if (isValid)
        {
            Team newTeam = new Team
            {
                TeamName = Team.TeamName
            };
            int newTeamId = (await teamService.CreateTeam(newTeam)).Id;
            foreach (var member in Team.TeamMembers)
            {
                member.TeamId = newTeamId;
                await memberService.EditMember(member);
            }

            Team = new Team();
            SelectedMemberId = null;
            ShouldUpdate = true;
            await CallBack.InvokeAsync(ShouldUpdate);
            ShouldUpdate = false;
            StateHasChanged();

        }
        else
        {

        }
    }
    private void addMemberToTeam()
    {
        Team.TeamMembers.Add(AllMembers.Find(x => x.Id.ToString() == SelectedMemberId.ToString()));
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMemberService memberService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ITeamService teamService { get; set; }
    }
}
namespace __Blazor.TournamentTracker.Client.Pages.TeamForm
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputSelect_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "id", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.AddAttribute(__seq5, "ChildContent", __arg5);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
