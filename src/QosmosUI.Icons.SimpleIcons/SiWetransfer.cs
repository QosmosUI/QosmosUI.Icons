// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons;

public class SiWetransfer : ComponentBase
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
		builder.AddAttribute(15, "d", "M13.855 11.891c0-3.382 2.4-5.4 5.51-5.4C22.145 6.491 24 7.91 24 9.873c0 1.855-1.582 3.055-3.328 3.055-.982 0-1.69-.164-2.182-.546-.163-.164-.272-.109-.272.055 0 .709.272 1.254.709 1.745.382.382 1.09.655 1.745.655.71 0 1.31-.164 1.855-.437.545-.272.982-.163 1.254.273.328.49-.109 1.145-.49 1.582-.71.763-2.073 1.309-3.819 1.309-3.545-.11-5.618-2.51-5.618-5.673zm-7.254 2.237c.327 0 .545.163.763.545l.982 1.582c.382.6.709 1.036 1.418 1.036.71 0 1.091-.273 1.418-1.09a21.11 21.11 0 001.31-3.873c.49-1.855.709-2.946.709-3.873s-.273-1.473-1.31-1.637c-1.363-.272-3.272-.381-5.29-.381-2.019 0-3.928.109-5.291.327C.273 6.982 0 7.528 0 8.454c0 .928.219 2.019.655 3.874a28.714 28.714 0 001.31 3.872c.381.818.708 1.091 1.417 1.091.71 0 1.037-.436 1.419-1.036l.981-1.582c.273-.327.491-.545.819-.545z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
