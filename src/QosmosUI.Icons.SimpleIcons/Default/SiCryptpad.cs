// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiCryptpad : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 24 24";

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
		builder.OpenElement(13, "title");
		builder.CloseElement();
		builder.OpenElement(14, "path");
		builder.AddAttribute(15, "d", "m2.355 0 .008.717.153 12.23c.045 3.668 1.528 6.09 3.425 7.692 1.897 1.602 4.168 2.444 5.844 3.215l.317.146.308-.164c1.492-.788 3.779-1.625 5.72-3.209 1.943-1.584 3.515-3.997 3.515-7.69V5.97L15.22 0Zm9.729 1.416h1.604v6.016h6.542v3.879H15.4c-.055 1.091-.59 1.926-1.256 2.484l.938 4.97h-2.994v3.655l-.018.008c-1.691-.764-3.651-1.55-5.215-2.87-1.653-1.396-2.884-3.32-2.925-6.628l-.02-1.62h4.674c-.003-.054-.006-.108-.006-.164a3.424 3.424 0 0 1 3.41-3.41l.096.002zm3.02.408 4.513 4.194h-4.513zm-3.112 6.91a2.412 2.412 0 0 0-1.043 4.586l-.844 4.448h3.772l-.842-4.448a2.412 2.412 0 0 0-1.043-4.586z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
