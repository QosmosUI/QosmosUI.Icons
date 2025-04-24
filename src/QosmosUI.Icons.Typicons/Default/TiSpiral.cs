// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Typicons.Default;

public class TiSpiral : ComponentBase
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
		builder.AddAttribute(14, "d", "M12 11.8c1-.4.7-1.8 0-2.4-1.1-.9-2.7-.4-3.4.8-1.5 2.4.9 5 3.4 4.9 2.7-.2 4.3-2.9 3.7-5.4-.7-3-3.9-4.5-6.7-3.6-2.6.8-4.2 3.5-4 6.2.3 3 2.6 5.4 5.5 5.9 2.8.5 5.7-.8 7.2-3.2.7-1.1 1.2-2.4 1.2-3.8 0-.5.5-1 1.1-.9.8 0 1 .8.9 1.4-.4 4.7-4.5 8.6-9.3 8.6-5.9 0-10.5-6.2-8-11.8 2.5-5.4 10.3-6.5 13.3-1.2 1.5 2.5 1.2 5.8-.9 7.9-2 2-5.3 2.4-7.7.7-2.2-1.6-2.9-4.9-1.1-7.2 1.7-2.3 5.5-2.4 7 .2 1.1 1.9 0 5.2-2.5 4.9-1.6 0-3-1.7-2.1-3.2.6-.9 1.9-.6 2.3.1.2.8.1 1.1.1 1.1z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
