// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundPin : ComponentBase
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
		builder.OpenElement(18, "g");
		builder.OpenElement(19, "path");
		builder.AddAttribute(20, "d", "M20,4H4C2.9,4,2,4.9,2,6v12c0,1.1,0.9,2,2,2h16c1.1,0,2-0.9,2-2V6C22,4.9,21.1,4,20,4z M7.64,14.47 C7.64,14.76,7.4,15,7.11,15H7.02c-0.29,0-0.53-0.24-0.53-0.53V10.5l-0.45,0.33c-0.24,0.18-0.59,0.12-0.76-0.14 c-0.15-0.24-0.1-0.55,0.13-0.72L6.6,9.12C6.71,9.04,6.84,9,6.98,9c0.36,0,0.66,0.29,0.66,0.66V14.47z M13.01,15h-2.67 c-0.4,0-0.72-0.32-0.72-0.72c0-0.19,0.08-0.38,0.21-0.51c0.95-0.95,1.58-1.58,1.92-1.94c0.4-0.42,0.54-0.69,0.54-1.06 c0-0.4-0.31-0.72-0.81-0.72c-0.34,0-0.57,0.16-0.72,0.37c-0.15,0.2-0.41,0.26-0.64,0.16c-0.34-0.14-0.45-0.57-0.22-0.85 c0.15-0.19,0.37-0.38,0.67-0.53c0.69-0.33,1.48-0.2,1.95,0.03c0.86,0.44,0.91,1.24,0.91,1.48c0,0.64-0.31,1.26-0.92,1.86 c-0.25,0.25-0.72,0.71-1.4,1.39l0.03,0.05h1.88c0.27,0,0.49,0.22,0.49,0.49S13.28,15,13.01,15z M18.75,14.15 C18.67,14.28,18.19,15,16.99,15c-0.03,0-1.23,0.06-1.83-0.98c-0.15-0.26-0.04-0.6,0.24-0.71l0.12-0.05 c0.22-0.09,0.47-0.01,0.59,0.19c0.14,0.24,0.39,0.49,0.88,0.49c0.41,0,0.89-0.28,0.89-0.77c0-0.55-0.48-0.79-1.04-0.79l0,0 c-0.27,0-0.49-0.23-0.49-0.5c0-0.26,0.2-0.47,0.45-0.49l0-0.01c0.33,0,0.88-0.14,0.88-0.72c0-0.39-0.31-0.65-0.75-0.65 c-0.32,0-0.53,0.13-0.67,0.3c-0.14,0.18-0.37,0.26-0.58,0.17l-0.08-0.03c-0.3-0.12-0.4-0.5-0.2-0.75C15.67,9.35,16.16,9,16.94,9 c1.09,0,1.54,0.64,1.62,0.75c0.33,0.5,0.28,1.16,0.02,1.57c-0.15,0.22-0.32,0.38-0.52,0.48v0.07c0.28,0.11,0.51,0.28,0.68,0.52 C19.11,12.91,19.07,13.66,18.75,14.15z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
