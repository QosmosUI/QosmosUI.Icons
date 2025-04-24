// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.CircumIcons.Default;

public class CiRollingSuitcase : ComponentBase
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
		builder.AddAttribute(14, "id", "Rolling_Suitcase");
		builder.AddAttribute(15, "data-name", "Rolling Suitcase");
		builder.OpenElement(16, "path");
		builder.AddAttribute(17, "d", "M16.25,7.49H15V3.56a1.5,1.5,0,0,0-1.5-1.5h-3A1.511,1.511,0,0,0,9,3.56V7.49H7.75a2.5,2.5,0,0,0-2.5,2.5v8.44a2.5,2.5,0,0,0,2.5,2.5h.5v.01a1,1,0,0,0,2,0v-.01h3.5v.01a1,1,0,0,0,2,0v-.01h.5a2.5,2.5,0,0,0,2.5-2.5V9.99A2.5,2.5,0,0,0,16.25,7.49ZM10,3.56a.508.508,0,0,1,.5-.5h3a.5.5,0,0,1,.5.5V7.5H10Zm7.75,14.87a1.5,1.5,0,0,1-1.5,1.5H7.75a1.5,1.5,0,0,1-1.5-1.5V9.99a1.511,1.511,0,0,1,1.5-1.5h8.5a1.5,1.5,0,0,1,1.5,1.5Z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
