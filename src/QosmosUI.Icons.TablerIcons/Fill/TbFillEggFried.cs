// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.TablerIcons.Fill;

public class TbFillEggFried : ComponentBase
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
		builder.AddAttribute(14, "d", "M14.001 1.996q .06 0 .117 .007l.155 .003a6 6 0 0 1 4.25 2.05l.176 .21a6 6 0 0 1 1.296 4.014l-.018 .244l.106 .06a4 4 0 0 1 1.904 3.087l.011 .204a4 4 0 0 1 -1.392 3.161l-.085 .069l.083 .16a4 4 0 0 1 .239 2.848l-.065 .204a4 4 0 0 1 -6.257 1.824l-.115 -.096l-.092 .1a6 6 0 0 1 -4.022 1.787l-.257 .006a6 6 0 0 1 -5.644 -8.04l.034 -.089l-.155 -.12a6 6 0 0 1 -1.662 -7.256l.105 -.211a6 6 0 0 1 7.246 -2.894l.188 .068l.073 -.06a6 6 0 0 1 3.505 -1.334zm-2.001 7.004a3 3 0 0 0 -2.996 2.85l-.004 .15a3 3 0 1 0 3 -3");
		builder.CloseElement();
		builder.CloseElement();
    }
}
