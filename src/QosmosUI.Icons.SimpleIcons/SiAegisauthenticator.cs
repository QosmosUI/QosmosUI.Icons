// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons;

public class SiAegisauthenticator : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 24 24";

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
		builder.OpenElement(13, "title");
		builder.CloseElement();
		builder.OpenElement(14, "path");
		builder.AddAttribute(15, "d", "m6.9487 19.8732-.0074.0133a1.483 1.483 0 0 0-.0013 1.469l.3165.5565c.2639.4638.7563.75 1.2897.75h.0163c1.139 0 1.853-1.2301 1.2883-2.219l-.325-.5697c-.5693-.9974-2.0074-.9974-2.577-.0002m3.4905-6.1074a1.483 1.483 0 0 0-.0013 1.4688l3.7964 6.6769c.2639.4638.756.7503 1.2897.7503h.0156c1.139 0 1.853-1.2301 1.2883-2.219l-3.8118-6.677c-.5693-.9974-2.0077-.9974-2.5768 0m.3275-11.692L.1972 20.4648c-.5618.9775.1438 2.1969 1.2713 2.1969a1.467 1.467 0 0 0 1.2734-.7393l7.9513-13.9285c.5632-.9867 1.9861-.9855 2.548.0026l7.9175 13.9239a1.466 1.466 0 0 0 1.2746.7416h.0982c1.1255 0 1.8313-1.2152 1.2736-2.193L13.3116 2.0776c-.5616-.9844-1.98-.9867-2.5448-.0039");
		builder.CloseElement();
		builder.CloseElement();
    }
}
