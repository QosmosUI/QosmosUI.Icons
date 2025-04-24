// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.RemixIcons.Default;

public class RiGooglePlayLine : ComponentBase
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
		builder.AddAttribute(14, "d", "M4.00098 1.73438C4.17692 1.73438 4.34975 1.7808 4.50201 1.86895L20.5061 11.1345C20.9841 11.4112 21.1473 12.023 20.8705 12.501C20.783 12.6522 20.6574 12.7778 20.5061 12.8654L4.50201 22.1309C4.02405 22.4076 3.41226 22.2445 3.13555 21.7665C3.0474 21.6143 3.00098 21.4414 3.00098 21.2655V2.73438C3.00098 2.18209 3.44869 1.73438 4.00098 1.73438ZM12.2931 13.4132L7.79498 17.9124L13.494 14.6134L12.2931 13.4132ZM4.99998 6.11938V17.8784L10.8791 11.9992L4.99998 6.11938ZM15.284 10.4214L13.7071 11.9992L15.285 13.5764L18.009 11.9999L15.284 10.4214ZM7.79398 6.08537L12.2931 10.5852L13.493 9.38437L7.79398 6.08537Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
