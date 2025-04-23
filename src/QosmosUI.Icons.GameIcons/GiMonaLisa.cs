// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiMonaLisa : ComponentBase
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
		builder.AddAttribute(14, "d", "M89 25v462h334V25H89zm30 30h274v402H119V55zm18 18v94h49.8c1-10.8 2.3-22 4.4-34 6.4-21 24.8-43.28 45-47.7 3.9-.95 8.4 1.48 12.6 1.4 2.7 0 13.4-2.68 15.3-2.8 30.8.81 55.3 33.7 59.3 60.3.6 4.5 2 12.7 3.6 22.8h48V73H137zm112.9 31.3c-9.9 0-19.3 5.7-26.9 16.6-7.5 10.9-12.6 26.7-12.6 44.3 0 17.6 5.1 33.4 12.6 44.3 7.6 10.9 17 16.6 26.9 16.6 9.9 0 19.3-5.7 26.9-16.6 7.5-10.9 12.6-26.7 12.6-44.3 0-17.6-5.1-33.4-12.6-44.3-7.6-10.9-17-16.6-26.9-16.6zM137 185v132.8c7.6-16.4 30-32.3 35.4-46 10.6-26.8 11-54.5 13.1-86.8H137zm193 0c3.5 22.9 7.9 46.9 9.9 69.3 14.7 9.4 27.1 21.6 35.1 35.5V185h-45zm-52.7 49.7c-8 5.9-17.3 9.4-27.4 9.4-3.6 0-7.1-.5-10.5-1.3-4.1 6.7-7.8 13.9-10.9 22.1-5 12.9-17.2 19.1-27.7 26.3-7.7 7.4-25.4 14.3-18.4 27.4 9.7 12.9 37.8 14.2 50.8 14.1 19.3-2.3 44.6-1.5 59-14.1l-14.9-83.9zm-60.1 124l-5.7 17.8 59.2 32.2 9.9-28.1c-12.6-12.3-36.5-17.9-63.4-21.9zm-15.6 44c-4.7 1.3-9.6 2.9-13.7 4.3-2.9 8.5-.5 18 1.7 29.8 22.3 3 37.9-8.3 54.6-18.5l-42.6-15.6z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
