// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Ionicons.Default;

public class IoPizzaSharp : ComponentBase
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
		builder.AddAttribute(14, "d", "M442.3,67.82h0C383.92,44.72,317.78,32,256,32c-63.57,0-129.8,12.51-186.56,35.25C49.18,75.48,42,80,42,80l22,44,37.53-16.14C147.58,89.53,199.19,80,256.51,80,314,80,364.6,89.23,411.26,108.25h0L448,124l22-44S463,76,442.3,67.82Z");
		builder.CloseElement();
		builder.OpenElement(15, "ellipse");
		builder.AddAttribute(16, "cx", "320.48");
		builder.AddAttribute(17, "cy", "207.99");
		builder.AddAttribute(18, "rx", "31.97");
		builder.AddAttribute(19, "ry", "32.03");
		builder.AddAttribute(20, "transform", "translate(-53.23 287.42) rotate(-44.98)");
		builder.AddAttribute(21, "fill", "none");
		builder.CloseElement();
		builder.OpenElement(22, "ellipse");
		builder.AddAttribute(23, "cx", "192.48");
		builder.AddAttribute(24, "cy", "191.99");
		builder.AddAttribute(25, "rx", "31.97");
		builder.AddAttribute(26, "ry", "32.03");
		builder.AddAttribute(27, "transform", "translate(-79.38 192.25) rotate(-44.98)");
		builder.AddAttribute(28, "fill", "none");
		builder.CloseElement();
		builder.OpenElement(29, "ellipse");
		builder.AddAttribute(30, "cx", "256.48");
		builder.AddAttribute(31, "cy", "319.99");
		builder.AddAttribute(32, "rx", "31.97");
		builder.AddAttribute(33, "ry", "32.03");
		builder.AddAttribute(34, "transform", "translate(-151.13 274.96) rotate(-44.98)");
		builder.AddAttribute(35, "fill", "none");
		builder.CloseElement();
		builder.OpenElement(36, "path");
		builder.AddAttribute(37, "d", "M409.66,140.85C364.15,122.52,308.16,112,256,112A425,425,0,0,0,102.3,140.9c-.25.1-9.24,4.23-19,8.71,7.46,16.22,18,39.16,22.2,48.33L256,480,429.74,149.16l-19.92-8.24ZM224.41,194.07a32,32,0,1,1-34-34A32.12,32.12,0,0,1,224.41,194.07Zm64,128a32,32,0,1,1-34-34A32.12,32.12,0,0,1,288.41,322.07Zm64-112a32,32,0,1,1-34-34A32.12,32.12,0,0,1,352.41,210.07Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
