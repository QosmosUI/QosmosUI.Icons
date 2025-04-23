// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.TablerIcons.Fill;

public class TbFillRollercoaster : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "24";

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
		builder.OpenElement(13, "path");
		builder.AddAttribute(14, "d", "M21 8a1 1 0 0 1 0 2v11a1 1 0 0 1 -2 0v-11h-1.675q -.163 0 -.325 .007v10.993a1 1 0 0 1 -2 0v-10.645a7.8 7.8 0 0 0 -2 .959v9.686a1 1 0 0 1 -2 0v-7.748a7.8 7.8 0 0 0 -1.051 2.064l-.735 2.205a7 7 0 0 1 -.213 .553l-.001 2.926a1 1 0 0 1 -2 0l.001 -.364a6.54 6.54 0 0 1 -4.001 1.364a1 1 0 0 1 0 -2a4.55 4.55 0 0 0 4.316 -3.111l.735 -2.205a9.775 9.775 0 0 1 9.274 -6.684zm-10.22 -3.625l2 2.5a1 1 0 0 1 -.18 1.425l-4 3a1 1 0 0 1 -.868 .164l-1.8 -.5a1 1 0 0 1 -.727 -.864l-.2 -2a1 1 0 0 1 .395 -.9l4 -3a1 1 0 0 1 1.38 .175m9.22 -2.375a1 1 0 0 1 1 1v3a1 1 0 0 1 -1 1h-5a1 1 0 0 1 -1 -1v-3a1 1 0 0 1 1 -1z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
