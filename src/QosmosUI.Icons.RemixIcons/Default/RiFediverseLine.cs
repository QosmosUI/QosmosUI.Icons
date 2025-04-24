// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.RemixIcons.Default;

public class RiFediverseLine : ComponentBase
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
		builder.AddAttribute(14, "d", "M11.0002 11.5V8.23202L8.17007 9.86602L7.17007 8.13397L10.0002 6.5L7.17007 4.86602L8.17007 3.13397L11.0002 4.76798V1.5H13.0002V4.76792L15.8303 3.13397L16.8303 4.86603L14.0002 6.5L16.8303 8.13397L15.8303 9.86602L13.0002 8.23208V11.5H11.0002ZM21.4596 12.884L18.6294 14.518V11.25H16.6294V14.518L13.7992 12.884L12.7992 14.616L15.6294 16.25L12.7993 17.884L13.7993 19.616L16.6294 17.9821V21.25H18.6294V17.9821L21.4595 19.616L22.4595 17.884L19.6294 16.25L22.4596 14.616L21.4596 12.884ZM7.37109 17.9815L7.37109 21.2495L5.37109 21.2495L5.37109 17.9816L2.54102 19.6155L1.54102 17.8835L4.37114 16.2495L1.54102 14.6155L2.54102 12.8835L5.37109 14.5174L5.37109 11.2495H7.37109L7.37109 14.5175L10.2013 12.8835L11.2013 14.6155L8.37114 16.2495L11.2013 17.8835L10.2013 19.6155L7.37109 17.9815Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
