// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiFireShrine : ComponentBase
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
		builder.AddAttribute(14, "d", "M321.7 21.73S167.5 84.97 146.2 155.4c-12.2 40.4 24.2 109.5 44.1 142.9h45.4c19.9-39.4-1.5-84.4-23.1-109.4 0 0 58.6 37.5 65.2 68.3 2.5 11.6-6.4 30.2-12.4 41.1H310c21-16.7 48.3-43.1 45.1-65-6.4-44.4-72-56.5-82.2-100.2-12-51.29 48.8-111.37 48.8-111.37zM64 192.8c-12.8 0-23 10.2-23 23s10.2 23 23 23 23-10.2 23-23-10.2-23-23-23zm384 1c-12.8 0-23 10.2-23 23s10.2 23 23 23 23-10.2 23-23-10.2-23-23-23zm-393 62v200h18v-200c-2.9.6-5.9 1-9 1-3.1 0-6.1-.4-9-1zm384 1v200h18v-200c-2.9.6-5.9 1-9 1-3.1 0-6.1-.4-9-1zm-270 59.5v30h174v-30H169zm30.2 48l-28 126h169.6l-28-126H199.2zm16.1 36.8l17.4 4.4-13.2 52.8h73l-13.2-52.8 17.4-4.4 18.8 75.2h-119l18.8-75.2zM32 470.8v18h64v-18H32zm384 1v18h64v-18h-64z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
