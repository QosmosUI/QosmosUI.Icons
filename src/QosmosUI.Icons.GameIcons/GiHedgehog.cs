// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiHedgehog : ComponentBase
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
		builder.AddAttribute(14, "d", "m202.2 116.5.9 24.3 69 25.4 7.8-21zm92.7 10.9-9.2 22.5 55.6 46.2 14.5-17.1zm-100.2 10.7-75.7 1.4 10.9 22.2 65.2-1.2zm-75.3 24.8-65.64 34.3 20.1 14.9 56.04-29.2zm255 2.1-14.9 17.7 43.2 61.1c-11.9 6.1-24.4 13.3-36.5 19.9-40.1-64.6-101-1.2-47.3 38.2-43.3 67.9-159.7-10.4-240.61 66.5-8.44-6.5-14.9-56.3-15.15-61.1l-22.48 1c2.58 31.6 8.9 56.5 19.44 82.5h299.4c44.5 0 88.1-12.5 125.8-36.1 4.2-2.7 7.6-11.1 7.8-18.2H473c-3 0-5.9-1.6-7.3-4.3-1.5-2.8-1.4-6 .3-8.6l8.6-13.6c-15.9-7.9-43.3-27.7-50.1-72.3l-.4-2.6zM63.46 218.4l-44.45 75.8 25.37 1.2 38.49-65.5zM385 282.5c3.8-.1 7.8.5 11.9 1.9 13.1 4.3 21.2 15 18.2 23.7-3 8.9-15.8 12.4-28.9 8.1-13-4.4-21.1-15.1-18.1-23.8 2-6 8.7-9.6 16.9-9.9z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
