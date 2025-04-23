// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiAmericanShield : ComponentBase
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
		builder.AddAttribute(14, "d", "M256 32A224 224 0 0 0 32 256a224 224 0 0 0 224 224 224 224 0 0 0 224-224A224 224 0 0 0 256 32zm0 40a184 184 0 0 1 184 184 184 184 0 0 1-184 184A184 184 0 0 1 72 256 184 184 0 0 1 256 72zm0 48a136 136 0 0 0-136 136 136 136 0 0 0 136 136 136 136 0 0 0 136-136 136 136 0 0 0-136-136zm-.994 47.834c9.848-.197 19.708 1.524 29.002 4.752 26.805 8.13 47.273 30.513 55.82 56.678l-63.05-1.285L256 168.202l-20.777 59.776-63.27 1.288L222.38 267.5l-18.02 59.563c-20.54-15.486-34.84-39.655-36.673-65.24-4.02-48.442 39.505-94.682 87.32-93.99zm84.87 61.564c3.95 12.16 5.334 25.13 3.57 37.866-2.29 24.324-16.34 45.71-35.82 59.754L289.618 267.5l50.255-38.102zM256 291.926l51.04 35.515c-15.884 11.27-35.293 17.685-54.886 16.857-17.256-.38-33.59-6.7-47.234-16.826L256 291.927z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
