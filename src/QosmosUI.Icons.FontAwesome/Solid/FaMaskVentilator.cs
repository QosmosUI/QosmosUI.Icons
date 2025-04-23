// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FontAwesome.Solid;

public class FaMaskVentilator : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 640 512";

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
		builder.AddAttribute(14, "d", "M159.1 176C139.4 219.2 128 264.7 128 300.8c0 15.9 2.2 31.4 6.3 46l-31.8-7.9C70.5 330.9 48 302.1 48 269l0-85c0-4.4 3.6-8 8-8l103.1 0zm26-48L56 128c-30.9 0-56 25.1-56 56l0 85c0 55.1 37.5 103.1 90.9 116.4l71.3 17.8c22.7 30.5 55.4 54.1 93.8 66.6l0-76.6c-19.7-16.4-32-40.3-32-66.9c0-49.5 43-134.4 96-134.4c52.5 0 96 84.9 96 134.4c0 26.7-12.4 50.4-32 66.8l0 76.6c38-12.6 70.6-36 93.5-66.4l71.6-17.9C602.5 372.1 640 324.1 640 269l0-85c0-30.9-25.1-56-56-56l-129.5 0C419.7 73.8 372.1 32 320 32c-52.6 0-100.2 41.8-134.9 96zm295.6 48L584 176c4.4 0 8 3.6 8 8l0 85c0 33-22.5 61.8-54.5 69.9l-31.8 8c4.2-14.7 6.4-30.1 6.4-46.1c0-36.1-11.6-81.6-31.3-124.8zM288 320l0 192 64 0 0-192c0-17.7-14.3-32-32-32s-32 14.3-32 32z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
