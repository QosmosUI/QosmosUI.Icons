// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.TwoTone;

public class MdTwoToneCampaign : ComponentBase
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
		builder.OpenElement(18, "path");
		builder.AddAttribute(19, "d", "M18,11c0,0.67,0,1.33,0,2c1.2,0,2.76,0,4,0c0-0.67,0-1.33,0-2C20.76,11,19.2,11,18,11z");
		builder.CloseElement();
		builder.OpenElement(20, "path");
		builder.AddAttribute(21, "d", "M16,17.61c0.96,0.71,2.21,1.65,3.2,2.39c0.4-0.53,0.8-1.07,1.2-1.6c-0.99-0.74-2.24-1.68-3.2-2.4 C16.8,16.54,16.4,17.08,16,17.61z");
		builder.CloseElement();
		builder.OpenElement(22, "path");
		builder.AddAttribute(23, "d", "M20.4,5.6C20,5.07,19.6,4.53,19.2,4c-0.99,0.74-2.24,1.68-3.2,2.4c0.4,0.53,0.8,1.07,1.2,1.6 C18.16,7.28,19.41,6.35,20.4,5.6z");
		builder.CloseElement();
		builder.OpenElement(24, "path");
		builder.AddAttribute(25, "d", "M4,9c-1.1,0-2,0.9-2,2v2c0,1.1,0.9,2,2,2h1v4h2v-4h1l5,3V6L8,9H4z M9.03,10.71L11,9.53v4.94l-1.97-1.18L8.55,13H8H4v-2h4 h0.55L9.03,10.71z");
		builder.CloseElement();
		builder.OpenElement(26, "path");
		builder.AddAttribute(27, "d", "M15.5,12c0-1.33-0.58-2.53-1.5-3.35v6.69C14.92,14.53,15.5,13.33,15.5,12z");
		builder.CloseElement();
		builder.OpenElement(28, "path");
		builder.AddAttribute(29, "d", "M9.03,10.71L11,9.53v4.94l-1.97-1.18L8.55,13H8H4v-2h4h0.55L9.03,10.71z");
		builder.AddAttribute(30, "opacity", ".3");
		builder.CloseElement();
		builder.CloseElement();
    }
}
