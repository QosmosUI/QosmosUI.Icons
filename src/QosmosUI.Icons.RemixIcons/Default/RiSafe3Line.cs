// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.RemixIcons.Default;

public class RiSafe3Line : ComponentBase
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
		builder.AddAttribute(14, "d", "M2 4C2 3.44772 2.44772 3 3 3H21C21.5523 3 22 3.44772 22 4V19C22 19.5523 21.5523 20 21 20H20V22H18V20H6V22H4V20H3C2.44772 20 2 19.5523 2 19V4ZM4 18H5H19H20V5H4V18ZM15.3492 8.23642C14.2058 7.58767 12.7942 7.58767 11.6508 8.23642L10.318 6.90366L8.90381 8.31787L10.2366 9.65063C9.58781 10.794 9.58781 12.2057 10.2366 13.3491L8.90381 14.6818L10.318 16.096L11.6508 14.7633C12.7942 15.412 14.2058 15.412 15.3492 14.7633L16.682 16.096L18.0962 14.6818L16.7634 13.3491C17.4122 12.2057 17.4122 10.794 16.7634 9.65063L18.0962 8.31787L16.682 6.90366L15.3492 8.23642ZM14.7374 10.2624C15.4209 10.9458 15.4209 12.0539 14.7374 12.7373C14.054 13.4207 12.946 13.4207 12.2626 12.7373C11.5791 12.0539 11.5791 10.9458 12.2626 10.2624C12.946 9.579 14.054 9.579 14.7374 10.2624ZM5 8V15H7V8H5Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
