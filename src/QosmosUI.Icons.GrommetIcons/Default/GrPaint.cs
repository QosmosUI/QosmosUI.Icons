// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GrommetIcons.Default;

public class GrPaint : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "24";

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
		builder.OpenElement(13, "path");
		builder.AddAttribute(14, "fill", "none");
		builder.AddAttribute(15, "stroke-width", "2");
		builder.AddAttribute(16, "d", "M4,10 L2,10 C2,4.4771525 2,1 12,1 C22,1 22,4.4771525 22,10 L20,10 M12,10 C16.418278,10 20,9.1045695 20,8 C20,6.8954305 16.418278,6 12,6 C7.581722,6 4,6.8954305 4,8 C4,9.1045695 7.581722,10 12,10 Z M4,20 C4,21.6568542 7.581722,23 12,23 C16.418278,23 20,21.6568542 20,20 M20,8 L20,20 L20,8 Z M4,20 L4,8 L4,20 Z M8,13 L8,17 M13,13 L13,17 M7,12 C5.5,12 4,11 4,8 M18,13.5 C18,13.5 18,14 18,12 C18,10 20,11 20,8 M8,13 C8,12.4477153 7.55228475,12 7,12 M13,13 C13,12.4477153 13.4477153,12 14,12 C14.5522847,12 15,12.4477153 15,13 L15,13.5 M15,13.5 C15,14.3284271 15.6715729,15 16.5,15 C17.3284271,15 18,14.3284271 18,13.5 M8,17 C8,18.3807119 9.11928813,19.5 10.5,19.5 C11.8807119,19.5 13,18.3807119 13,17");
		builder.CloseElement();
		builder.CloseElement();
    }
}
