// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundDownloading : ComponentBase
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
		builder.AddAttribute(21, "d", "M17.33,3.55c-0.94-0.6-1.99-1.04-3.12-1.3C13.59,2.11,13,2.59,13,3.23v0c0,0.45,0.3,0.87,0.74,0.97 c0.91,0.2,1.77,0.56,2.53,1.05c0.39,0.25,0.89,0.17,1.22-0.16l0,0C17.94,4.64,17.87,3.89,17.33,3.55z M20.77,11L20.77,11 c0.64,0,1.13-0.59,0.98-1.21c-0.26-1.12-0.7-2.17-1.3-3.12c-0.34-0.54-1.1-0.61-1.55-0.16l0,0c-0.32,0.32-0.4,0.83-0.16,1.22 c0.49,0.77,0.85,1.62,1.05,2.53C19.9,10.7,20.31,11,20.77,11z M18.9,17.49L18.9,17.49c0.45,0.45,1.21,0.38,1.55-0.15 c0.6-0.94,1.04-1.99,1.3-3.11c0.14-0.62-0.35-1.21-0.98-1.21h0c-0.45,0-0.87,0.3-0.97,0.74c-0.2,0.91-0.57,1.76-1.05,2.53 C18.5,16.66,18.58,17.17,18.9,17.49z M13,20.77L13,20.77c0,0.64,0.59,1.13,1.21,0.98c1.12-0.26,2.17-0.7,3.11-1.3 c0.54-0.34,0.61-1.1,0.16-1.55l0,0c-0.32-0.32-0.83-0.4-1.21-0.15c-0.76,0.49-1.61,0.85-2.53,1.05C13.3,19.9,13,20.31,13,20.77z M13,12V8c0-0.55-0.45-1-1-1h0c-0.55,0-1,0.45-1,1v4H9.41c-0.89,0-1.34,1.08-0.71,1.71l2.59,2.59c0.39,0.39,1.02,0.39,1.41,0 l2.59-2.59c0.63-0.63,0.18-1.71-0.71-1.71H13z M11,20.77L11,20.77c0,0.64-0.59,1.13-1.21,0.99C5.33,20.75,2,16.77,2,12 s3.33-8.75,7.79-9.75C10.41,2.11,11,2.59,11,3.23v0c0,0.46-0.31,0.87-0.76,0.97C6.67,5,4,8.19,4,12s2.67,7,6.24,7.8 C10.69,19.9,11,20.31,11,20.77z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
