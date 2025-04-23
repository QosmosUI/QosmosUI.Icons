// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.TablerIcons.Fill;

public class TbFillPoo : ComponentBase
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
		builder.AddAttribute(14, "d", "M11.063 2.995l.086 .009h.07c2.237 .098 3.87 1.686 4.214 4.046l.01 .075l.133 .04a3.5 3.5 0 0 1 1.718 1.22l.125 .179a3.5 3.5 0 0 1 .567 2.243l-.006 .049l.032 .025a4 4 0 0 1 1.476 2.8l.01 .191l.15 .125a4 4 0 0 1 1.29 3.693l-.042 .208c-.4 1.728 -1.89 2.986 -3.72 3.092h-10.176a4 4 0 0 1 -2.638 -7.008l.14 -.118l.011 -.19a4 4 0 0 1 1.476 -2.798l.032 -.025l-.006 -.048a3.5 3.5 0 0 1 .452 -2.058l.114 -.186c.603 -.912 1.598 -1.49 2.755 -1.564h.164c.743 0 1.26 -1.242 .606 -2.553l.006 .015l-.01 -.017a1 1 0 0 1 -.095 -.323l-.007 -.117c0 -.654 .539 -1.031 1.063 -1.005m3.758 12.434a1 1 0 0 0 -1.392 -.25a2.5 2.5 0 0 1 -2.858 0a1 1 0 0 0 -1.142 1.642a4.5 4.5 0 0 0 5.142 0a1 1 0 0 0 .25 -1.392m-4.811 -4.429h-.01a1 1 0 0 0 0 2h.01a1 1 0 0 0 0 -2m4 0h-.01a1 1 0 0 0 0 2h.01a1 1 0 0 0 0 -2");
		builder.CloseElement();
		builder.CloseElement();
    }
}
