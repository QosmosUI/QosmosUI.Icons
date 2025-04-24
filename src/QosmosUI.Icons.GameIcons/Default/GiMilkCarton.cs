// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiMilkCarton : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "1em";

    [Parameter]
    public string Stroke { get; set; } = "currentColor";

    [Parameter]
    public string Fill { get; set; } = "currentColor";

    [Parameter]
    public string StrokeWidth { get; set; } = "0";

    [Parameter]
    public string StrokeLinecap { get; set; } = "round";

    [Parameter]
    public string StrokeLinejoin { get; set; } = "round";

    [Parameter]
    public string ViewBox { get; set; } = "0 0 512 512";

    [Parameter(CaptureUnmatchedValues = true)]
    public IReadOnlyDictionary<string, object>? AdditionalAttributes { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder.OpenElement(0, "svg");
        builder.AddAttribute(1, "xmlns", "http://www.w3.org/2000/svg");
        builder.AddAttribute(2, "viewBox", ViewBox);
        builder.AddAttribute(3, "width", Size);
        builder.AddAttribute(4, "height", Size);
        builder.AddAttribute(5, "fill", Fill);
        builder.AddAttribute(6, "stroke", Stroke);
        builder.AddAttribute(7, "stroke-width", StrokeWidth);
        builder.AddAttribute(8, "stroke-linecap", StrokeLinecap);
        builder.AddAttribute(9, "stroke-linejoin", StrokeLinejoin);
        builder.AddMultipleAttributes(10, AdditionalAttributes);
        if (!string.IsNullOrEmpty(Title))
        {
            builder.OpenElement(11, "title");
            builder.AddContent(12, Title);
            builder.CloseElement();
        }
		builder.OpenElement(13, "path");
		builder.AddAttribute(14, "d", "M302.958 20.019l-93.916 46.564v35.404c31.305-15.522 62.61-31.047 93.916-46.568zm6.53 52.252l-95.4 47.3 63.036 78.137 95.397-47.303zm-111.915 55.492l-33.732 16.724h47.224zm-22.119 34.722l71.615 26.633-21.484-26.633zm-41.021 3.948v276.752l131.22 48.796v-276.75zm243.134 1.56c-31.306 15.521-62.61 31.044-93.916 46.567v275.863l93.916-46.567zM176.501 272.466s-15.3 15.085-9.889 24.203c4.167 7.02 21.889 5.418 21.889 5.418l15.549 3.848s17.72 10.374 21.887 5.416c5.41-6.44-9.887-29.098-9.887-29.098s35.91 33.492 29.662 47.318c-3.143 6.955-24.719-2.117-24.719-2.117s5.495 7.21 4.944 10.549c-1.001 6.062-13.774 9.916-13.774 9.916s1.111 21.24-6 25.168c-5.147 2.843-14.628.497-19.775-4.895-7.111-7.448-6-28.136-6-28.136s-12.775-10.177-13.776-16.735c-.55-3.611 4.944-8.103 4.944-8.103s-21.575-1.607-24.717-10.117c-6.247-16.919 29.662-32.635 29.662-32.635z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
