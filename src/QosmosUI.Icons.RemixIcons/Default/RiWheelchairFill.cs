// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.RemixIcons.Default;

public class RiWheelchairFill : ComponentBase
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
		builder.AddAttribute(14, "d", "M7.99837 10.3413L7.99793 12.5352C6.80239 13.2268 5.99805 14.5195 5.99805 16C5.99805 18.2091 7.78891 20 9.99805 20C11.4786 20 12.7712 19.1957 13.4628 18.0001L15.6565 18.0004C14.8327 20.3306 12.6103 22 9.99805 22C6.68434 22 3.99805 19.3137 3.99805 16C3.99805 13.3874 5.66782 11.1649 7.99837 10.3413ZM11.998 17C10.3412 17 8.99805 15.6569 8.99805 14V10C8.99805 8.34315 10.3412 7 11.998 7C13.6549 7 14.998 8.34315 14.998 10V15H16.4319C17.0803 15 17.6849 15.3141 18.0584 15.8362L18.1468 15.971L20.8555 20.4855L19.1406 21.5145L16.4319 17H11.998ZM11.998 2C13.3788 2 14.498 3.11929 14.498 4.5C14.498 5.88071 13.3788 7 11.998 7C10.6173 7 9.49805 5.88071 9.49805 4.5C9.49805 3.11929 10.6173 2 11.998 2Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
