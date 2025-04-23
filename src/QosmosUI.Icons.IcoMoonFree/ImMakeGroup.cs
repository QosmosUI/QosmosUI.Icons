// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.IcoMoonFree;

public class ImMakeGroup : ComponentBase
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
		builder.AddAttribute(14, "d", "M5 2h-2c-0.55 0-1 0.45-1 1v2c0 0.55 0.45 1 1 1h2c0.55 0 1-0.45 1-1v-2c0-0.55-0.45-1-1-1z");
		builder.CloseElement();
		builder.OpenElement(15, "path");
		builder.AddAttribute(16, "d", "M11 6h2c0.55 0 1-0.45 1-1v-2c0-0.55-0.45-1-1-1h-2c-0.55 0-1 0.45-1 1v2c0 0.55 0.45 1 1 1zM11 3h2v2h-2v-2z");
		builder.CloseElement();
		builder.OpenElement(17, "path");
		builder.AddAttribute(18, "d", "M5 10h-2c-0.55 0-1 0.45-1 1v2c0 0.55 0.45 1 1 1h2c0.55 0 1-0.45 1-1v-2c0-0.55-0.45-1-1-1zM5 13h-2v-2h2v2z");
		builder.CloseElement();
		builder.OpenElement(19, "path");
		builder.AddAttribute(20, "d", "M13 10h-2c-0.55 0-1 0.45-1 1v2c0 0.55 0.45 1 1 1h2c0.55 0 1-0.45 1-1v-2c0-0.55-0.45-1-1-1z");
		builder.CloseElement();
		builder.OpenElement(21, "path");
		builder.AddAttribute(22, "d", "M14 8h-1c-1.336 0-2.591-0.52-3.536-1.464s-1.464-2.2-1.464-3.536v-1c0-1.1-0.9-2-2-2h-4c-1.1 0-2 0.9-2 2v4c0 1.1 0.9 2 2 2h1c1.336 0 2.591 0.52 3.536 1.464s1.464 2.2 1.464 3.536v1c0 1.1 0.9 2 2 2h4c1.1 0 2-0.9 2-2v-4c0-1.1-0.9-2-2-2zM15 14c0 0.265-0.105 0.515-0.295 0.705s-0.44 0.295-0.705 0.295h-4c-0.265 0-0.515-0.105-0.705-0.295s-0.295-0.44-0.295-0.705v-1c0-3.314-2.686-6-6-6h-1c-0.265 0-0.515-0.105-0.705-0.295s-0.295-0.441-0.295-0.705v-4c0-0.265 0.105-0.515 0.295-0.705s0.44-0.295 0.705-0.295h4c0.265 0 0.515 0.105 0.705 0.295s0.295 0.44 0.295 0.705v1c0 3.314 2.686 6 6 6h1c0.265 0 0.515 0.105 0.705 0.295s0.295 0.44 0.295 0.705v4z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
