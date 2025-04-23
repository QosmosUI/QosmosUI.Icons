// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FlatColorIcons;

public class FcEngineering : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 48 48";

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
		builder.AddAttribute(14, "fill", "#EF6C00");
		builder.AddAttribute(15, "d", "M37.4,24.6l-11.6-2.2l-3.9-11.2l-3.8,1.3L22,23.6l-7.8,9l3,2.6l7.8-9l11.6,2.2L37.4,24.6z");
		builder.CloseElement();
		builder.OpenElement(16, "g");
		builder.AddAttribute(17, "fill", "#FF9800");
		builder.OpenElement(18, "path");
		builder.AddAttribute(19, "d", "M24,19c-2.8,0-5,2.2-5,5c0,2.8,2.2,5,5,5s5-2.2,5-5C29,21.2,26.8,19,24,19z M24,26c-1.1,0-2-0.9-2-2 c0-1.1,0.9-2,2-2s2,0.9,2,2C26,25.1,25.1,26,24,26z");
		builder.CloseElement();
		builder.OpenElement(20, "path");
		builder.AddAttribute(21, "d", "M40.7,27c0.2-1,0.3-2,0.3-3c0-1-0.1-2-0.3-3l3.3-2.4c0.4-0.3,0.6-0.9,0.3-1.4L40,9.8 c-0.3-0.5-0.8-0.7-1.3-0.4L35,11c-1.5-1.3-3.3-2.3-5.2-3l-0.4-4.1c-0.1-0.5-0.5-0.9-1-0.9h-8.6c-0.5,0-1,0.4-1,0.9L18.2,8 c-1.9,0.7-3.7,1.7-5.2,3L9.3,9.3C8.8,9.1,8.2,9.3,8,9.8l-4.3,7.4c-0.3,0.5-0.1,1.1,0.3,1.4L7.3,21C7.1,22,7,23,7,24 c0,1,0.1,2,0.3,3L4,29.4c-0.4,0.3-0.6,0.9-0.3,1.4L8,38.2c0.3,0.5,0.8,0.7,1.3,0.4L13,37c1.5,1.3,3.3,2.3,5.2,3l0.4,4.1 c0.1,0.5,0.5,0.9,1,0.9h8.6c0.5,0,1-0.4,1-0.9l0.4-4.1c1.9-0.7,3.7-1.7,5.2-3l3.7,1.7c0.5,0.2,1.1,0,1.3-0.4l4.3-7.4 c0.3-0.5,0.1-1.1-0.3-1.4L40.7,27z M24,35c-6.1,0-11-4.9-11-11c0-6.1,4.9-11,11-11s11,4.9,11,11C35,30.1,30.1,35,24,35z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
