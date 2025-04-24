// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiMisdirection : ComponentBase
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
		builder.AddAttribute(14, "d", "M273.5 22.48L166 86.15l45.2 16.05-42.8 120.6 60.2 21.4 42.9-120.6 45.2 16.1zM62.4 35.28l-4.77 59.96-22.59-1.91 34 48.07L110 99.44l-22.46-1.8 4.83-60.11zm329 58.44l-30.1 27.98 55.8 60.2-22.7 20.9 79.6 10.3-4.2-80-22.6 20.9zM45.51 202.5L32.3 237l68.6 26.7-10.22 25.8 68.42-22.7-34.6-63.2-10.2 25.9zm377.79 51.8l-94.9 7.6 24.7 91.6 21-29.8 79.4 56.3 28-39.8-79.4-56.1zm-180.7 14.5L106.8 370.7l-38.27-51.3-38.05 161.7 165.32 8.4-38.1-51 136.1-101.8zm92.8 115.6l-22.3 15.8 31.3 44.9-16.9 11.7 51.6 14.3 4.8-53.3-17 11.7z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
