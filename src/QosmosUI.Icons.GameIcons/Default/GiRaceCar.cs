// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiRaceCar : ComponentBase
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
		builder.AddAttribute(14, "d", "M408.29 262.879a35.125 35.125 0 1 0 35.125 35.125 35.17 35.17 0 0 0-35.125-35.125zm0 62.873a27.736 27.736 0 1 1 27.736-27.737 27.736 27.736 0 0 1-27.736 27.748zm8.876-27.737a8.876 8.876 0 1 1-8.876-8.875 8.876 8.876 0 0 1 8.876 8.875zm-265.538 0a35.125 35.125 0 1 0-35.126 35.126 35.17 35.17 0 0 0 35.126-35.126zm-35.126 27.737a27.736 27.736 0 1 1 27.737-27.737 27.736 27.736 0 0 1-27.737 27.748zm345.452-21.823a53.997 53.997 0 1 0-107.617-5.925 53.665 53.665 0 0 0 5.447 23.61H165.008a53.986 53.986 0 1 0-101.849-15.211C37.542 295.64 21 278.033 21 250.186c0-28.846 86.87-69.418 142.122-71.327v34.094a24.83 24.83 0 0 0 24.83 24.83h47.517a24.774 24.774 0 0 0 24.409-20.758s-1.62-21.668-6.813-25.518l3.407-2.54 24.474 28.08h94.104c63.994-.022 115.95 23.42 115.95 52.266 0 13.314-10.973 25.396-29.046 34.616zm-336.576-5.925a8.876 8.876 0 1 1-8.876-8.876 8.876 8.876 0 0 1 8.876 8.887z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
