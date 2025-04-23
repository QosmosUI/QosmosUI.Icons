// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FontAwesome.Solid;

public class FaPersonSnowboarding : ComponentBase
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
		builder.AddAttribute(14, "d", "M209.7 3.4c15.8-7.9 35-1.5 42.9 14.3l25 50 42.4 8.5c19.5 3.9 37.8 12.3 53.5 24.5l126.1 98.1c14 10.9 16.5 31 5.6 44.9s-31 16.5-44.9 5.6l-72.1-56.1-71.5 31.8 33.1 27.6c23.2 19.3 33.5 50 26.7 79.4l-17.4 75.2c-2.2 9.4-8.2 16.8-16.1 21l86.5 33.1c4.6 1.8 9.4 2.6 14.3 2.6l28.2 0c13.3 0 24 10.7 24 24s-10.7 24-24 24l-28.2 0c-10.8 0-21.4-2-31.5-5.8L60.1 371.3c-11.5-4.4-22-11.2-30.8-20L7 329c-9.4-9.4-9.4-24.6 0-33.9s24.6-9.4 33.9 0l22.4 22.4c4 4 8.7 7.1 14 9.1l22.4 8.6c-.8-1.6-1.5-3.2-2.1-4.9c-5.6-16.8 3.5-34.9 20.2-40.5L192 264.9l0-53.2c0-24.2 13.7-46.4 35.4-57.2l45.2-22.6-7.5-1.5c-19.4-3.9-35.9-16.5-44.7-34.1l-25-50c-7.9-15.8-1.5-35 14.3-42.9zM139 350.1l159 60.9c-2.1-5.6-2.6-11.9-1.1-18.2l17.4-75.2c1.4-5.9-.7-12-5.3-15.9l-52.8-44 0 18.8c0 20.7-13.2 39-32.8 45.5L139 350.1zM432 0a48 48 0 1 1 0 96 48 48 0 1 1 0-96z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
