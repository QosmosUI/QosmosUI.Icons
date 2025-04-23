// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundScale : ComponentBase
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
		builder.OpenElement(19, "path");
		builder.AddAttribute(20, "d", "M16,21c0,0.55,0.45,1,1,1l3.43,0c0.87,0,1.58-0.75,1.5-1.62C21.34,14.18,17.4,11.68,14,11V8c3.31-0.42,6.03-1.86,7.27-3.73 C21.92,3.3,21.15,2,19.98,2H4.02C2.85,2,2.08,3.3,2.73,4.27C3.97,6.14,6.69,7.58,10,8l0,3c-3.4,0.68-7.34,3.18-7.93,9.38 C1.99,21.25,2.7,22,3.57,22L7,22c0.55,0,1-0.45,1-1c0-0.55-0.45-1-1-1H4.13c0.93-6.83,6.65-7.2,7.87-7.2s6.94,0.37,7.87,7.2H17 C16.45,20,16,20.45,16,21z M11.5,21.94c-0.7-0.17-1.27-0.74-1.44-1.44c-0.18-0.74,0.06-1.44,0.53-1.91 c0.55-0.55,2.91-1.57,4.33-2.15c0.41-0.17,0.82,0.24,0.65,0.65c-0.58,1.42-1.6,3.78-2.15,4.33C12.95,21.88,12.25,22.12,11.5,21.94z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
