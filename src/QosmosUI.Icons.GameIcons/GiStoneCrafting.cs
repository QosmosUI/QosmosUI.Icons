// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiStoneCrafting : ComponentBase
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
		builder.AddAttribute(14, "d", "M352.75 39.47l-33.094 83.374 111.156 111.28 58.22-58.28L352.75 39.47zm-160.344 5.218c-98.25 66.974-166.87 161.246-169.47 288.906 62.25-119.817 162.457-225.092 255.22-269.75l-85.75-19.157zM97.75 60.156L68.187 89.72c7.276 6.96 14.53 13.893 21.813 20.843 8.887-10.39 18.37-20.35 28.313-29.907l-20.563-20.5zm353.813 0L425.688 86l28.718 28.75c8.91-8.36 17.822-16.728 26.72-25.094l-29.563-29.5zm-263.938 89.75c-9.44 8.552-18.824 17.596-28.063 27.063 25.263 24.13 50.526 48.323 75.688 72.75l26.188-26.126-73.813-73.688zm153.313 20.72L68 443.155l29.313 29.22c83.48-96.13 175.757-186.498 269.812-275.532l-26.188-26.22zm-28.25 104.155c-8.692 8.42-17.35 16.853-25.97 25.314 55.896 55.38 111.166 112.353 165.157 172.437l29.438-29.374L312.688 274.78z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
