// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiHeavyFighter : ComponentBase
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
		builder.AddAttribute(14, "d", "M215.076 20.037L100.752 135.693l52.135 79.313L41.662 378.65 21 491.963l112.848-20.742 162.974-111.69 79.42 52.784L491 297.09 215.076 20.037zm100.87 21.885l-21.083 21.176L311.73 80.03l21.086-21.17-16.87-16.938zm130.71 4.252l-84.32 84.668 16.86 16.937 84.33-84.667-16.87-16.94zm-75.892 8.463l-42.16 42.336 16.867 16.935 42.165-42.334-16.87-16.937zm67.46 67.746l-42.154 42.33 16.862 16.935 42.166-42.332-16.873-16.933zm12.66 55.035l-21.08 21.17 16.862 16.935 21.088-21.168-16.87-16.937zM244.36 244.285c6.307.15 11.87 2.173 15.923 6.242 11.793 11.843 6.347 36.51-12.162 55.098-18.51 18.585-43.077 24.058-54.87 12.22-11.793-11.845-6.347-36.515 12.166-55.1 12.146-12.198 26.902-18.746 38.943-18.46z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
