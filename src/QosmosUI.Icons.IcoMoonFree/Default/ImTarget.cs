// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.IcoMoonFree.Default;

public class ImTarget : ComponentBase
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
		builder.AddAttribute(14, "d", "M16 7h-1.577c-0.432-2.785-2.638-4.991-5.423-5.423v-1.577h-2v1.577c-2.785 0.432-4.991 2.638-5.423 5.423h-1.577v2h1.577c0.432 2.785 2.638 4.991 5.423 5.423v1.577h2v-1.577c2.785-0.432 4.991-2.638 5.423-5.423h1.577v-2zM12.388 7h-1.559c-0.301-0.852-0.977-1.528-1.829-1.829v-1.559c1.68 0.383 3.005 1.708 3.388 3.388zM8 9c-0.552 0-1-0.448-1-1s0.448-1 1-1c0.552 0 1 0.448 1 1s-0.448 1-1 1zM7 3.612v1.559c-0.852 0.301-1.528 0.977-1.829 1.829h-1.559c0.383-1.68 1.708-3.005 3.388-3.388zM3.612 9h1.559c0.301 0.852 0.977 1.528 1.829 1.829v1.559c-1.68-0.383-3.005-1.708-3.388-3.388zM9 12.388v-1.559c0.852-0.301 1.528-0.977 1.829-1.829h1.559c-0.383 1.68-1.708 3.005-3.388 3.388z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
