// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GrommetIcons.Default;

public class GrWebcam : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "24";

    [Parameter]
    public string Stroke { get; set; } = "currentColor";

    [Parameter]
    public string Fill { get; set; } = "none";

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
		builder.AddAttribute(14, "d", "M20 22H4");
		builder.AddAttribute(15, "stroke-width", "2");
		builder.AddAttribute(16, "stroke-linecap", "round");
		builder.CloseElement();
		builder.OpenElement(17, "path");
		builder.AddAttribute(18, "d", "M15.5 18V21");
		builder.AddAttribute(19, "stroke-width", "2");
		builder.CloseElement();
		builder.OpenElement(20, "path");
		builder.AddAttribute(21, "d", "M8 21.5V18");
		builder.AddAttribute(22, "stroke-width", "2");
		builder.CloseElement();
		builder.OpenElement(23, "path");
		builder.AddAttribute(24, "fill-rule", "evenodd");
		builder.AddAttribute(25, "clip-rule", "evenodd");
		builder.AddAttribute(26, "d", "M12 19C16.9706 19 21 14.9706 21 10C21 5.02944 16.9706 1 12 1C7.02944 1 3 5.02944 3 10C3 14.9706 7.02944 19 12 19Z");
		builder.AddAttribute(27, "stroke-width", "2");
		builder.CloseElement();
		builder.OpenElement(28, "path");
		builder.AddAttribute(29, "fill-rule", "evenodd");
		builder.AddAttribute(30, "clip-rule", "evenodd");
		builder.AddAttribute(31, "d", "M12 16C15.3137 16 18 13.3137 18 10C18 6.68629 15.3137 4 12 4C8.68629 4 6 6.68629 6 10C6 13.3137 8.68629 16 12 16Z");
		builder.AddAttribute(32, "stroke-width", "2");
		builder.CloseElement();
		builder.OpenElement(33, "path");
		builder.AddAttribute(34, "fill-rule", "evenodd");
		builder.AddAttribute(35, "clip-rule", "evenodd");
		builder.AddAttribute(36, "d", "M12 14C14.2091 14 16 12.2091 16 10C16 7.79086 14.2091 6 12 6C9.79086 6 8 7.79086 8 10C8 12.2091 9.79086 14 12 14Z");
		builder.AddAttribute(37, "stroke-width", "2");
		builder.CloseElement();
		builder.OpenElement(38, "path");
		builder.AddAttribute(39, "fill-rule", "evenodd");
		builder.AddAttribute(40, "clip-rule", "evenodd");
		builder.AddAttribute(41, "d", "M12 11C12.5523 11 13 10.5523 13 10C13 9.44772 12.5523 9 12 9C11.4477 9 11 9.44772 11 10C11 10.5523 11.4477 11 12 11Z");
		builder.AddAttribute(42, "stroke-width", "2");
		builder.CloseElement();
		builder.CloseElement();
    }
}
