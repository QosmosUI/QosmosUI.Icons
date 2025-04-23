// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FlatColorIcons;

public class FcFrame : ComponentBase
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
		builder.AddAttribute(14, "fill", "#3949AB");
		builder.AddAttribute(15, "d", "M40.6,40.1h-1.4c-0.2,0-0.3,0-0.5,0l-3.1-0.4c-2.4-0.3-4.9-0.2-7.3,0.4l-3.6,0.9c-0.5,0.1-1.1,0.1-1.6,0 L19.6,40c-2.4-0.6-4.8-0.7-7.3-0.4l-3.1,0.4c-0.2,0-0.3,0-0.5,0H7.4c-1.9,0-3.4-1.5-3.4-3.4v0c0-0.4,0.1-0.9,0.2-1.3l0.2-0.6 c1-2.5,1.1-5.3,0.4-7.9l-0.6-2c-0.2-0.7-0.2-1.3,0-2l0.3-0.8c0.9-2.7,0.8-5.7-0.2-8.4l-0.1-0.3C4.1,13.1,4,12.7,4,12.3v-1 c0-1.9,1.5-3.4,3.4-3.4l1.4,0c0.2,0,0.3,0,0.5,0l3.1,0.4c2.4,0.3,4.9,0.2,7.3-0.4l3.6-0.9c0.5-0.1,1.1-0.1,1.6,0L28.4,8 c2.4,0.6,4.8,0.7,7.3,0.4l3.1-0.4c0.2,0,0.3,0,0.5,0l1.4,0c1.9,0,3.4,1.5,3.4,3.4v1c0,0.4-0.1,0.9-0.2,1.3l-0.1,0.3 c-1.1,2.7-1.2,5.6-0.2,8.4l0.3,0.8c0.2,0.6,0.2,1.3,0,2l-0.6,2c-0.7,2.6-0.6,5.4,0.4,7.9l0.2,0.6c0.2,0.4,0.2,0.8,0.2,1.3v0 C44,38.6,42.5,40.1,40.6,40.1z");
		builder.CloseElement();
		builder.OpenElement(16, "path");
		builder.AddAttribute(17, "fill", "#BBDEFB");
		builder.AddAttribute(18, "d", "M38,36H10c-0.6,0-1-0.4-1-1V13c0-0.6,0.4-1,1-1h28c0.6,0,1,0.4,1,1v22C39,35.6,38.6,36,38,36z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
