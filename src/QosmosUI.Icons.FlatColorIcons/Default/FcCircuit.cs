// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FlatColorIcons.Default;

public class FcCircuit : ComponentBase
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
		builder.AddAttribute(15, "d", "M6,10v28c0,2.2,1.8,4,4,4h28c2.2,0,4-1.8,4-4V10c0-2.2-1.8-4-4-4H10C7.8,6,6,7.8,6,10z");
		builder.CloseElement();
		builder.OpenElement(16, "g");
		builder.AddAttribute(17, "fill", "#FFC107");
		builder.OpenElement(18, "path");
		builder.AddAttribute(19, "d", "M6.6,8l6,6c-0.4,0.6-0.6,1.3-0.6,2c0,2.2,1.8,4,4,4s4-1.8,4-4s-1.8-4-4-4c-0.7,0-1.4,0.2-2,0.6l-6-6 C7.4,6.9,6.9,7.4,6.6,8z M16,14.5c0.8,0,1.5,0.7,1.5,1.5s-0.7,1.5-1.5,1.5s-1.5-0.7-1.5-1.5S15.2,14.5,16,14.5z");
		builder.CloseElement();
		builder.OpenElement(20, "path");
		builder.AddAttribute(21, "d", "M41.4,40l-6-6c0.4-0.6,0.6-1.3,0.6-2c0-2.2-1.8-4-4-4s-4,1.8-4,4s1.8,4,4,4c0.7,0,1.4-0.2,2-0.6l6,6 C40.6,41.1,41.1,40.6,41.4,40z M32,33.5c-0.8,0-1.5-0.7-1.5-1.5s0.7-1.5,1.5-1.5s1.5,0.7,1.5,1.5S32.8,33.5,32,33.5z");
		builder.CloseElement();
		builder.OpenElement(22, "path");
		builder.AddAttribute(23, "d", "M16,36c2.2,0,4-1.8,4-4c0-0.7-0.2-1.4-0.6-2L30,19.4c0.6,0.4,1.3,0.6,2,0.6c2.2,0,4-1.8,4-4s-1.8-4-4-4 s-4,1.8-4,4c0,0.7,0.2,1.4,0.6,2L18,28.6c-0.6-0.4-1.3-0.6-2-0.6c-2.2,0-4,1.8-4,4S13.8,36,16,36z M32,14.5c0.8,0,1.5,0.7,1.5,1.5 s-0.7,1.5-1.5,1.5s-1.5-0.7-1.5-1.5S31.2,14.5,32,14.5z M16,30.5c0.8,0,1.5,0.7,1.5,1.5s-0.7,1.5-1.5,1.5s-1.5-0.7-1.5-1.5 S15.2,30.5,16,30.5z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
