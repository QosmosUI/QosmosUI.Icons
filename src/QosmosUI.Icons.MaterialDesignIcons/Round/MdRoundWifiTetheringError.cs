// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundWifiTetheringError : ComponentBase
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
		builder.AddAttribute(20, "d", "M10.66,7.14c-2.24,0.48-4.04,2.3-4.52,4.54c-0.37,1.75,0.02,3.38,0.89,4.66c0.34,0.51,1.08,0.55,1.51,0.11l0,0 c0.35-0.35,0.37-0.88,0.1-1.28c-0.5-0.76-0.75-1.71-0.61-2.73c0.23-1.74,1.67-3.17,3.41-3.4C13.9,8.71,16,10.61,16,13 c0,0.8-0.24,1.54-0.64,2.16c-0.27,0.41-0.25,0.95,0.1,1.29l0,0c0.43,0.43,1.17,0.4,1.51-0.11C17.62,15.4,18,14.25,18,13 C18,9.25,14.55,6.3,10.66,7.14z M10.25,3.15c-4.05,0.69-7.19,3.69-8.03,7.72c-0.66,3.17,0.2,6.16,1.97,8.38 c0.37,0.46,1.07,0.49,1.49,0.07l0,0c0.36-0.36,0.39-0.93,0.07-1.32c-1.34-1.67-2.03-3.9-1.66-6.28c0.55-3.47,3.42-6.24,6.92-6.65 c2.76-0.33,5.27,0.74,6.93,2.59C18.14,7.87,18.41,8,18.7,8h0c0.85,0,1.34-1.01,0.77-1.65C17.28,3.9,13.91,2.53,10.25,3.15z M12,11 c-1.1,0-2,0.9-2,2c0,0.55,0.23,1.05,0.59,1.41C10.95,14.77,11.45,15,12,15s1.05-0.23,1.41-0.59C13.77,14.05,14,13.55,14,13 C14,11.9,13.1,11,12,11z M21,10L21,10c0.55,0,1,0.45,1,1v4c0,0.55-0.45,1-1,1h0c-0.55,0-1-0.45-1-1v-4C20,10.45,20.45,10,21,10z M21,18L21,18c0.55,0,1,0.45,1,1v0c0,0.55-0.45,1-1,1h0c-0.55,0-1-0.45-1-1v0C20,18.45,20.45,18,21,18z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
