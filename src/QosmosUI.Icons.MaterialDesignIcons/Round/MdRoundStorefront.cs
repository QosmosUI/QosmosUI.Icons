// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundStorefront : ComponentBase
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
		builder.OpenElement(14, "g");
		builder.OpenElement(15, "rect");
		builder.AddAttribute(16, "fill", "none");
		builder.AddAttribute(17, "height", "24");
		builder.AddAttribute(18, "width", "24");
		builder.CloseElement();
		builder.OpenElement(19, "rect");
		builder.AddAttribute(20, "fill", "none");
		builder.AddAttribute(21, "height", "24");
		builder.AddAttribute(22, "width", "24");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(23, "g");
		builder.OpenElement(24, "path");
		builder.AddAttribute(25, "d", "M21.9,7.89l-1.05-3.37c-0.22-0.9-1-1.52-1.91-1.52H5.05c-0.9,0-1.69,0.63-1.9,1.52L2.1,7.89C1.64,9.86,2.95,11,3,11.06V19 c0,1.1,0.9,2,2,2h14c1.1,0,2-0.9,2-2v-7.94C22.12,9.94,22.09,8.65,21.9,7.89z M13,5h1.96l0.54,3.52C15.59,9.23,15.11,10,14.22,10 C13.55,10,13,9.41,13,8.69V5z M6.44,8.86C6.36,9.51,5.84,10,5.23,10C4.3,10,3.88,9.03,4.04,8.36L5.05,5h1.97L6.44,8.86z M11,8.69 C11,9.41,10.45,10,9.71,10c-0.75,0-1.3-0.7-1.22-1.48L9.04,5H11V8.69z M18.77,10c-0.61,0-1.14-0.49-1.21-1.14L16.98,5l1.93-0.01 l1.05,3.37C20.12,9.03,19.71,10,18.77,10z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
