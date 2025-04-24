// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiMaptiler : ComponentBase
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
		builder.AddAttribute(15, "d", "m7.794 1.655 4.188 4.188 4.204-4.204A6.13 6.13 0 0 0 12 0a6.136 6.136 0 0 0-4.204 1.655ZM3.25 6.197 7.455 1.99l4.19 4.19-4.206 4.207Zm-.315 8.697 4.168-4.168-2.889-2.89-1.298-1.299a6.19 6.19 0 0 0 .02 8.357zm14.728-5.64 3.073-3.073-4.208-4.207-4.207 4.207 4.207 4.206Zm-6.015 6.013L7.44 11.061l-4.172 4.172 4.206 4.208zm5.216-4.543 4.185 4.185a6.18 6.18 0 0 0 .02-8.387l-4.205 4.202zm-2.448 6.639 2.093 2.092 4.207-4.206-4.188-4.188-4.207 4.206zM11.968 24a3007.16 3007.16 0 0 0 4.2-4.208l-4.187-4.188-4.17 4.174c1.386 1.407 2.773 2.813 4.157 4.222Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
