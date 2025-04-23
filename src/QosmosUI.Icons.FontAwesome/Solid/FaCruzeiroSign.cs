// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FontAwesome.Solid;

public class FaCruzeiroSign : ComponentBase
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
		builder.AddAttribute(14, "d", "M96 256c0-88.4 71.6-160 160-160c41 0 78.3 15.4 106.7 40.7c13.2 11.8 33.4 10.7 45.2-2.5s10.7-33.4-2.5-45.2c-39.6-35.5-92-57-149.3-57C132.3 32 32 132.3 32 256s100.3 224 224 224c57.4 0 109.7-21.6 149.3-57c13.2-11.8 14.3-32 2.5-45.2s-32-14.3-45.2-2.5C334.3 400.6 297 416 256 416l0-96 0-8.7c0-12.8 10.4-23.3 23.3-23.3c4.6 0 9.1 1.4 12.9 3.9l10.1 6.7c14.7 9.8 34.6 5.8 44.4-8.9s5.8-34.6-8.9-44.4l-10.1-6.7c-14.3-9.6-31.2-14.7-48.4-14.7c-12.4 0-24.2 2.6-34.9 7.3c-5.5-4.5-12.6-7.3-20.3-7.3c-17.7 0-32 14.3-32 32l0 55.3 0 8.7 0 82.7C135.5 378 96 321.6 96 256z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
