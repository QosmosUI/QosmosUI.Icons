// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiFalling : ComponentBase
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
		builder.AddAttribute(14, "d", "M221.313 16a23.682 23.695 0 0 0-23.688 23.688v106.406a23.682 23.695 0 0 0 2.156 9.72 23.682 23.695 0 0 0 3.157 13.81l41.75 71.626-79 55.438 6.094-48.625a23.682 23.695 0 0 0-8.186-20.97l-66.28-81.937a23.682 23.695 0 0 0-33.314-3.5l-9.188 7.438a23.682 23.695 0 0 0-3.53 33.344l59.78 73.906-11.25 89.937a23.682 23.695 0 0 0 12.47 23.876l37.468 53.47a23.695 23.682 1.57 0 0 2.344 2.812 23.682 23.695 0 0 0 13.594 20.062L262 491.53a23.682 23.695 0 0 0 9.97 2.22 23.682 23.695 0 0 0 23.53-2.063l87.156-60.937a23.682 23.695 0 0 0 5.844-33l-6.78-9.688a23.682 23.695 0 0 0-32.97-5.875l-72.406 50.657-59.063-27.625 120.595-84.626a23.695 23.682 1.57 0 0 5.53-5.5 23.682 23.695 0 0 0 14.626-13.594l37.22-91.53 87.813-44.845a23.694 23.682 1.18 0 0 10.312-31.875L488 122.687a23.694 23.682 1.18 0 0-31.875-10.343l-94.688 48.375a23.694 23.682 1.18 0 0-9.843 9.436 23.682 23.695 0 0 0-8.344 10.47l-27.375 67.31-5.22-7.436a23.682 23.695 0 0 0-3-8.844l-50.81-87.094V39.688A23.682 23.695 0 0 0 233.154 16h-11.843zM77.75 376A59.994 60 0 0 0 16 436a59.994 60 0 1 0 120 0 59.994 60 0 0 0-58.25-60z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
