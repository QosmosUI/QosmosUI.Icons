// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundSettingsSuggest : ComponentBase
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
		builder.AddAttribute(19, "d", "M18.04,7.99l-0.63-1.4l-1.4-0.63c-0.39-0.18-0.39-0.73,0-0.91l1.4-0.63l0.63-1.4c0.18-0.39,0.73-0.39,0.91,0l0.63,1.4 l1.4,0.63c0.39,0.18,0.39,0.73,0,0.91l-1.4,0.63l-0.63,1.4C18.78,8.38,18.22,8.38,18.04,7.99z M21.28,12.72L20.96,12 c-0.18-0.39-0.73-0.39-0.91,0l-0.32,0.72L19,13.04c-0.39,0.18-0.39,0.73,0,0.91l0.72,0.32L20.04,15c0.18,0.39,0.73,0.39,0.91,0 l0.32-0.72L22,13.96c0.39-0.18,0.39-0.73,0-0.91L21.28,12.72z M16.24,14.37l1.23,0.93c0.4,0.3,0.51,0.86,0.26,1.3l-1.62,2.8 c-0.25,0.44-0.79,0.62-1.25,0.42l-1.43-0.6c-0.2,0.13-0.42,0.26-0.64,0.37l-0.19,1.54c-0.06,0.5-0.49,0.88-0.99,0.88H8.38 c-0.5,0-0.93-0.38-0.99-0.88L7.2,19.59c-0.22-0.11-0.43-0.23-0.64-0.37l-1.43,0.6c-0.46,0.2-1,0.02-1.25-0.42l-1.62-2.8 c-0.25-0.44-0.14-0.99,0.26-1.3l1.23-0.93C3.75,14.25,3.75,14.12,3.75,14s0-0.25,0.01-0.37L2.53,12.7c-0.4-0.3-0.51-0.86-0.26-1.3 l1.62-2.8c0.25-0.44,0.79-0.62,1.25-0.42l1.43,0.6c0.2-0.13,0.42-0.26,0.64-0.37l0.19-1.54C7.45,6.38,7.88,6,8.38,6h3.23 c0.5,0,0.93,0.38,0.99,0.88l0.19,1.54c0.22,0.11,0.43,0.23,0.64,0.37l1.43-0.6c0.46-0.2,1-0.02,1.25,0.42l1.62,2.8 c0.25,0.44,0.14,0.99-0.26,1.3l-1.23,0.93c0.01,0.12,0.01,0.24,0.01,0.37S16.25,14.25,16.24,14.37z M13,14c0-1.66-1.34-3-3-3 s-3,1.34-3,3s1.34,3,3,3S13,15.66,13,14z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
