// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FontAwesome.Solid;

public class FaPersonSkating : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 448 512";

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
		builder.AddAttribute(14, "d", "M352 48a48 48 0 1 1 96 0 48 48 0 1 1 -96 0zM128 128c0-17.7 14.3-32 32-32l159.4 0c43.6 0 64.6 53.4 32.8 83.1l-74.4 69.4 60.2 60.2c9 9 14.1 21.2 14.1 33.9l0 73.4c0 17.7-14.3 32-32 32s-32-14.3-32-32l0-66.7-77.9-77.8c-26.6-26.6-24.6-70.3 4.3-94.4l20.4-17L160 160c-17.7 0-32-14.3-32-32zM81.4 353.4l86.9-86.9c4.6 10 11 19.3 19.3 27.5l21.8 21.8-82.7 82.7c-12.5 12.5-32.8 12.5-45.3 0s-12.5-32.8 0-45.3zm322.5 95.1c8.6 2.1 13.8 10.8 11.6 19.4l-.4 1.7c-6.2 24.9-28.6 42.4-54.3 42.4L272 512c-8.8 0-16-7.2-16-16s7.2-16 16-16l88.8 0c11 0 20.6-7.5 23.3-18.2l.4-1.7c2.1-8.6 10.8-13.8 19.4-11.6zM135.2 478.3l-6.2 3.1c-21.6 10.8-47.6 6.6-64.6-10.5L4.7 411.3c-6.2-6.2-6.2-16.4 0-22.6s16.4-6.2 22.6 0l59.6 59.6c7.3 7.3 18.5 9.1 27.7 4.5l6.2-3.1c7.9-4 17.5-.7 21.5 7.2s.7 17.5-7.2 21.5z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
