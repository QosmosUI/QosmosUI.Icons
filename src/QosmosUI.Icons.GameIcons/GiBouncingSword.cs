// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiBouncingSword : ComponentBase
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
		builder.AddAttribute(14, "d", "M414.666 22.572L19.91 114.15l251.8 266.028-59.66 59.69 282.602 53.44-53.41-282.75-31.545 31.563 36.826 84.86-79.253-87.507-80.643-79.217 41.025 80.377-135.38-114.785L414.667 22.572zM232.484 215.77c11.482 0 20.787 9.308 20.787 20.79 0 2.462-.43 4.824-1.215 7.016l35.55 34.21 33.06-30.81 12.74 13.672-17.374 16.19 138.286 133.64L473.236 471l-60.515-17.447-140.55-135.84-18.096 16.86-12.74-13.67 32.578-30.358-35.418-34.082c-1.903.574-3.92.887-6.01.887-11.48 0-20.787-9.31-20.787-20.79 0-11.482 9.306-20.79 20.787-20.79zm68.883 75.617l-12.963 13.463L426.96 438.256l12.964-13.463-138.557-133.406z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
