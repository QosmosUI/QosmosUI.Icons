// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Sharp;

public class MdSharpSettingsSuggest : ComponentBase
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
		builder.OpenElement(17, "g");
		builder.OpenElement(18, "path");
		builder.AddAttribute(19, "d", "M17.41,6.59L15,5.5l2.41-1.09L18.5,2l1.09,2.41L22,5.5l-2.41,1.09L18.5,9L17.41,6.59z M21.28,12.72L20.5,11l-0.78,1.72 L18,13.5l1.72,0.78L20.5,16l0.78-1.72L23,13.5L21.28,12.72z M16.24,14.37l1.94,1.47l-2.5,4.33l-2.24-0.94 c-0.2,0.13-0.42,0.26-0.64,0.37L12.5,22h-5l-0.3-2.41c-0.22-0.11-0.43-0.23-0.64-0.37l-2.24,0.94l-2.5-4.33l1.94-1.47 C3.75,14.25,3.75,14.12,3.75,14s0-0.25,0.01-0.37l-1.94-1.47l2.5-4.33l2.24,0.94c0.2-0.13,0.42-0.26,0.64-0.37L7.5,6h5l0.3,2.41 c0.22,0.11,0.43,0.23,0.64,0.37l2.24-0.94l2.5,4.33l-1.94,1.47c0.01,0.12,0.01,0.24,0.01,0.37S16.25,14.25,16.24,14.37z M13,14 c0-1.66-1.34-3-3-3s-3,1.34-3,3s1.34,3,3,3S13,15.66,13,14z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
