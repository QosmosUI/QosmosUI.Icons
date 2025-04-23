// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FlatColorIcons;

public class FcInvite : ComponentBase
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
		builder.AddAttribute(14, "fill", "#78909C");
		builder.AddAttribute(15, "d", "M40,41H8c-2.2,0-4-1.8-4-4l0-20.9c0-1.3,0.6-2.5,1.7-3.3L24,0l18.3,12.8c1.1,0.7,1.7,2,1.7,3.3V37 C44,39.2,42.2,41,40,41z");
		builder.CloseElement();
		builder.OpenElement(16, "rect");
		builder.AddAttribute(17, "x", "12");
		builder.AddAttribute(18, "y", "11");
		builder.AddAttribute(19, "fill", "#fff");
		builder.AddAttribute(20, "width", "24");
		builder.AddAttribute(21, "height", "22");
		builder.CloseElement();
		builder.OpenElement(22, "path");
		builder.AddAttribute(23, "fill", "#CFD8DC");
		builder.AddAttribute(24, "d", "M40,41H8c-2.2,0-4-1.8-4-4l0-20l20,13l20-13v20C44,39.2,42.2,41,40,41z");
		builder.CloseElement();
		builder.OpenElement(25, "g");
		builder.AddAttribute(26, "fill", "#4CAF50");
		builder.OpenElement(27, "rect");
		builder.AddAttribute(28, "x", "22");
		builder.AddAttribute(29, "y", "14");
		builder.AddAttribute(30, "width", "4");
		builder.AddAttribute(31, "height", "12");
		builder.CloseElement();
		builder.OpenElement(32, "rect");
		builder.AddAttribute(33, "x", "18");
		builder.AddAttribute(34, "y", "18");
		builder.AddAttribute(35, "width", "12");
		builder.AddAttribute(36, "height", "4");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
