// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.CircumIcons.Default;

public class CiBoxes : ComponentBase
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
		builder.AddAttribute(14, "id", "Boxes");
		builder.OpenElement(15, "path");
		builder.AddAttribute(16, "d", "M19.435,11.5h-2.72V4.56a1.5,1.5,0,0,0-1.5-1.5H8.785a1.5,1.5,0,0,0-1.5,1.5V11.5H4.565a1.5,1.5,0,0,0-1.5,1.5v6.44a1.5,1.5,0,0,0,1.5,1.5H11a1.468,1.468,0,0,0,1-.39,1.487,1.487,0,0,0,1,.39h6.44a1.5,1.5,0,0,0,1.5-1.5V13A1.5,1.5,0,0,0,19.435,11.5ZM11.5,19.44a.5.5,0,0,1-.5.5H4.565a.5.5,0,0,1-.5-.5V13a.5.5,0,0,1,.5-.5h1.97v2a.5.5,0,0,0,.5.5h1.5a.508.508,0,0,0,.5-.5v-2H11.5ZM8.285,11.5V4.56a.5.5,0,0,1,.5-.5h1.96v2a.5.5,0,0,0,.5.5h1.5a.5.5,0,0,0,.5-.5v-2h1.97a.5.5,0,0,1,.5.5V11.5Zm11.65,7.94a.508.508,0,0,1-.5.5H13a.508.508,0,0,1-.5-.5V12.5h2.47v2a.5.5,0,0,0,.5.5h1.5a.5.5,0,0,0,.5-.5v-2h1.97a.5.5,0,0,1,.5.5Z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
