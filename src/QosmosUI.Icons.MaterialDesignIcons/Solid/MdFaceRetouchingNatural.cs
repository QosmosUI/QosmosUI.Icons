// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Solid;

public class MdFaceRetouchingNatural : ComponentBase
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
		builder.OpenElement(13, "path");
		builder.AddAttribute(14, "d", "M0 0h24v24H0z");
		builder.AddAttribute(15, "fill", "none");
		builder.CloseElement();
		builder.OpenElement(16, "circle");
		builder.AddAttribute(17, "cx", "9");
		builder.AddAttribute(18, "cy", "13");
		builder.AddAttribute(19, "r", "1.25");
		builder.CloseElement();
		builder.OpenElement(20, "path");
		builder.AddAttribute(21, "d", "M20.77 8.58l-.92 2.01c.09.46.15.93.15 1.41 0 4.41-3.59 8-8 8s-8-3.59-8-8c0-.05.01-.1 0-.14 2.6-.98 4.69-2.99 5.74-5.55C11.58 8.56 14.37 10 17.5 10c.45 0 .89-.04 1.33-.1l-.6-1.32-.88-1.93-1.93-.88-2.79-1.27 2.79-1.27.71-.32C14.87 2.33 13.47 2 12 2 6.48 2 2 6.48 2 12s4.48 10 10 10 10-4.48 10-10c0-1.47-.33-2.87-.9-4.13l-.33.71z");
		builder.CloseElement();
		builder.OpenElement(22, "circle");
		builder.AddAttribute(23, "cx", "15");
		builder.AddAttribute(24, "cy", "13");
		builder.AddAttribute(25, "r", "1.25");
		builder.CloseElement();
		builder.OpenElement(26, "path");
		builder.AddAttribute(27, "d", "M20.6 5.6L19.5 8l-1.1-2.4L16 4.5l2.4-1.1L19.5 1l1.1 2.4L23 4.5z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
