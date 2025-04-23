// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.TablerIcons.Fill;

public class TbFillTiltShift : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "24";

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
		builder.AddAttribute(14, "d", "M8.178 2.766a1 1 0 1 1 .764 1.848a8 8 0 0 0 -2.595 1.733a1 1 0 1 1 -1.414 -1.414a10 10 0 0 1 3.245 -2.167");
		builder.CloseElement();
		builder.OpenElement(15, "path");
		builder.AddAttribute(16, "d", "M2.767 8.176a1 1 0 1 1 1.846 .768a8 8 0 0 0 -.613 3.058a1 1 0 0 1 -2 -.004a10 10 0 0 1 .767 -3.822");
		builder.CloseElement();
		builder.OpenElement(17, "path");
		builder.AddAttribute(18, "d", "M3.308 14.516a1 1 0 0 1 1.306 .542a8 8 0 0 0 1.733 2.595a1 1 0 1 1 -1.414 1.414a10 10 0 0 1 -2.167 -3.245a1 1 0 0 1 .542 -1.306");
		builder.CloseElement();
		builder.OpenElement(19, "path");
		builder.AddAttribute(20, "d", "M7.637 19.926a1 1 0 0 1 1.307 -.54a8 8 0 0 0 3.058 .614a1 1 0 0 1 -.004 2a10 10 0 0 1 -3.822 -.767a1 1 0 0 1 -.54 -1.307");
		builder.CloseElement();
		builder.OpenElement(21, "path");
		builder.AddAttribute(22, "d", "M17.653 17.653a1 1 0 1 1 1.414 1.414a10 10 0 0 1 -3.245 2.167a1 1 0 1 1 -.764 -1.848a8 8 0 0 0 2.595 -1.733");
		builder.CloseElement();
		builder.OpenElement(23, "path");
		builder.AddAttribute(24, "d", "M21.002 11a1 1 0 0 1 .998 1.002a10 10 0 0 1 -.767 3.822a1 1 0 1 1 -1.846 -.768a8 8 0 0 0 .613 -3.058a1 1 0 0 1 1.002 -.998");
		builder.CloseElement();
		builder.OpenElement(25, "path");
		builder.AddAttribute(26, "d", "M17.653 4.933a1 1 0 0 1 1.414 0a10 10 0 0 1 2.167 3.245a1 1 0 1 1 -1.848 .764a8 8 0 0 0 -1.733 -2.595a1 1 0 0 1 0 -1.414");
		builder.CloseElement();
		builder.OpenElement(27, "path");
		builder.AddAttribute(28, "d", "M12.002 2a10 10 0 0 1 3.822 .767a1 1 0 1 1 -.768 1.846a8 8 0 0 0 -3.058 -.613a1 1 0 0 1 .004 -2");
		builder.CloseElement();
		builder.OpenElement(29, "path");
		builder.AddAttribute(30, "d", "M12 9a3 3 0 1 1 -3 3l.005 -.176a3 3 0 0 1 2.995 -2.824");
		builder.CloseElement();
		builder.CloseElement();
    }
}
