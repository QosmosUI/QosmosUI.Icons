// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Ionicons.Default;

public class IoBugSharp : ComponentBase
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
		builder.AddAttribute(14, "d", "M480,304.13v-32H400V215.2c29.42-27.95,32-64.76,32-103.2V96H400v16c0,28-1.86,48.15-9.9,63.84C368,128,324.32,112,256,112c-39.8,0-75.19,7.06-100.43,24.32-14.9,10.19-25.2,24.91-32.7,39.72C114,160.57,112,140.82,112,112V96H80v16c0,37.44,2.59,73.36,32,101.2v58.93H32v32l80-.13c0,19,3.7,53.09,10.39,69.69C96.6,396.76,80,422.31,80,464v16h32V464c0-27.66,9.1-44.71,26.17-61.32C160,448,177,464,240,464V176h32V464c65,0,80-16,101.83-61.32C390.9,419.29,400,436.35,400,464v16h32V464c0-41.68-16.6-67.23-42.39-90.31C396.3,357.09,400,323,400,304Z");
		builder.CloseElement();
		builder.OpenElement(15, "path");
		builder.AddAttribute(16, "d", "M256,32c-48.06,0-96,0-96,84,26.12-14,59.35-20,96-20,24.09,0,46.09,2.65,65.39,8,10.75,3,24.66,8.71,30.61,12C352,32,304.06,32,256,32Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
