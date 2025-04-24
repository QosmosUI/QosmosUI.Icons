// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FlatColorIcons.Default;

public class FcIcons8Cup : ComponentBase
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
		builder.AddAttribute(14, "fill", "#4CAF50");
		builder.AddAttribute(15, "d", "M40,14H8l3.8,28.3c0.1,1,1,1.7,2,1.7h20.5c1,0,1.8-0.7,2-1.7L40,14z");
		builder.CloseElement();
		builder.OpenElement(16, "g");
		builder.AddAttribute(17, "fill", "#81C784");
		builder.OpenElement(18, "path");
		builder.AddAttribute(19, "d", "M42,14H6v-3c0-2.2,1.8-4,4-4h28c2.2,0,4,1.8,4,4V14z");
		builder.CloseElement();
		builder.OpenElement(20, "path");
		builder.AddAttribute(21, "d", "M37.2,10H10.8l1.7-4.7c0.3-0.8,1-1.3,1.9-1.3h19.2c0.8,0,1.6,0.5,1.9,1.3L37.2,10z");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(22, "path");
		builder.AddAttribute(23, "fill", "#E8F5E9");
		builder.AddAttribute(24, "d", "M28,28.5c1.2-1.1,2-2.7,2-4.5c0-3.3-2.7-6-6-6c-3.3,0-6,2.7-6,6c0,1.8,0.8,3.4,2,4.5c-1.2,1.1-2,2.7-2,4.5 c0,3.3,2.7,6,6,6c3.3,0,6-2.7,6-6C30,31.2,29.2,29.6,28,28.5z M24,36c-1.7,0-3-1.3-3-3c0-1.7,1.3-3,3-3c1.7,0,3,1.3,3,3 C27,34.7,25.7,36,24,36z M24,27c-1.7,0-3-1.3-3-3c0-1.7,1.3-3,3-3c1.7,0,3,1.3,3,3C27,25.7,25.7,27,24,27z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
