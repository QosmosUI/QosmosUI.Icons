// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.RemixIcons.Default;

public class RiGpsFill : ComponentBase
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
		builder.AddAttribute(14, "d", "M12 16L15 22H9L12 16ZM9.37258 16.2548C7.94863 15.3737 7 13.7976 7 12C7 9.23858 9.23858 7 12 7C14.7614 7 17 9.23858 17 12C17 13.7976 16.0514 15.3737 14.6274 16.2548L13.2718 13.5436C13.7165 13.1768 14 12.6215 14 12C14 10.8954 13.1046 10 12 10C10.8954 10 10 10.8954 10 12C10 12.6215 10.2835 13.1768 10.7282 13.5436L9.37258 16.2548ZM7.13153 20.7369C4.07014 19.0274 2 15.7554 2 12C2 6.47715 6.47715 2 12 2C17.5228 2 22 6.47715 22 12C22 15.7554 19.9299 19.0274 16.8685 20.7369L15.5246 18.0492C17.6033 16.8354 19 14.5808 19 12C19 8.13401 15.866 5 12 5C8.13401 5 5 8.13401 5 12C5 14.5808 6.39666 16.8354 8.47539 18.0492L7.13153 20.7369Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
