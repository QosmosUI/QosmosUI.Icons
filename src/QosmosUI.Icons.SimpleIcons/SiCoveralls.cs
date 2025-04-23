// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons;

public class SiCoveralls : ComponentBase
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
		builder.AddAttribute(15, "d", "M0 12v12h24V0H0zm13.195-6.187l1.167 3.515 2.255.005c1.238.005 2.916.019 3.727.037l1.472.028-2.968 2.152c-1.63 1.181-2.976 2.18-2.99 2.212-.01.033.487 1.627 1.106 3.54.619 1.917 1.12 3.487 1.116 3.492-.005.01-1.35-.947-2.986-2.119-1.636-1.177-3-2.147-3.033-2.161-.028-.01-1.411.947-3.07 2.138-1.655 1.185-3.02 2.151-3.024 2.142-.004-.005.497-1.575 1.116-3.492.619-1.913 1.115-3.507 1.106-3.54-.014-.032-1.36-1.03-2.99-2.212L2.23 9.398l1.472-.028c.811-.018 2.49-.032 3.727-.037l2.254-.005 1.168-3.515a512.54 512.54 0 011.171-3.516c.005 0 .53 1.58 1.172 3.516z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
