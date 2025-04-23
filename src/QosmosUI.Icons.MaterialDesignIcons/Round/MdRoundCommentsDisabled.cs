// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundCommentsDisabled : ComponentBase
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
		builder.OpenElement(13, "rect");
		builder.AddAttribute(14, "fill", "none");
		builder.AddAttribute(15, "height", "24");
		builder.AddAttribute(16, "width", "24");
		builder.CloseElement();
		builder.OpenElement(17, "path");
		builder.AddAttribute(18, "d", "M1.39,2.81C1,3.2,1,3.83,1.39,4.22L2,4.83V16c0,1.1,0.9,2,2,2h11.17l4.61,4.61c0.39,0.39,1.02,0.39,1.41,0 c0.39-0.39,0.39-1.02,0-1.41L2.81,2.81C2.42,2.42,1.78,2.42,1.39,2.81z M6.38,9.21L8.17,11H7c-0.55,0-1-0.45-1-1 C6,9.68,6.15,9.4,6.38,9.21z M7,14c-0.55,0-1-0.45-1-1c0-0.55,0.45-1,1-1h2.17l2,2H7z M14.83,12l-1-1H17c0.55,0,1-0.45,1-1v0 c0-0.55-0.45-1-1-1h-5.17l-1-1H17c0.55,0,1-0.45,1-1v0c0-0.55-0.45-1-1-1H8.83l-4-4H20c1.1,0,2,0.9,2,2v15.17L16.83,14H17 c0.55,0,1-0.45,1-1v0c0-0.55-0.45-1-1-1H14.83z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
