// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Ionicons.Default;

public class IoRocketSharp : ComponentBase
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
		builder.AddAttribute(14, "d", "M477.64,38.26a4.75,4.75,0,0,0-3.55-3.66c-58.57-14.32-193.9,36.71-267.22,110a317,317,0,0,0-35.63,42.1c-22.61-2-45.22-.33-64.49,8.07C52.38,218.7,36.55,281.14,32.14,308a9.64,9.64,0,0,0,10.55,11.2L130,309.57a194.1,194.1,0,0,0,1.19,19.7,19.53,19.53,0,0,0,5.7,12L170.7,375a19.59,19.59,0,0,0,12,5.7,193.53,193.53,0,0,0,19.59,1.19l-9.58,87.2a9.65,9.65,0,0,0,11.2,10.55c26.81-4.3,89.36-20.13,113.15-74.5,8.4-19.27,10.12-41.77,8.18-64.27a317.66,317.66,0,0,0,42.21-35.64C441,232.05,491.74,99.74,477.64,38.26ZM294.07,217.93a48,48,0,1,1,67.86,0A47.95,47.95,0,0,1,294.07,217.93Z");
		builder.CloseElement();
		builder.OpenElement(15, "path");
		builder.AddAttribute(16, "d", "M168.4,399.43c-5.48,5.49-14.27,7.63-24.85,9.46-23.77,4.05-44.76-16.49-40.49-40.52,1.63-9.11,6.45-21.88,9.45-24.88a4.37,4.37,0,0,0-3.65-7.45,60,60,0,0,0-35.13,17.12C50.22,376.69,48,464,48,464s87.36-2.22,110.87-25.75A59.69,59.69,0,0,0,176,403.09C176.37,398.91,171.28,396.42,168.4,399.43Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
