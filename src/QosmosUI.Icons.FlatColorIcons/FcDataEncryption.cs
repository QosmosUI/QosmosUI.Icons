// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FlatColorIcons;

public class FcDataEncryption : ComponentBase
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
		builder.OpenElement(13, "g");
		builder.AddAttribute(14, "fill", "#D1C4E9");
		builder.OpenElement(15, "path");
		builder.AddAttribute(16, "d", "M38,7H10C8.9,7,8,7.9,8,9v6c0,1.1,0.9,2,2,2h28c1.1,0,2-0.9,2-2V9C40,7.9,39.1,7,38,7z");
		builder.CloseElement();
		builder.OpenElement(17, "path");
		builder.AddAttribute(18, "d", "M38,19H10c-1.1,0-2,0.9-2,2v6c0,1.1,0.9,2,2,2h25.1c1.3-1.3,4.9-0.9,4.9-2v-6C40,19.9,39.1,19,38,19z");
		builder.CloseElement();
		builder.OpenElement(19, "path");
		builder.AddAttribute(20, "d", "M34.4,31H10c-1.1,0-2,0.9-2,2v6c0,1.1,0.9,2,2,2h28c1.1,0,2-0.9,2-2v-2.4C40,33.5,37.5,31,34.4,31z");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(21, "g");
		builder.AddAttribute(22, "fill", "#FFA000");
		builder.OpenElement(23, "polygon");
		builder.AddAttribute(24, "points", "43,46 41,48 39,48 37,46 37,35.4 43,35.4 43,40 42,41 43,42 43,43 42,44 43,45");
		builder.CloseElement();
		builder.OpenElement(25, "path");
		builder.AddAttribute(26, "d", "M47.5,28.5c-0.3-0.9-1-1.6-2-1.8C44.2,26.4,42.2,26,40,26s-4.2,0.4-5.5,0.6c-1,0.2-1.7,0.9-2,1.8 C32.3,29.4,32,30.6,32,32c0,1.4,0.3,2.6,0.5,3.5c0.3,0.9,1,1.6,2,1.8c1.3,0.3,3.2,0.6,5.5,0.6s4.2-0.4,5.5-0.6c1-0.2,1.7-0.9,2-1.8 c0.3-0.9,0.5-2.1,0.5-3.5C48,30.6,47.7,29.4,47.5,28.5z M42.9,31h-5.7c-0.6,0-1.1-0.5-1.1-1.1v-1.4c0-0.3,1.8-0.6,4-0.6 s4,0.3,4,0.6v1.4C44,30.5,43.5,31,42.9,31z");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(27, "rect");
		builder.AddAttribute(28, "x", "39");
		builder.AddAttribute(29, "y", "37.1");
		builder.AddAttribute(30, "fill", "#D68600");
		builder.AddAttribute(31, "width", "1");
		builder.AddAttribute(32, "height", "10.9");
		builder.CloseElement();
		builder.CloseElement();
    }
}
