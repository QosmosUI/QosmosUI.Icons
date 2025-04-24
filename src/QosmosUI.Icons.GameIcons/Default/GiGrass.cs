// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiGrass : ComponentBase
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
		builder.AddAttribute(14, "d", "M18 494l36.35-330.4c6.728 107.62 4.086 231.82 35.556 295.67 11.205-84.926 15.707-168.18 10.562-249.01 15.225 71.69 35.543 141.68 39.468 217.14 7.395-55.935 12.667-111.52 31.798-169.41-.76 65.19-17.16 124.9 12.677 157.47 14.433-51.01 28.992-101.9 31.46-164.88 21.27 61.862 18.342 135.82 24.948 205.02 8.417-68.06 15.28-257.84 46.907-318.17-3.11 124.98-3.862 223.94 27.398 274.23 30.897-38.673 33.566-114.44 34.28-186.34 21.812 61.75 36.457 132.1 37.857 218.34 8.626-71.955 18.667-143.91 43.39-215.86-5.748 88.29-1.284 156.95 19.525 194.17 13.76-55.55 25.504-111.1 29.12-166.66 18.42 82.78 13 159.59 16.706 238.69z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
