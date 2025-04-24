// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiMetalGolemHead : ComponentBase
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
		builder.AddAttribute(14, "d", "M256 33.85L168.2 63.1l-6.6 52.9 94.4 27 94.4-27-6.6-52.9zm-54 60.51a10 9.999 0 0 1 10 10.04 10 9.999 0 0 1-10 10 10 9.999 0 0 1-10-10 10 9.999 0 0 1 10-10.04zm108 0a10 9.999 0 0 1 10 10.04 10 9.999 0 0 1-10 10 10 9.999 0 0 1-10-10 10 9.999 0 0 1 10-10.04zM103 104.4v64h18v-23h18.8l2.1-16.2-.4-.1.5-1.7h-21v-23zm153 0a10 9.999 0 0 1 10 10 10 9.999 0 0 1-10 10 10 9.999 0 0 1-10-10 10 9.999 0 0 1 10-10zm135 0v23h-21l.5 1.7-.4.1 2.1 16.2H391v23h18v-64zm-231.7 29.8l-6.5 52.2-16 48.1 20.1 26.8 16.8-50.3 48.7 81.2 24.6-61.5v-71.5zm193.4 0l-87.7 25v71.5l24.6 61.5 48.7-81.2 16.8 50.3 20.1-26.8-16-48.1zm-178.7 22l57.2 23.7-3.3 17.3-65.3 1 8.7-32.2zm164 0l11.4 42-65.3-1-3.3-17.3 47.8-19.8zm-221.9 80.7l-9.1 36.5 43 8.6zm279.8 0L362 282l43-8.6zm-217.6 16.9l-10.5 31.8 32.6 6.5 1.1.2zm155.4 0l-23.2 38.5 15-3 18.7-3.7zm-77.7 2.8l-17.3 43.1 17.3 3.5 17.3-3.5zm-149 35.2l28.8 172.5L247 478.2V376.4h18v101.8l111.2-13.9L405 291.8l-149 29.8zm111 80.6a10 9.999 0 0 1 10 10 10 9.999 0 0 1-10 10 10 9.999 0 0 1-10-10 10 9.999 0 0 1 10-10zm76 0a10 9.999 0 0 1 10 10 10 9.999 0 0 1-10 10 10 9.999 0 0 1-10-10 10 9.999 0 0 1 10-10zm-76 64a10 9.999 0 0 1 10 10 10 9.999 0 0 1-10 10 10 9.999 0 0 1-10-10 10 9.999 0 0 1 10-10zm76 0a10 9.999 0 0 1 10 10 10 9.999 0 0 1-10 10 10 9.999 0 0 1-10-10 10 9.999 0 0 1 10-10z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
