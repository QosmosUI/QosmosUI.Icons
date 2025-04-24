// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Ionicons.Default;

public class IoRadioSharp : ComponentBase
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
		builder.OpenElement(13, "ellipse");
		builder.AddAttribute(14, "cx", "256");
		builder.AddAttribute(15, "cy", "256");
		builder.AddAttribute(16, "rx", "36");
		builder.AddAttribute(17, "ry", "35.99");
		builder.CloseElement();
		builder.OpenElement(18, "path");
		builder.AddAttribute(19, "d", "M188.4,350.8l-14.62-16.44a117.91,117.91,0,0,1,0-156.71l14.62-16.43,32.87,29.24-14.62,16.43a73.93,73.93,0,0,0,0,98.25l14.62,16.44Z");
		builder.CloseElement();
		builder.OpenElement(20, "path");
		builder.AddAttribute(21, "d", "M323.6,350.8l-32.89-29.22,14.62-16.44a73.93,73.93,0,0,0,0-98.25l-14.62-16.43,32.87-29.24,14.62,16.43a117.91,117.91,0,0,1,0,156.71Z");
		builder.CloseElement();
		builder.OpenElement(22, "path");
		builder.AddAttribute(23, "d", "M138.24,401.76l-15-16.06a189.85,189.85,0,0,1,0-259.4l15-16.07,32.14,30.05-15,16.06a145.88,145.88,0,0,0,0,199.32l15,16.06Z");
		builder.CloseElement();
		builder.OpenElement(24, "path");
		builder.AddAttribute(25, "d", "M373.76,401.76l-32.14-30,15-16.06a145.88,145.88,0,0,0,0-199.32l-15-16.06,32.14-30,15,16.07a189.85,189.85,0,0,1,0,259.4Z");
		builder.CloseElement();
		builder.OpenElement(26, "path");
		builder.AddAttribute(27, "d", "M430.73,447l-32.79-29.33,14.66-16.39a218.2,218.2,0,0,0,0-290.56L397.93,94.34,430.72,65l14.67,16.39a262.18,262.18,0,0,1,0,349.22Z");
		builder.CloseElement();
		builder.OpenElement(28, "path");
		builder.AddAttribute(29, "d", "M81.27,447,66.6,430.61a262.18,262.18,0,0,1,0-349.22L81.28,65l32.79,29.34L99.39,110.72a218.2,218.2,0,0,0,0,290.56l14.66,16.39Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
