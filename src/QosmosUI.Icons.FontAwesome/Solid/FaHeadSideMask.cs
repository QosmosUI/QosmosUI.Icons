// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FontAwesome.Solid;

public class FaHeadSideMask : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 576 512";

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
		builder.AddAttribute(14, "d", "M32 224.2c0-22.2 3.2-43.6 9.2-63.9L262.2 321c-4 9.5-6.2 20-6.2 31l0 160-128 0c-17.7 0-32-14.3-32-32l0-72.7c0-16.7-6.9-32.5-17.1-45.8C48.6 322.4 32 274.1 32 224.2zm248.3 70.4L53 129.3C88.7 53 166.2 0 256 0l24 0c95.2 0 181.2 69.3 197.3 160.2c2.3 13 6.8 25.7 15.1 36l42 52.6c5.4 6.7 8.6 14.8 9.4 23.2L336 272c-21.7 0-41.3 8.6-55.7 22.6zM336 304l198 0s0 0 0 0l10 0-19.7 64L368 368c-8.8 0-16 7.2-16 16s7.2 16 16 16l146.5 0-9.8 32L368 432c-8.8 0-16 7.2-16 16s7.2 16 16 16l126.8 0-.9 2.8c-8.3 26.9-33.1 45.2-61.2 45.2L288 512l0-160c0-14 6-26.7 15.6-35.4c0 0 0 0 0 0c8.5-7.8 19.9-12.6 32.4-12.6zm48-80a32 32 0 1 0 0-64 32 32 0 1 0 0 64z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
