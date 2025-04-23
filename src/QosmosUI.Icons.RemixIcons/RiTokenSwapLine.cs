// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.RemixIcons;

public class RiTokenSwapLine : ComponentBase
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
		builder.AddAttribute(14, "d", "M9 12.5 6.5 15 9 17.5 11.5 15 9 12.5ZM15 2.5C11.5724 2.5 8.76444 5.15304 8.51763 8.51763 5.15304 8.76445 2.5 11.5724 2.5 15 2.5 18.5899 5.41015 21.5 9 21.5 12.4276 21.5 15.2356 18.847 15.4824 15.4824 18.847 15.2356 21.5 12.4276 21.5 9 21.5 5.41015 18.5899 2.5 15 2.5ZM15.3234 13.4886C14.7575 11.1126 12.8874 9.24245 10.5114 8.67665 10.6772 6.34229 12.6234 4.5 15 4.5 17.4853 4.5 19.5 6.51472 19.5 9 19.5 11.3766 17.6577 13.3228 15.3234 13.4886ZM13.5 15C13.5 17.4853 11.4853 19.5 9 19.5 6.51472 19.5 4.5 17.4853 4.5 15 4.5 12.5147 6.51472 10.5 9 10.5 11.4853 10.5 13.5 12.5147 13.5 15ZM3 7C3 4.79086 4.79086 3 7 3H8.5V5H7C5.89543 5 5 5.89543 5 7V8.5H3V7ZM19 17V15.5H21V17C21 19.2091 19.2091 21 17 21H15.5V19H17C18.1046 19 19 18.1046 19 17Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
