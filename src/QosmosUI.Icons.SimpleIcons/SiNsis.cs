// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons;

public class SiNsis : ComponentBase
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
		builder.AddAttribute(15, "d", "M13.736 24H24l-5.132-4.919L13.736 24Zm-6.021-5.064 5.133 4.918 5.132-4.919-10.265.001Zm-6.539-5.272v9.838l5.132-4.919-1.503-1.441-3.629-3.478Zm21.648-1.626-5.132 4.919 5.132 4.919v-9.838Zm-4.844 6.193-5.132-4.92-5.132 4.92H17.98ZM1.696 13.165l5.132 4.92 5.132-4.92H1.696Zm20.608-1.625H12.039l5.133 4.919 5.132-4.919ZM6.828 7.541l-5.132 4.92H11.96l-5.132-4.92Zm-5.652 4.421 5.132-4.919-5.132-4.919v9.838Zm21.128-1.127-5.132-4.92-5.133 4.92h10.265Zm-6.02-5.065H6.02l5.132 4.919 5.132-4.919Zm6.54-5.272-5.132 4.919 5.132 4.92V.498Zm-6.539 4.567L11.152.146 6.02 5.065h10.265ZM10.264 0H0l5.132 4.919L10.264 0Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
