// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiTreeRoots : ComponentBase
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
		builder.AddAttribute(14, "d", "M167.2 20.48L147 189.6s-44.4 17.3-60.77 33.7c-32.1 32.1-65.98 119.2-65.98 119.2l51.51-53.6L107.2 323l-18.73-51.5 6.76-7s51.27-44.3 80.97-39.7c36 5.6 78.8 75.7 78.8 75.7l-18.2 80.9c-54.1 26.1-106.6 55.2-159.39 83.9l79.29-22.2 12 47.9 15-50.3s38-30.2 60.8-31.5c20.8-1.1 58.4 22.5 58.4 22.5l-37.4 40.5 78.7-32.2-62.3-45c30.7-52.3 39.3-96.6 28.5-156.7 14-11.5 38.3-23.6 59.9-13.5l-18.2 30.5 46.7 59.4-15.4-53 10.3-21.2c26.2 23.9 42.8 62.7 44.2 96.8 1.5 34.9-48.4 92.9-48.4 92.9 63.4-39.8 78.2-86.1 67.7-133.4 11.4 1.2 23.2-1.9 36.3-4.2-30.9-10.9-39.8-21.6-51.4-37.3-7.7-15.6-17.4-31-28.2-46.2l1.9-16.9-30.4-22.9-37.5 9-25.5-157.82z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
