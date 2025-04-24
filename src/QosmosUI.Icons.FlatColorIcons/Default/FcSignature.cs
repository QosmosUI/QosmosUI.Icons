// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FlatColorIcons.Default;

public class FcSignature : ComponentBase
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
		builder.AddAttribute(14, "fill", "#1565C0");
		builder.AddAttribute(15, "d", "M38.8,28.2C41.5,24.8,45,20.1,45,12c0-0.6-0.4-1-1-1s-1,0.4-1,1c0,6.7-2.5,10.7-5,13.9c-0.6-1.9-1-4.2-1-6.9 c0-0.5-0.4-1-1-1c-0.5,0-1,0.4-1,1c-0.1,1.7-0.6,3.6-1,3.8c-0.4,0-0.9-1.4-1-2.8c0-0.5-0.5-0.9-1-0.9c-0.5,0-1,0.3-1,0.9 c-0.3,1.7-1.1,4.1-2,4.1c-0.4,0-0.6-0.1-0.7-0.3c-0.3-0.3-0.4-1-0.4-1.6c0-0.4,0.1-0.8,0.1-1.2c0-0.5-0.4-1-0.9-1 c-0.5,0-1,0.3-1.1,0.8c0,0.1-0.1,0.5-0.1,1.1C25.7,23.6,25.1,27,23,27c-0.7,0-1.1-0.2-1.4-0.7c-0.5-0.8-0.5-2.1,0-3.3c0,0,0,0,0-0.1 c0.1-0.1,0.1-0.3,0.2-0.4c0,0,0,0,0,0c0.8-1.6,1.7-2.5,3.2-2.5c0.6,0,1-0.4,1-1s-0.4-1-1-1c-4.2,0-5.4,4.1-6.6,8 c-1.4,4.8-2.7,8-6.4,8c-5.1,0-7-6.6-7-11c0-8.6,4.7-14,9-14c2.9,0,4,2.3,4.1,2.4c0.2,0.5,0.8,0.7,1.3,0.5c0.5-0.2,0.7-0.8,0.5-1.3 C19.8,10.4,18.2,7,14,7C8.6,7,3,13,3,23c0,10.3,5.9,13,9,13c5.1,0,6.8-4.5,8.1-8.5c0.7,0.9,1.7,1.5,2.9,1.5c2.2,0,3.5-1.6,4.2-3.6 c0.5,0.4,1.1,0.6,1.8,0.6c1.4,0,2.4-1.2,3-2.4c0.4,0.7,1.1,1.2,2,1.2c0.6,0,1.1-0.3,1.5-0.7c0.3,1.4,0.7,2.7,1,3.8 C35.1,29.7,34,31.2,34,33c0,1.7,1.3,3,3,3c1.8,0,3-1.6,3-3c0-1.3-0.5-2.7-1.1-4.3C38.9,28.5,38.8,28.4,38.8,28.2z M37,34 c-0.7,0-1-0.5-1-1c0-0.9,0.5-1.8,1.3-2.9c0.4,1.2,0.7,2.1,0.7,2.9C38,33.3,37.7,34,37,34z");
		builder.CloseElement();
		builder.OpenElement(16, "rect");
		builder.AddAttribute(17, "x", "3");
		builder.AddAttribute(18, "y", "40");
		builder.AddAttribute(19, "fill", "#90A4AE");
		builder.AddAttribute(20, "width", "42");
		builder.AddAttribute(21, "height", "2");
		builder.CloseElement();
		builder.CloseElement();
    }
}
