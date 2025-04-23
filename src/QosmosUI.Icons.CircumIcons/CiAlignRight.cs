// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.CircumIcons;

public class CiAlignRight : ComponentBase
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
		builder.AddAttribute(14, "id", "Align_Right");
		builder.AddAttribute(15, "data-name", "Align Right");
		builder.OpenElement(16, "g");
		builder.OpenElement(17, "path");
		builder.AddAttribute(18, "d", "M19.922,3.548v16.9a.5.5,0,0,0,1,0V3.548a.5.5,0,0,0-1,0Z");
		builder.CloseElement();
		builder.OpenElement(19, "path");
		builder.AddAttribute(20, "d", "M16.419,11.5H5.578A2.5,2.5,0,0,1,3.078,9V6.565a2.5,2.5,0,0,1,2.5-2.5H16.419a2.5,2.5,0,0,1,2.5,2.5V9A2.5,2.5,0,0,1,16.419,11.5ZM5.578,5.065a1.5,1.5,0,0,0-1.5,1.5V9a1.5,1.5,0,0,0,1.5,1.5H16.419a1.5,1.5,0,0,0,1.5-1.5V6.565a1.5,1.5,0,0,0-1.5-1.5Z");
		builder.CloseElement();
		builder.OpenElement(21, "path");
		builder.AddAttribute(22, "d", "M16.419,19.938H10.55a2.5,2.5,0,0,1-2.5-2.5V15a2.5,2.5,0,0,1,2.5-2.5h5.869a2.5,2.5,0,0,1,2.5,2.5v2.436A2.5,2.5,0,0,1,16.419,19.938ZM10.55,13.5A1.5,1.5,0,0,0,9.05,15v2.436a1.5,1.5,0,0,0,1.5,1.5h5.869a1.5,1.5,0,0,0,1.5-1.5V15a1.5,1.5,0,0,0-1.5-1.5Z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
