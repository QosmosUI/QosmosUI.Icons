// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundBroadcastOnHome : ComponentBase
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
		builder.OpenElement(23, "g");
		builder.OpenElement(24, "path");
		builder.AddAttribute(25, "d", "M22,6c0-1.1-0.9-2-2-2H5C4.45,4,4,4.45,4,5v0c0,0.55,0.45,1,1,1h15v2.59c0.73,0.29,1.4,0.69,2,1.17V6z");
		builder.CloseElement();
		builder.OpenElement(26, "path");
		builder.AddAttribute(27, "d", "M8,9H3c-0.5,0-1,0.5-1,1v9c0,0.5,0.5,1,1,1h5c0.5,0,1-0.5,1-1v-9C9,9.5,8.5,9,8,9z M7,18H4v-7h3V18z");
		builder.CloseElement();
		builder.OpenElement(28, "path");
		builder.AddAttribute(29, "d", "M17.75,16.97c0.3-0.23,0.5-0.57,0.5-0.97c0-0.69-0.56-1.25-1.25-1.25s-1.25,0.56-1.25,1.25c0,0.4,0.2,0.75,0.5,0.97v4.28 c0,0.41,0.34,0.75,0.75,0.75l0,0c0.41,0,0.75-0.34,0.75-0.75V16.97z");
		builder.CloseElement();
		builder.OpenElement(30, "path");
		builder.AddAttribute(31, "d", "M17.54,13.56c0.98,0.21,1.76,1.03,1.93,2.02c0.11,0.64-0.03,1.25-0.34,1.74c-0.18,0.29-0.13,0.67,0.12,0.91l0,0 c0.34,0.33,0.9,0.29,1.16-0.12c0.51-0.82,0.73-1.83,0.53-2.9c-0.3-1.56-1.56-2.83-3.12-3.13C15.24,11.58,13,13.53,13,16 c0,0.78,0.22,1.5,0.6,2.11c0.25,0.41,0.83,0.46,1.16,0.12l0,0c0.24-0.24,0.29-0.63,0.11-0.92c-0.24-0.38-0.37-0.83-0.37-1.31 C14.5,14.45,15.93,13.22,17.54,13.56z");
		builder.CloseElement();
		builder.OpenElement(32, "path");
		builder.AddAttribute(33, "d", "M16.25,9.54c-2.94,0.33-5.32,2.68-5.69,5.61c-0.23,1.82,0.29,3.51,1.3,4.82c0.27,0.35,0.8,0.37,1.12,0.06l0,0 c0.27-0.27,0.28-0.7,0.05-1c-0.8-1.05-1.2-2.43-0.95-3.89c0.34-2.03,1.95-3.67,3.98-4.05C19.22,10.5,22,12.93,22,16 c0,1.13-0.38,2.18-1.02,3.02c-0.23,0.3-0.21,0.73,0.06,1l0,0c0.31,0.31,0.84,0.3,1.11-0.06C23,18.87,23.5,17.49,23.5,16 C23.5,12.16,20.17,9.1,16.25,9.54z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
