// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundRawOff : ComponentBase
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
		builder.CloseElement();
		builder.OpenElement(18, "g");
		builder.OpenElement(19, "g");
		builder.OpenElement(20, "path");
		builder.AddAttribute(21, "d", "M20.55,9c-0.33,0-0.63,0.23-0.71,0.55L19.24,12l-0.56-2.26C18.58,9.3,18.19,9,17.74,9S16.9,9.3,16.8,9.74L16.24,12 l-0.6-2.45C15.56,9.23,15.27,9,14.93,9c-0.47,0-0.82,0.44-0.71,0.9l0.5,1.99l2.42,2.42c0-0.01,0.01-0.02,0.01-0.03l0.58-2.32 l0.58,2.32C18.43,14.7,18.81,15,19.24,15s0.81-0.3,0.92-0.72l1.09-4.38C21.37,9.44,21.02,9,20.55,9z");
		builder.CloseElement();
		builder.OpenElement(22, "path");
		builder.AddAttribute(23, "d", "M3.51,3.51c-0.39-0.39-1.02-0.39-1.41,0c-0.39,0.39-0.39,1.02,0,1.41L6.17,9H4c-0.55,0-1,0.45-1,1v4.31 C3,14.69,3.31,15,3.69,15h0.11c0.38,0,0.69-0.31,0.69-0.69V13h1.1l0.72,1.59C6.43,14.84,6.68,15,6.95,15 c0.5,0,0.83-0.51,0.64-0.97L7.1,12.9C7.6,12.6,8,12.1,8,11.5v-0.67l1.43,1.43L8.98,14.1C8.86,14.56,9.21,15,9.68,15h0 c0.33,0,0.62-0.23,0.7-0.55l0.24-0.95h0.04l8.4,8.4c0.39,0.39,1.02,0.39,1.41,0c0.39-0.39,0.39-1.02,0-1.41L3.51,3.51z M6.5,11.5 h-2v-1h2V11.5z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
