// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.IcoMoonFree;

public class ImSpoonKnife : ComponentBase
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
		builder.AddAttribute(14, "d", "M3.5 0c-1.657 0-3 1.567-3 3.5 0 1.655 0.985 3.042 2.308 3.406l-0.497 8.096c-0.034 0.549 0.389 0.998 0.939 0.998h0.5c0.55 0 0.972-0.449 0.939-0.998l-0.497-8.096c1.323-0.365 2.308-1.751 2.308-3.406 0-1.933-1.343-3.5-3-3.5zM13.583 0l-0.833 5h-0.625l-0.417-5h-0.417l-0.417 5h-0.625l-0.833-5h-0.417v6.5c0 0.276 0.224 0.5 0.5 0.5h1.302l-0.491 8.002c-0.034 0.549 0.389 0.998 0.939 0.998h0.5c0.55 0 0.972-0.449 0.939-0.998l-0.491-8.002h1.302c0.276 0 0.5-0.224 0.5-0.5v-6.5h-0.417z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
