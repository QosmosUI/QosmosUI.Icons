// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundPlaylistRemove : ComponentBase
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
		builder.OpenElement(18, "rect");
		builder.AddAttribute(19, "fill", "none");
		builder.AddAttribute(20, "height", "24");
		builder.AddAttribute(21, "width", "24");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(22, "g");
		builder.OpenElement(23, "path");
		builder.AddAttribute(24, "d", "M13.71,21.3c0.39,0.39,1.02,0.39,1.41,0L17,19.41l1.89,1.89c0.39,0.39,1.02,0.39,1.41,0s0.39-1.02,0-1.41L18.41,18 l1.89-1.89c0.39-0.39,0.39-1.02,0-1.41s-1.02-0.39-1.41,0L17,16.59l-1.89-1.89c-0.39-0.39-1.02-0.39-1.41,0s-0.39,1.02,0,1.41 L15.59,18l-1.89,1.89C13.32,20.27,13.32,20.91,13.71,21.3z M14,11c0-0.55-0.45-1-1-1H4c-0.55,0-1,0.45-1,1s0.45,1,1,1h9 C13.55,12,14,11.55,14,11z M14,7c0-0.55-0.45-1-1-1H4C3.45,6,3,6.45,3,7s0.45,1,1,1h9C13.55,8,14,7.55,14,7z M3,15 c0,0.55,0.45,1,1,1h5c0.55,0,1-0.45,1-1s-0.45-1-1-1H4C3.45,14,3,14.45,3,15z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
