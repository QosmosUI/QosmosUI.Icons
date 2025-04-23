// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.AntDesignIcons.Outline;

public class AiOutlineDotNet : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 1024 1024";

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
		builder.AddAttribute(14, "fill-opacity", ".88");
		builder.AddAttribute(15, "transform", "translate(64 362)");
		builder.OpenElement(16, "path");
		builder.AddAttribute(17, "d", "M37.283 300c-10.652 0-19.53-3.297-26.63-9.89C3.55 283.514 0 275.41 0 265.793c0-9.891 3.653-17.996 10.96-24.315 7.306-6.32 16.422-9.479 27.347-9.479 11.062 0 20.11 3.194 27.143 9.582C72.483 247.97 76 256.04 76 265.794c0 10.028-3.585 18.236-10.755 24.624-7.17 6.388-16.49 9.582-27.962 9.582M394 295h-66.969L205.624 109.648c-7.121-10.835-12.052-18.995-14.79-24.48h-.822c1.095 10.422 1.643 26.331 1.643 47.726V295H129V0h71.488l116.888 179.592c5.341 8.092 10.271 16.115 14.79 24.07h.822c-1.095-6.858-1.643-20.367-1.643-40.527V0H394z");
		builder.CloseElement();
		builder.OpenElement(18, "path");
		builder.AddAttribute(19, "d", "M638 295 461 295 461 0 631.20814 0 631.20814 54.1039052 527.477907 54.1039052 527.477907 119.728033 624.004651 119.728033 624.004651 173.62622 527.477907 173.62622 527.477907 241.101813 638 241.101813z");
		builder.CloseElement();
		builder.OpenElement(20, "path");
		builder.AddAttribute(21, "d", "M896 54.1039052 812.047368 54.1039052 812.047368 295 745.542105 295 745.542105 54.1039052 662 54.1039052 662 0 896 0z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
