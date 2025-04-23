// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.TablerIcons.Fill;

public class TbFillBrandPaypal : ComponentBase
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
		builder.AddAttribute(14, "d", "M12.5 2c3.113 0 5.309 1.785 5.863 4.565c1.725 1.185 2.637 3.152 2.637 5.435c0 2.933 -2.748 5.384 -5.783 5.496l-.217 .004h-1.754l-.466 2.8a1.998 1.998 0 0 1 -1.823 1.597l-.157 .003h-2.68a1.5 1.5 0 0 1 -1.182 -.54a1.495 1.495 0 0 1 -.348 -1.07l.042 -.29h-1.632c-1.004 0 -1.914 -.864 -1.994 -1.857l-.006 -.143l.01 -.141l1.993 -13.954l.003 -.048c.072 -.894 .815 -1.682 1.695 -1.832l.156 -.02l.143 -.005h5.5zm5.812 7.35l-.024 .087c-.706 2.403 -3.072 4.436 -5.555 4.557l-.233 .006h-2.503v.05l-.025 .183l-1.2 5a1.007 1.007 0 0 1 -.019 .07l-.088 .597h2.154l.595 -3.564a1 1 0 0 1 .865 -.829l.121 -.007h2.6c2.073 0 4 -1.67 4 -3.5c0 -1.022 -.236 -1.924 -.688 -2.65z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
