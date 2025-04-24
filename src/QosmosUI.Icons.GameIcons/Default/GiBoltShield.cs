// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiBoltShield : ComponentBase
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
		builder.AddAttribute(14, "d", "M104.53 75.188l.064 11.75C105.387 196.84 154.647 306.933 252 401l6.5 6.28L265 401c96.765-93.853 146.975-204.032 147.844-314.063l.094-11.718-11.47 2.53c-80.262 17.713-205.254 17.923-285.468 0l-11.47-2.563zm33.907 32.468l11.438 2.563c60.965 13.62 156.674 13.463 217.688 0l11.468-2.532-.092 11.718c-.67 84.917-39.46 169.857-113.907 242.063l-6.467 6.28-6.5-6.28C177.16 289.095 139.113 204.213 138.5 119.405l-.063-11.75zm221.407 22.97c-60.417 11.242-141.785 11.386-202.25.03 3.59 73.105 36.766 146.23 100.937 210.844 63.845-64.506 97.625-137.755 101.314-210.875zm-340.22 136.5L123 433.468l17.906-51.314 96.188 88.156L133.72 303.97l-17.907 51.31-96.188-88.155zm470.532 0l-96.22 88.155-17.873-51.31L272.656 470.31l96.188-88.156 17.906 51.313 103.406-166.345z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
