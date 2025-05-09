// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.TwoTone;

public class MdTwoToneQuiz : ComponentBase
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
		builder.OpenElement(14, "path");
		builder.AddAttribute(15, "d", "M0,0h24v24H0V0z");
		builder.AddAttribute(16, "fill", "none");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(17, "g");
		builder.OpenElement(18, "path");
		builder.AddAttribute(19, "d", "M8,4v12h12V4H8z M14.74,14.69C14.54,14.9,14.3,15,14.01,15c-0.29,0-0.54-0.1-0.74-0.31 c-0.21-0.21-0.31-0.45-0.31-0.74c0-0.29,0.1-0.54,0.31-0.74c0.21-0.2,0.45-0.3,0.74-0.3c0.29,0,0.54,0.1,0.74,0.3 c0.2,0.2,0.3,0.45,0.3,0.74C15.05,14.24,14.94,14.49,14.74,14.69z M16.51,8.83c-0.23,0.34-0.54,0.69-0.92,1.06 c-0.3,0.27-0.51,0.52-0.64,0.75c-0.12,0.23-0.18,0.49-0.18,0.78v0.4h-1.52v-0.56c0-0.42,0.09-0.78,0.26-1.09 C13.69,9.85,14,9.5,14.46,9.1c0.32-0.29,0.55-0.54,0.69-0.74c0.14-0.2,0.21-0.44,0.21-0.72c0-0.36-0.12-0.65-0.36-0.87 c-0.24-0.23-0.57-0.34-0.99-0.34c-0.4,0-0.72,0.12-0.97,0.36c-0.25,0.24-0.42,0.53-0.53,0.87l-1.37-0.57 c0.18-0.55,0.52-1.03,1-1.45C12.63,5.21,13.25,5,13.99,5c0.56,0,1.05,0.11,1.49,0.33c0.44,0.22,0.78,0.53,1.02,0.93 c0.24,0.4,0.36,0.84,0.36,1.33C16.86,8.08,16.75,8.49,16.51,8.83z");
		builder.AddAttribute(20, "opacity", ".3");
		builder.CloseElement();
		builder.OpenElement(21, "path");
		builder.AddAttribute(22, "d", "M4,6H2v14c0,1.1,0.9,2,2,2h14v-2H4V6z M20,2H8C6.9,2,6,2.9,6,4v12c0,1.1,0.9,2,2,2h12c1.1,0,2-0.9,2-2V4 C22,2.9,21.1,2,20,2z M20,16H8V4h12V16z M13.51,10.16c0.41-0.73,1.18-1.16,1.63-1.8c0.48-0.68,0.21-1.94-1.14-1.94 c-0.88,0-1.32,0.67-1.5,1.23l-1.37-0.57C11.51,5.96,12.52,5,13.99,5c1.23,0,2.08,0.56,2.51,1.26c0.37,0.6,0.58,1.73,0.01,2.57 c-0.63,0.93-1.23,1.21-1.56,1.81c-0.13,0.24-0.18,0.4-0.18,1.18h-1.52C13.26,11.41,13.19,10.74,13.51,10.16z M12.95,13.95 c0-0.59,0.47-1.04,1.05-1.04c0.59,0,1.04,0.45,1.04,1.04c0,0.58-0.44,1.05-1.04,1.05C13.42,15,12.95,14.53,12.95,13.95z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
