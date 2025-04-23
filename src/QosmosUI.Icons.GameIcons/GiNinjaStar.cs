// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiNinjaStar : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 512 512";

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
		builder.AddAttribute(14, "d", "M277.95 333.754c-18.707 5.27-39.12 3.777-57.213-5.024-8.2 15.105-12.253 34.398-14.837 55.104L24.977 477.958c41.176-120.353 94.123-176.934 153.265-200.01-5.278-18.693-3.76-39.107 5.024-57.207-15.113-8.19-34.397-12.236-55.12-14.843L34.038 24.973c120.345 41.192 176.92 94.13 199.987 153.273 18.7-5.27 39.115-3.753 57.214 5.008 8.215-15.09 12.253-34.374 14.844-55.112l180.94-94.116c-41.193 120.37-94.148 176.95-153.29 200.02 5.27 18.7 3.777 39.113-5.016 57.213 15.113 8.215 34.398 12.236 55.112 14.828l94.14 180.94c-120.392-41.208-176.95-94.132-200.02-153.274zm-16.66-36.538c22.752-2.916 38.837-23.756 35.922-46.51-2.924-22.768-23.74-38.83-46.517-35.922-22.745 2.916-38.83 23.733-35.907 46.493 2.908 22.76 23.733 38.846 46.5 35.94z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
