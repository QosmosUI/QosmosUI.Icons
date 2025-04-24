// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.CircumIcons.Default;

public class CiAlignTop : ComponentBase
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
		builder.AddAttribute(14, "id", "Align_Top");
		builder.AddAttribute(15, "data-name", "Align Top");
		builder.OpenElement(16, "g");
		builder.OpenElement(17, "path");
		builder.AddAttribute(18, "d", "M3.548,4.078h16.9a.5.5,0,0,0,0-1H3.548a.5.5,0,0,0,0,1Z");
		builder.CloseElement();
		builder.OpenElement(19, "path");
		builder.AddAttribute(20, "d", "M9,20.922H6.565a2.5,2.5,0,0,1-2.5-2.5V7.582a2.5,2.5,0,0,1,2.5-2.5H9a2.5,2.5,0,0,1,2.5,2.5v10.84A2.5,2.5,0,0,1,9,20.922ZM6.565,6.082a1.5,1.5,0,0,0-1.5,1.5v10.84a1.5,1.5,0,0,0,1.5,1.5H9a1.5,1.5,0,0,0,1.5-1.5V7.582A1.5,1.5,0,0,0,9,6.082Z");
		builder.CloseElement();
		builder.OpenElement(21, "path");
		builder.AddAttribute(22, "d", "M17.438,15.951H15a2.5,2.5,0,0,1-2.5-2.5V7.582a2.5,2.5,0,0,1,2.5-2.5h2.435a2.5,2.5,0,0,1,2.5,2.5v5.869A2.5,2.5,0,0,1,17.438,15.951ZM15,6.082a1.5,1.5,0,0,0-1.5,1.5v5.869a1.5,1.5,0,0,0,1.5,1.5h2.435a1.5,1.5,0,0,0,1.5-1.5V7.582a1.5,1.5,0,0,0-1.5-1.5Z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
