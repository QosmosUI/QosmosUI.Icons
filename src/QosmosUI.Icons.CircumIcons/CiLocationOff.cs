// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.CircumIcons;

public class CiLocationOff : ComponentBase
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
		builder.AddAttribute(14, "id", "Location_Off");
		builder.AddAttribute(15, "data-name", "Location Off");
		builder.OpenElement(16, "g");
		builder.OpenElement(17, "path");
		builder.AddAttribute(18, "d", "M18.2,14.462a.5.5,0,0,1-.417-.775A6.791,6.791,0,0,0,18.831,9.06a6.909,6.909,0,0,0-6.022-5.946A6.834,6.834,0,0,0,8.252,4.175a.5.5,0,1,1-.545-.838,7.882,7.882,0,0,1,10.909,10.9A.5.5,0,0,1,18.2,14.462Z");
		builder.CloseElement();
		builder.OpenElement(19, "path");
		builder.AddAttribute(20, "d", "M4,3.3a.5.5,0,0,0-.7.7l1.92,1.92a7.784,7.784,0,0,0-1.11,4.03A7.879,7.879,0,0,0,5.55,14.5l5.06,6.74a1.724,1.724,0,0,0,1.39.69,1.705,1.705,0,0,0,1.38-.69l3.06-4.09c.5.49.99.99,1.48,1.48.7.69,1.39,1.38,2.08,2.07.45.46,1.16-.25.7-.71Zm8.58,17.34a.734.734,0,0,1-.58.29.754.754,0,0,1-.59-.29l-5.05-6.73a6.9,6.9,0,0,1-.41-7.26q1.5,1.515,3.01,3.01,3.39,3.39,6.77,6.78Z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
