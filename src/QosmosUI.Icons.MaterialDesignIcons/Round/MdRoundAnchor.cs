// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundAnchor : ComponentBase
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
		builder.OpenElement(13, "g");
		builder.OpenElement(14, "rect");
		builder.AddAttribute(15, "fill", "none");
		builder.AddAttribute(16, "height", "24");
		builder.AddAttribute(17, "width", "24");
		builder.CloseElement();
		builder.OpenElement(18, "path");
		builder.AddAttribute(19, "d", "M13,9V7.82C14.16,7.4,15,6.3,15,5c0-1.65-1.35-3-3-3S9,3.35,9,5c0,1.3,0.84,2.4,2,2.82V9H9c-0.55,0-1,0.45-1,1v0 c0,0.55,0.45,1,1,1h2v8.92c-2.22-0.33-4.59-1.68-5.55-3.37l1.14-1.14c0.22-0.22,0.19-0.57-0.05-0.75L3.8,12.6 C3.47,12.35,3,12.59,3,13v2c0,3.88,4.92,7,9,7s9-3.12,9-7v-2c0-0.41-0.47-0.65-0.8-0.4l-2.74,2.05c-0.24,0.18-0.27,0.54-0.05,0.75 l1.14,1.14c-0.96,1.69-3.33,3.04-5.55,3.37V11h2c0.55,0,1-0.45,1-1v0c0-0.55-0.45-1-1-1H13z M12,4c0.55,0,1,0.45,1,1s-0.45,1-1,1 s-1-0.45-1-1S11.45,4,12,4z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
