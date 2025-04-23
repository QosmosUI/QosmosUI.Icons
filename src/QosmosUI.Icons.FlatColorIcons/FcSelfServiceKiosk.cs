// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FlatColorIcons;

public class FcSelfServiceKiosk : ComponentBase
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
		builder.AddAttribute(14, "fill", "#546E7A");
		builder.AddAttribute(15, "d", "M44,30H4V11c0-2.2,1.8-4,4-4h32c2.2,0,4,1.8,4,4V30z");
		builder.CloseElement();
		builder.OpenElement(16, "path");
		builder.AddAttribute(17, "fill", "#64B5F6");
		builder.AddAttribute(18, "d", "M40,27H8c-0.6,0-1-0.4-1-1V11c0-0.6,0.4-1,1-1h32c0.6,0,1,0.4,1,1v15C41,26.6,40.6,27,40,27z");
		builder.CloseElement();
		builder.OpenElement(19, "path");
		builder.AddAttribute(20, "fill", "#78909C");
		builder.AddAttribute(21, "d", "M40,41H8c-2.2,0-4-1.8-4-4v-7h40v7C44,39.2,42.2,41,40,41z");
		builder.CloseElement();
		builder.OpenElement(22, "g");
		builder.AddAttribute(23, "fill", "#37474F");
		builder.OpenElement(24, "rect");
		builder.AddAttribute(25, "x", "27");
		builder.AddAttribute(26, "y", "34");
		builder.AddAttribute(27, "width", "12");
		builder.AddAttribute(28, "height", "2");
		builder.CloseElement();
		builder.OpenElement(29, "rect");
		builder.AddAttribute(30, "x", "9");
		builder.AddAttribute(31, "y", "34");
		builder.AddAttribute(32, "width", "12");
		builder.AddAttribute(33, "height", "2");
		builder.CloseElement();
		builder.OpenElement(34, "path");
		builder.AddAttribute(35, "d", "M18,35c0,1.1-1.3,2-3,2s-3-0.9-3-2H18z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
