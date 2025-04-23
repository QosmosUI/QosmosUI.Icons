// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundTransferWithinAStation : ComponentBase
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
		builder.AddAttribute(14, "d", "M0 0h24v24H0V0z");
		builder.AddAttribute(15, "fill", "none");
		builder.CloseElement();
		builder.OpenElement(16, "path");
		builder.AddAttribute(17, "d", "M22 15.5h-5.52v-.77c0-.36-.44-.54-.69-.29l-1.51 1.52c-.16.16-.16.41 0 .57l1.51 1.52c.26.26.69.08.69-.29V17H22v-1.5zm-.28 4.71l-1.51-1.52c-.26-.26-.69-.08-.69.29v.77H14v1.5h5.52v.77c0 .36.44.54.69.29l1.51-1.52c.16-.16.16-.42 0-.58zM9.5 5.5c1.1 0 2-.9 2-2s-.9-2-2-2-2 .9-2 2 .9 2 2 2zM5.75 8.9L3.23 21.81c-.12.62.35 1.19.98 1.19h.09c.47 0 .88-.33.98-.79L6.85 15 9 17v5c0 .55.45 1 1 1s1-.45 1-1v-5.72c0-.53-.21-1.04-.59-1.41L8.95 13.4l.6-3c1.07 1.32 2.58 2.23 4.31 2.51.6.1 1.14-.39 1.14-1 0-.49-.36-.9-.84-.98-1.49-.25-2.75-1.15-3.51-2.38l-.95-1.6C9.35 6.35 8.7 6 8 6c-.25 0-.5.05-.75.15L3.24 7.79C2.49 8.1 2 8.83 2 9.64V12c0 .55.45 1 1 1s1-.45 1-1V9.65l1.75-.75");
		builder.CloseElement();
		builder.CloseElement();
    }
}
