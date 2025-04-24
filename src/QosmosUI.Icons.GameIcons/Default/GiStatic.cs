// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiStatic : ComponentBase
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
		builder.AddAttribute(14, "d", "M142.7 18.72L20 77.56v20.72l120.3-57.72L20 132v112.7l129.4-46.8-63.4-9.3 188-45.8L20 326.5V370l349.6-189.6-81.1 18.3 115.2-71.4 91.6-34.58v-20C432 101.4 368 115.2 301 131.6l44.4-30.2 149.9-72.81v-9.87h-22.5C393.2 63.83 310.6 89.86 224.7 119.7L383.5 18.72H302L112.3 114.1l122.2-95.38zM495.3 143.3L230.6 299.6l150.5-39.1L78.72 418.7l102.38-90.8L20 409v85h32.94S223 392.8 317.3 354.7L247 407l112.6-34.4-216.2 119.5 286-102.1-82 57.6L495.3 406V298.4l-139.9 52.3 72.7-58.5-133.7 47.2 177-115.1-24.9 42.5 48.8-18.5v-105z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
