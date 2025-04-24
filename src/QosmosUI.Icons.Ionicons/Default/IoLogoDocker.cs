// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Ionicons.Default;

public class IoLogoDocker : ComponentBase
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
		builder.AddAttribute(14, "d", "M507,211.16c-1.42-1.19-14.25-10.94-41.79-10.94a132.55,132.55,0,0,0-21.61,1.9c-5.22-36.4-35.38-54-36.57-55l-7.36-4.28-4.75,6.9a101.65,101.65,0,0,0-13.06,30.45c-5,20.7-1.9,40.2,8.55,56.85-12.59,7.14-33,8.8-37.28,9H15.94A15.93,15.93,0,0,0,0,262.07,241.25,241.25,0,0,0,14.75,348.9C26.39,379.35,43.72,402,66,415.74,91.22,431.2,132.3,440,178.6,440a344.23,344.23,0,0,0,62.45-5.71,257.44,257.44,0,0,0,81.69-29.73,223.55,223.55,0,0,0,55.57-45.67c26.83-30.21,42.74-64,54.38-94h4.75c29.21,0,47.26-11.66,57.23-21.65a63.31,63.31,0,0,0,15.2-22.36l2.14-6.18Z");
		builder.CloseElement();
		builder.OpenElement(15, "path");
		builder.AddAttribute(16, "d", "M47.29,236.37H92.4a4,4,0,0,0,4-4h0V191.89a4,4,0,0,0-4-4H47.29a4,4,0,0,0-4,4h0v40.44a4.16,4.16,0,0,0,4,4h0");
		builder.CloseElement();
		builder.OpenElement(17, "path");
		builder.AddAttribute(18, "d", "M109.5,236.37h45.12a4,4,0,0,0,4-4h0V191.89a4,4,0,0,0-4-4H109.5a4,4,0,0,0-4,4v40.44a4.16,4.16,0,0,0,4,4");
		builder.CloseElement();
		builder.OpenElement(19, "path");
		builder.AddAttribute(20, "d", "M172.9,236.37H218a4,4,0,0,0,4-4h0V191.89a4,4,0,0,0-4-4H172.9a4,4,0,0,0-4,4h0v40.44a3.87,3.87,0,0,0,4,4h0");
		builder.CloseElement();
		builder.OpenElement(21, "path");
		builder.AddAttribute(22, "d", "M235.36,236.37h45.12a4,4,0,0,0,4-4V191.89a4,4,0,0,0-4-4H235.36a4,4,0,0,0-4,4h0v40.44a4,4,0,0,0,4,4h0");
		builder.CloseElement();
		builder.OpenElement(23, "path");
		builder.AddAttribute(24, "d", "M109.5,178.57h45.12a4.16,4.16,0,0,0,4-4V134.09a4,4,0,0,0-4-4H109.5a4,4,0,0,0-4,4v40.44a4.34,4.34,0,0,0,4,4");
		builder.CloseElement();
		builder.OpenElement(25, "path");
		builder.AddAttribute(26, "d", "M172.9,178.57H218a4.16,4.16,0,0,0,4-4V134.09a4,4,0,0,0-4-4H172.9a4,4,0,0,0-4,4h0v40.44a4,4,0,0,0,4,4");
		builder.CloseElement();
		builder.OpenElement(27, "path");
		builder.AddAttribute(28, "d", "M235.36,178.57h45.12a4.16,4.16,0,0,0,4-4V134.09a4.16,4.16,0,0,0-4-4H235.36a4,4,0,0,0-4,4h0v40.44a4.16,4.16,0,0,0,4,4");
		builder.CloseElement();
		builder.OpenElement(29, "path");
		builder.AddAttribute(30, "d", "M235.36,120.53h45.12a4,4,0,0,0,4-4V76a4.16,4.16,0,0,0-4-4H235.36a4,4,0,0,0-4,4h0v40.44a4.17,4.17,0,0,0,4,4");
		builder.CloseElement();
		builder.OpenElement(31, "path");
		builder.AddAttribute(32, "d", "M298.28,236.37H343.4a4,4,0,0,0,4-4V191.89a4,4,0,0,0-4-4H298.28a4,4,0,0,0-4,4h0v40.44a4.16,4.16,0,0,0,4,4");
		builder.CloseElement();
		builder.CloseElement();
    }
}
