// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.CircumIcons.Default;

public class CiAlignCenterH : ComponentBase
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
		builder.AddAttribute(14, "id", "Align_Center-H");
		builder.AddAttribute(15, "data-name", "Align Center-H");
		builder.OpenElement(16, "path");
		builder.AddAttribute(17, "d", "M17.42,4.062H12.5v-.51a.5.5,0,0,0-1,0v.51H6.58a2.507,2.507,0,0,0-2.5,2.5V9a2.5,2.5,0,0,0,2.5,2.5H11.5v1H9.06A2.507,2.507,0,0,0,6.56,15v2.44a2.507,2.507,0,0,0,2.5,2.5H11.5v.51a.5.5,0,0,0,1,0v-.51h2.43a2.5,2.5,0,0,0,2.5-2.5V15a2.5,2.5,0,0,0-2.5-2.5H12.5v-1h4.92A2.5,2.5,0,0,0,19.92,9V6.562A2.507,2.507,0,0,0,17.42,4.062ZM11.5,18.942H9.06a1.511,1.511,0,0,1-1.5-1.5V15a1.5,1.5,0,0,1,1.5-1.5H11.5Zm0-8.44H6.58A1.5,1.5,0,0,1,5.08,9V6.562a1.5,1.5,0,0,1,1.5-1.5H11.5Zm3.43,3a1.5,1.5,0,0,1,1.5,1.5v2.44a1.5,1.5,0,0,1-1.5,1.5H12.5V13.5ZM18.92,9a1.5,1.5,0,0,1-1.5,1.5H12.5V5.062h4.92a1.5,1.5,0,0,1,1.5,1.5Z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
