// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FontAwesome.Solid;

public class FaHandsBound : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 640 512";

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
		builder.AddAttribute(14, "d", "M96 32C96 14.3 81.7 0 64 0S32 14.3 32 32l0 64 0 59.1 0 .7L32 192l0 21.9c0 14.2 5.1 27.9 14.3 38.7L131.6 352l-3.6 0c-13.3 0-24 10.7-24 24s10.7 24 24 24l32 0 128 0 64 0 128 0 32 0c13.3 0 24-10.7 24-24s-10.7-24-24-24l-3.6 0 85.3-99.5c9.2-10.8 14.3-24.5 14.3-38.7l0-21.9 0-36.2 0-.7L608 96l0-64c0-17.7-14.3-32-32-32s-32 14.3-32 32l0 64 0 48.8-69.3 92.4c-5.7 7.6-16.1 9.6-24.2 4.8c-9.7-5.7-12.1-18.7-5.1-27.5L473 180c10.8-13.5 8.9-33.3-4.4-44.5s-33-9.8-44.5 3.2l-46.7 52.5C361 209.7 352 233.4 352 258.1l0 61.9 0 32-64 0 0-32 0-61.9c0-24.6-9-48.4-25.4-66.8l-46.7-52.5c-11.5-13-31.3-14.4-44.5-3.2s-15.2 30.9-4.4 44.5l27.6 34.5c7 8.8 4.7 21.8-5.1 27.5c-8.1 4.8-18.6 2.7-24.2-4.8L96 144.8 96 96l0-64zm64 448l0 32 128 0 0-32 64 0 0 32 128 0 0-32 32 0c13.3 0 24-10.7 24-24s-10.7-24-24-24l-32 0-128 0-64 0-128 0-32 0c-13.3 0-24 10.7-24 24s10.7 24 24 24l32 0z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
