// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.CircumIcons;

public class CiGrid42 : ComponentBase
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
		builder.OpenElement(13, "g");
		builder.AddAttribute(14, "id", "Grid_4-2");
		builder.OpenElement(15, "g");
		builder.OpenElement(16, "g");
		builder.OpenElement(17, "path");
		builder.AddAttribute(18, "d", "M8.5,13.933H5.563a2.5,2.5,0,0,1-2.5-2.5V5.563a2.5,2.5,0,0,1,2.5-2.5H8.5a2.5,2.5,0,0,1,2.5,2.5v5.87A2.5,2.5,0,0,1,8.5,13.933ZM5.563,4.063a1.5,1.5,0,0,0-1.5,1.5v5.87a1.5,1.5,0,0,0,1.5,1.5H8.5a1.5,1.5,0,0,0,1.5-1.5V5.563a1.5,1.5,0,0,0-1.5-1.5Z");
		builder.CloseElement();
		builder.OpenElement(19, "path");
		builder.AddAttribute(20, "d", "M8.5,20.935H5.564a2.5,2.5,0,0,1,0-5H8.5a2.5,2.5,0,1,1,0,5Zm-2.934-4a1.5,1.5,0,0,0,0,3H8.5a1.5,1.5,0,1,0,0-3Z");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(21, "g");
		builder.OpenElement(22, "path");
		builder.AddAttribute(23, "d", "M18.436,20.935H15.5a2.5,2.5,0,0,1-2.5-2.5v-5.87a2.5,2.5,0,0,1,2.5-2.5h2.934a2.5,2.5,0,0,1,2.5,2.5v5.87A2.5,2.5,0,0,1,18.436,20.935ZM15.5,11.065a1.5,1.5,0,0,0-1.5,1.5v5.87a1.5,1.5,0,0,0,1.5,1.5h2.934a1.5,1.5,0,0,0,1.5-1.5v-5.87a1.5,1.5,0,0,0-1.5-1.5Z");
		builder.CloseElement();
		builder.OpenElement(24, "path");
		builder.AddAttribute(25, "d", "M18.436,8.063H15.5a2.5,2.5,0,0,1,0-5h2.934a2.5,2.5,0,0,1,0,5Zm-2.934-4a1.5,1.5,0,0,0,0,3h2.934a1.5,1.5,0,0,0,0-3Z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
