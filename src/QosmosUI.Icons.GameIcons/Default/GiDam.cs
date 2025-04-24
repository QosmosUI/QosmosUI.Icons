// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiDam : ComponentBase
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
		builder.AddAttribute(14, "d", "M247 78.56l-46 23.04V487h109l-30.8-292.4-32.2-64.5V78.56zM137.6 163c-8-.3-16.7 5.6-27 13.7-10.4 8.2-22.34 18.4-38.64 18.3-15.91-.1-32.07-9.1-45.61-17.4-3.71-2.2-6.26-4.1-9.35-6.2V487h166V190c-2.8-2.5-7.9-6.9-15.4-12.4-10.4-7.5-23.8-14.3-30-14.6zm240.2 246c-2.7-.1-6.9 2.3-12.6 6.3-5.7 4.1-13 9.9-23.4 9.7-8-.2-14.8-3.6-20.9-7l7.2 69H495v-68.2c-4.6 3.2-9.9 5.9-16.6 6.2-10.1.4-16.9-5.6-22-9.7-5.1-4-8.7-6.2-10.6-6.3-2.7-.1-6.9 2.3-12.6 6.3-5.7 4.1-13 9.9-23.4 9.7-9.8-.2-16.3-6-21.3-9.9-5.1-3.9-8.6-6-10.7-6.1z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
