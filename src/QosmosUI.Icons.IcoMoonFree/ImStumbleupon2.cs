// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.IcoMoonFree;

public class ImStumbleupon2 : ComponentBase
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
		builder.AddAttribute(14, "d", "M13.313 0h-10.625c-1.478 0-2.688 1.209-2.688 2.688v10.625c0 1.478 1.209 2.688 2.688 2.688h10.625c1.478 0 2.688-1.209 2.688-2.688v-10.625c0-1.478-1.209-2.688-2.688-2.688zM8 5c-0.551 0-1 0.449-1 1v4c0 1.654-1.346 3-3 3s-3-1.346-3-3v-2h2v2c0 0.551 0.449 1 1 1s1-0.449 1-1v-4c0-1.654 1.346-3 3-3s3 1.346 3 2.781v0.969l-1.281 0.375-0.719-0.375v-0.969c0-0.333-0.449-0.781-1-0.781zM15 10c0 1.654-1.346 3-3 3s-3-1.346-3-3.219v-1.938l0.719 0.375 1.281-0.375v1.938c0 0.77 0.449 1.219 1 1.219s1-0.449 1-1v-2h2v2z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
