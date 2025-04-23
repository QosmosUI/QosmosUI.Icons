// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiIdCard : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 512 512";

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
		builder.OpenElement(13, "path");
		builder.AddAttribute(14, "d", "M50 96c-9.972 0-18 8.028-18 18v300c0 9.972 8.028 18 18 18h412c9.972 0 18-8.028 18-18V114c0-9.972-8.028-18-18-18H50zm5 23h402v18H55v-18zm0 32h210v258H55V151zm18 18v222h7.03c.47-24.342 18.315-74.172 47.093-97.889C136.331 300.56 147.615 305 160 305c12.385 0 23.669-4.44 32.877-11.889C221.655 316.828 239.5 366.658 239.97 391H247V169H73zm222 14h146v18H295v-18zm-135 10c20.835 0 39 20.241 39 47s-18.165 47-39 47-39-20.241-39-47 18.165-47 39-47zm135 22h114v18H295v-18zm0 32h50v18h-50v-18zm80 0h66v18h-66v-18zm-16 96h98v18h-98v-18zm-32 32h130v18H327v-18z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
