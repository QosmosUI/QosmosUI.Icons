// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.CircumIcons;

public class CiPillsBottle1 : ComponentBase
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
		builder.AddAttribute(14, "id", "meds_Bottle_1");
		builder.AddAttribute(15, "data-name", "Prescription Bottle 1");
		builder.OpenElement(16, "path");
		builder.AddAttribute(17, "d", "M17.435,2.06H6.565a2.5,2.5,0,0,0-2.5,2.5v2a1.492,1.492,0,0,0,1.22,1.47V19.44a2.5,2.5,0,0,0,2.5,2.5h8.43a2.5,2.5,0,0,0,2.5-2.5V8.03a1.492,1.492,0,0,0,1.22-1.47v-2A2.5,2.5,0,0,0,17.435,2.06Zm.28,17.38a1.5,1.5,0,0,1-1.5,1.5H7.785a1.5,1.5,0,0,1-1.5-1.5v-.88h3.52a.491.491,0,0,0,.48-.5.485.485,0,0,0-.48-.5H6.285V15h2.57a.5.5,0,0,0,0-1H6.285V11.45h3.52a.491.491,0,0,0,.48-.5.485.485,0,0,0-.48-.5H6.285V8.06h11.43Zm1.22-12.88a.5.5,0,0,1-.5.5H5.565a.5.5,0,0,1-.5-.5v-2a1.5,1.5,0,0,1,1.5-1.5h10.87a1.5,1.5,0,0,1,1.5,1.5Z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
