// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Ionicons.Default;

public class IoHelpBuoy : ComponentBase
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
		builder.AddAttribute(14, "d", "M414.39,97.61A224,224,0,1,0,97.61,414.39,224,224,0,1,0,414.39,97.61ZM192.13,260.18a64,64,0,1,1,59.69,59.69A64.07,64.07,0,0,1,192.13,260.18Zm240-66.64-96.37,5.84a4.06,4.06,0,0,1-3.44-1.59,96,96,0,0,0-18.07-18.07,4.06,4.06,0,0,1-1.59-3.44l5.84-96.37a4,4,0,0,1,5.42-3.51A193,193,0,0,1,435.6,188.12,4,4,0,0,1,432.09,193.54ZM193.54,79.91l5.84,96.37a4.06,4.06,0,0,1-1.59,3.44,96,96,0,0,0-18.07,18.07,4.06,4.06,0,0,1-3.44,1.59l-96.37-5.84a4,4,0,0,1-3.51-5.42A193,193,0,0,1,188.12,76.4,4,4,0,0,1,193.54,79.91ZM79.91,318.46l96.37-5.84a4.06,4.06,0,0,1,3.44,1.59,96,96,0,0,0,18.07,18.07,4.06,4.06,0,0,1,1.59,3.44l-5.84,96.37a4,4,0,0,1-5.42,3.51A193,193,0,0,1,76.4,323.88,4,4,0,0,1,79.91,318.46ZM318.46,432.09l-5.84-96.37a4.06,4.06,0,0,1,1.59-3.44,96,96,0,0,0,18.07-18.07,4.06,4.06,0,0,1,3.44-1.59l96.37,5.84a4,4,0,0,1,3.51,5.42A193,193,0,0,1,323.88,435.6,4,4,0,0,1,318.46,432.09Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
