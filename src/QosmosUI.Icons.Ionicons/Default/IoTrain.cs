// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Ionicons.Default;

public class IoTrain : ComponentBase
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
		builder.AddAttribute(15, "cy", "304");
		builder.AddAttribute(16, "rx", "32.05");
		builder.AddAttribute(17, "ry", "31.94");
		builder.AddAttribute(18, "transform", "translate(-139.98 270.06) rotate(-45)");
		builder.CloseElement();
		builder.OpenElement(19, "path");
		builder.AddAttribute(20, "d", "M352,32H337a10,10,0,0,1-7.87-3.78A31.94,31.94,0,0,0,304,16H208a32,32,0,0,0-26.11,13.52A6,6,0,0,1,177,32H160c-36.81,0-64,28.84-64,64V351c0,23.27,25.6,42.06,83,60.94a753,753,0,0,0,73.77,19.73,16,16,0,0,0,6.46,0A753,753,0,0,0,333,411.94c57.4-18.88,83-37.67,83-60.94V96A64,64,0,0,0,352,32ZM184,128H328a8,8,0,0,1,8,8v48a8,8,0,0,1-8,8H184a8,8,0,0,1-8-8V136A8,8,0,0,1,184,128Zm76.18,239.87a64,64,0,1,1,59.69-59.69A64.07,64.07,0,0,1,260.18,367.87Z");
		builder.CloseElement();
		builder.OpenElement(21, "path");
		builder.AddAttribute(22, "d", "M395.31,468.69,347.63,421c-6.09-6.1-16-6.66-22.38-.86a16,16,0,0,0-.56,23.16l4.68,4.69H182.63l4.36-4.37c6.1-6.09,6.66-16,.86-22.38a16,16,0,0,0-23.16-.56l-48,48a16,16,0,1,0,22.62,22.62L150.63,480H361.37l11.32,11.31a16,16,0,0,0,22.62-22.62Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
