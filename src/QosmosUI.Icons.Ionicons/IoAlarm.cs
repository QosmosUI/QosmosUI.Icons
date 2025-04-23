// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Ionicons;

public class IoAlarm : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 512 512";

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
		builder.AddAttribute(14, "d", "M153.59,110.46A21.41,21.41,0,0,0,152.48,79h0A62.67,62.67,0,0,0,112,64l-3.27.09-.48,0C74.4,66.15,48,95.55,48.07,131c0,19,8,29.06,14.32,37.11a20.61,20.61,0,0,0,14.7,7.8c.26,0,.7.05,2,.05a19.06,19.06,0,0,0,13.75-5.89Z");
		builder.CloseElement();
		builder.OpenElement(15, "path");
		builder.AddAttribute(16, "d", "M403.79,64.11l-3.27-.1H400a62.67,62.67,0,0,0-40.52,15,21.41,21.41,0,0,0-1.11,31.44l60.77,59.65A19.06,19.06,0,0,0,432.93,176c1.28,0,1.72,0,2-.05a20.61,20.61,0,0,0,14.69-7.8c6.36-8.05,14.28-18.08,14.32-37.11C464,95.55,437.6,66.15,403.79,64.11Z");
		builder.CloseElement();
		builder.OpenElement(17, "path");
		builder.AddAttribute(18, "d", "M256.07,96c-97,0-176,78.95-176,176a175.23,175.23,0,0,0,40.81,112.56L84.76,420.69a16,16,0,1,0,22.63,22.62l36.12-36.12a175.63,175.63,0,0,0,225.12,0l36.13,36.12a16,16,0,1,0,22.63-22.62l-36.13-36.13A175.17,175.17,0,0,0,432.07,272C432.07,175,353.12,96,256.07,96Zm16,176a16,16,0,0,1-16,16h-80a16,16,0,0,1,0-32h64V160a16,16,0,0,1,32,0Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
