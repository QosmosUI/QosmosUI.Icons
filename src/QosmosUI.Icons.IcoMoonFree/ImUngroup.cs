// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.IcoMoonFree;

public class ImUngroup : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "16";

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
    public string ViewBox { get; set; } = "0 0 16 16";

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
		builder.AddAttribute(14, "d", "M6 7.25c0 0.412-0.338 0.75-0.75 0.75h-1.5c-0.413 0-0.75-0.338-0.75-0.75v-1.5c0-0.412 0.337-0.75 0.75-0.75h1.5c0.412 0 0.75 0.338 0.75 0.75v1.5z");
		builder.CloseElement();
		builder.OpenElement(15, "path");
		builder.AddAttribute(16, "d", "M11 7.25c0 0.412-0.338 0.75-0.75 0.75h-1.5c-0.412 0-0.75-0.338-0.75-0.75v-1.5c0-0.412 0.338-0.75 0.75-0.75h1.5c0.412 0 0.75 0.338 0.75 0.75v1.5z");
		builder.CloseElement();
		builder.OpenElement(17, "path");
		builder.AddAttribute(18, "d", "M6 12.25c0 0.412-0.338 0.75-0.75 0.75h-1.5c-0.413 0-0.75-0.338-0.75-0.75v-1.5c0-0.412 0.337-0.75 0.75-0.75h1.5c0.412 0 0.75 0.338 0.75 0.75v1.5z");
		builder.CloseElement();
		builder.OpenElement(19, "path");
		builder.AddAttribute(20, "d", "M11 12.25c0 0.412-0.338 0.75-0.75 0.75h-1.5c-0.412 0-0.75-0.338-0.75-0.75v-1.5c0-0.412 0.338-0.75 0.75-0.75h1.5c0.412 0 0.75 0.338 0.75 0.75v1.5z");
		builder.CloseElement();
		builder.OpenElement(21, "path");
		builder.AddAttribute(22, "d", "M14.251 2.5l1.749-1.749v-0.751h-0.751l-1.749 1.749-1.749-1.749h-0.751v0.751l1.749 1.749-1.749 1.749v0.751h0.751l1.749-1.749 1.749 1.749h0.751v-0.751z");
		builder.CloseElement();
		builder.OpenElement(23, "path");
		builder.AddAttribute(24, "d", "M0 12h1v2h-1v-2z");
		builder.CloseElement();
		builder.OpenElement(25, "path");
		builder.AddAttribute(26, "d", "M0 9h1v2h-1v-2z");
		builder.CloseElement();
		builder.OpenElement(27, "path");
		builder.AddAttribute(28, "d", "M13 7h1v2h-1v-2z");
		builder.CloseElement();
		builder.OpenElement(29, "path");
		builder.AddAttribute(30, "d", "M13 13h1v2h-1v-2z");
		builder.CloseElement();
		builder.OpenElement(31, "path");
		builder.AddAttribute(32, "d", "M13 10h1v2h-1v-2z");
		builder.CloseElement();
		builder.OpenElement(33, "path");
		builder.AddAttribute(34, "d", "M0 6h1v2h-1v-2z");
		builder.CloseElement();
		builder.OpenElement(35, "path");
		builder.AddAttribute(36, "d", "M0 3h1v2h-1v-2z");
		builder.CloseElement();
		builder.OpenElement(37, "path");
		builder.AddAttribute(38, "d", "M8 2h2v1h-2v-1z");
		builder.CloseElement();
		builder.OpenElement(39, "path");
		builder.AddAttribute(40, "d", "M5 2h2v1h-2v-1z");
		builder.CloseElement();
		builder.OpenElement(41, "path");
		builder.AddAttribute(42, "d", "M2 2h2v1h-2v-1z");
		builder.CloseElement();
		builder.OpenElement(43, "path");
		builder.AddAttribute(44, "d", "M7 15h2v1h-2v-1z");
		builder.CloseElement();
		builder.OpenElement(45, "path");
		builder.AddAttribute(46, "d", "M10 15h2v1h-2v-1z");
		builder.CloseElement();
		builder.OpenElement(47, "path");
		builder.AddAttribute(48, "d", "M4 15h2v1h-2v-1z");
		builder.CloseElement();
		builder.OpenElement(49, "path");
		builder.AddAttribute(50, "d", "M1 15h2v1h-2v-1z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
