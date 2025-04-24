// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GrommetIcons.Default;

public class GrGremlin : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "24";

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
		builder.OpenElement(13, "path");
		builder.AddAttribute(14, "fill", "none");
		builder.AddAttribute(15, "stroke-width", "2");
		builder.AddAttribute(16, "d", "M7,14 C7.55228475,14 8,13.5522847 8,13 C8,12.4477153 7.55228475,12 7,12 C6.44771525,12 6,12.4477153 6,13 C6,13.5522847 6.44771525,14 7,14 Z M17,14 C17.5522847,14 18,13.5522847 18,13 C18,12.4477153 17.5522847,12 17,12 C16.4477153,12 16,12.4477153 16,13 C16,13.5522847 16.4477153,14 17,14 Z M12,16 C12.5,16 13,15.6790227 13,15 C13,14.8871314 11,14.9246156 11,15 C11,15.6790227 11.5,16 12,16 Z M3,24 C3,24 3.00341148,16 3,12 C3.00341148,8 2.55309359,4 12,4 C21.4469064,4 20.9965885,8 21,12 C20.9965885,16 21,24 21,24 M20.0682179,7 C23.3272228,7 23.6478055,3.42041241 22.1136966,1.88630344 C20.5795876,0.352194472 17,0.672777193 17,3.93178206 M7,19 C7,18.7966267 9.50000016,20.1517845 12,20 C14.4999998,20.1517846 17,18.5013715 17,19 C17,19.8021982 15.5,21 12,21 C8.5,21 7,19.5069424 7,19 Z M3.94464295,7 C0.604407067,7 0.38005973,3.42041241 1.90773825,1.88630344 C3.43541678,0.352194472 7,0.672777193 7,3.93178206");
		builder.CloseElement();
		builder.CloseElement();
    }
}
