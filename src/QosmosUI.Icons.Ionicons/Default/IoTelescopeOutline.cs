// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Ionicons.Default;

public class IoTelescopeOutline : ComponentBase
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
		builder.AddAttribute(14, "fill", "none");
		builder.AddAttribute(15, "stroke-linecap", "round");
		builder.AddAttribute(16, "stroke-linejoin", "round");
		builder.AddAttribute(17, "stroke-width", "32");
		builder.AddAttribute(18, "d", "M39.93,327.56l-4.71-8.13A24,24,0,0,1,44,286.64l86.87-50.07a16,16,0,0,1,21.89,5.86l12.71,22a16,16,0,0,1-5.86,21.85L72.76,336.35A24.06,24.06,0,0,1,39.93,327.56Z");
		builder.CloseElement();
		builder.OpenElement(19, "path");
		builder.AddAttribute(20, "fill", "none");
		builder.AddAttribute(21, "stroke-linecap", "round");
		builder.AddAttribute(22, "stroke-linejoin", "round");
		builder.AddAttribute(23, "stroke-width", "32");
		builder.AddAttribute(24, "d", "M170.68,273.72,147.12,233a24,24,0,0,1,8.8-32.78l124.46-71.75a16,16,0,0,1,21.89,5.86l31.57,54.59A16,16,0,0,1,328,210.76L203.51,282.5A24,24,0,0,1,170.68,273.72Z");
		builder.CloseElement();
		builder.OpenElement(25, "path");
		builder.AddAttribute(26, "fill", "none");
		builder.AddAttribute(27, "stroke-linecap", "round");
		builder.AddAttribute(28, "stroke-linejoin", "round");
		builder.AddAttribute(29, "stroke-width", "32");
		builder.AddAttribute(30, "d", "M341.85,202.21l-46.51-80.43A24,24,0,0,1,304.14,89l93.29-53.78A24.07,24.07,0,0,1,430.27,44l46.51,80.43a24,24,0,0,1-8.8,32.79L374.69,211A24.06,24.06,0,0,1,341.85,202.21Z");
		builder.CloseElement();
		builder.OpenElement(31, "line");
		builder.AddAttribute(32, "fill", "none");
		builder.AddAttribute(33, "stroke-linecap", "round");
		builder.AddAttribute(34, "stroke-linejoin", "round");
		builder.AddAttribute(35, "stroke-width", "32");
		builder.AddAttribute(36, "x1", "127.59");
		builder.AddAttribute(37, "y1", "480");
		builder.AddAttribute(38, "x2", "223.73");
		builder.AddAttribute(39, "y2", "272.01");
		builder.CloseElement();
		builder.OpenElement(40, "line");
		builder.AddAttribute(41, "fill", "none");
		builder.AddAttribute(42, "stroke-linecap", "round");
		builder.AddAttribute(43, "stroke-linejoin", "round");
		builder.AddAttribute(44, "stroke-width", "32");
		builder.AddAttribute(45, "x1", "271.8");
		builder.AddAttribute(46, "y1", "256.02");
		builder.AddAttribute(47, "x2", "368.55");
		builder.AddAttribute(48, "y2", "448");
		builder.CloseElement();
		builder.CloseElement();
    }
}
