// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiSchneiderelectric : ComponentBase
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
		builder.AddAttribute(15, "d", "M16.73.313c-3.56-.049-7.797 1.68-11.288 5.02-.87.83-1.607 1.725-2.28 2.642h3.042L5.497 9.99H1.864c-.346.636-.672 1.266-.922 1.906h4.307l-.687 2.016H.327c-.724 3.079-.262 5.953 1.559 7.777 3.54 3.538 11.01 2.292 16.591-3.048.977-.93 1.783-1.931 2.511-2.96h-3.906l.596-2.013h4.568c.334-.64.643-1.274.883-1.914h-4.992l.554-2.01h5.051c.623-2.917.132-5.62-1.638-7.39C20.76 1.01 18.867.34 16.73.312Zm-1.044 4.714h4.968l-.634 2.938h-3.002c-.323 0-.46.054-.592.201-.05.058-.07.115-.09.23l-1.639 6.22c-.385 2.179-3.065 4.359-6.555 4.359H3.288l.842-3.198h3.119a.984.984 0 0 0 .775-.347c.076-.09.177-.232.19-.377L9.509 9.62c.381-2.182 2.686-4.592 6.177-4.592Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
