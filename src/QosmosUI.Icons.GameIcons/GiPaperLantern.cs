// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiPaperLantern : ComponentBase
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
		builder.AddAttribute(14, "d", "M48.32 20.4v24.47h99.88V20.4zM372 24.68c-30.3.91-53 48.3-54.3 75.09 0 21.53 7.4 40.83 18.7 54.53-61.6 11.6-66.3 115.4-66.3 188.3h30.3l-10.1-11.4c-.4-51.8 1.8-95.2 24-135.5-6.1 99.9 3.2 208.7 9.9 299.1h85.2l-65-11.8c-11.9-104.4-18.9-205.7-4.5-308.5 0 0 9.5-6.1 24.3-13.4-14.2-12.1-23.6-33.3-23.6-57.4 0-37.59 22.8-68.04 50.9-68.04 8.9 0 17.2 3.04 24.5 8.39-10.4-11.98-24.3-19.26-39.4-19.26-1.6 0-3.2-.14-4.6-.11zM43.24 63.56C29.11 81.97 20.35 107.5 20.35 135.8c0 29.9 9.79 56.8 25.36 75.4H149.1c15.6-18.6 25.3-45.5 25.3-75.4 0-28.3-8.7-53.83-22.8-72.24zM441.2 196l1.7 147.2 22.3-.3c-4.9-51.7-3.2-107.2-24-146.9zM48.32 229.8v24.5h99.88v-24.5z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
