// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiWorriedEyes : ComponentBase
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
		builder.AddAttribute(14, "d", "M158.063 154.75c-31.32.613-72.27 32.376-130.063 119.156 28.377 32.465 60.522 47.17 92.875 46.813-13.872-6.878-23.438-21.162-23.438-37.69 0-23.222 18.84-42.06 42.063-42.06 23.224 0 42.03 18.838 42.03 42.06 0 8.79-2.703 16.94-7.31 23.69 24.134-12.47 47.217-32.947 67.655-60.25-22.28-47.856-46.015-92.46-83.813-91.72zm202.593 0c-36.864.538-60.257 44.548-82.22 91.72 18.105 24.185 38.286 43.003 59.44 55.655-2.934-5.736-4.595-12.212-4.595-19.094 0-23.222 18.84-42.06 42.064-42.06 23.223 0 42.03 18.838 42.03 42.06 0 16.393-9.383 30.592-23.062 37.533 34.08 2.043 68.157-12.48 98.032-46.657-58.79-88.276-100.166-119.616-131.688-119.156z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
