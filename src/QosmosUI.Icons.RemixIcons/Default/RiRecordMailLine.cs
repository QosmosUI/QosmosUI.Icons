// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.RemixIcons.Default;

public class RiRecordMailLine : ComponentBase
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
		builder.OpenElement(13, "path");
		builder.AddAttribute(14, "d", "M14.2572 15C13.4718 14.0491 13 12.8296 13 11.5C13 8.46243 15.4624 6 18.5 6C21.5376 6 24 8.46243 24 11.5C24 14.5376 21.5376 17 18.5 17H5.5C2.46243 17 0 14.5376 0 11.5C0 8.46243 2.46243 6 5.5 6C8.53757 6 11 8.46243 11 11.5C11 12.8296 10.5282 14.0491 9.74284 15H14.2572ZM5.5 15C7.433 15 9 13.433 9 11.5C9 9.567 7.433 8 5.5 8C3.567 8 2 9.567 2 11.5C2 13.433 3.567 15 5.5 15ZM18.5 15C20.433 15 22 13.433 22 11.5C22 9.567 20.433 8 18.5 8C16.567 8 15 9.567 15 11.5C15 13.433 16.567 15 18.5 15Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
