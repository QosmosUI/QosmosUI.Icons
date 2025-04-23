// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons;

public class SiAppsignal : ComponentBase
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
		builder.AddAttribute(15, "d", "M21.003 7.328c-1.781 0-3.055 1.57-4.368 3.318-.815-3.714-1.72-7.424-4.601-7.424-2.881 0-3.789 3.71-4.617 7.427-1.31-1.752-2.584-3.32-4.365-3.32C1.918 7.329 0 8.098 0 10.986v5.24c0 2.832 1.512 3.527 2.42 3.766 1.565.406 5.334.786 9.578.786s8.013-.38 9.579-.786c.907-.24 2.423-.934 2.423-3.766v-5.24c0-2.888-1.92-3.658-3.052-3.658m-8.914-2.469c1.726 0 2.384 3.406 3.3 7.493-1.004 1.238-2.072 2.236-3.3 2.236-1.228 0-2.292-.998-3.3-2.236.857-3.822 1.519-7.493 3.3-7.493M1.664 16.242v-5.24c0-1.823.981-2.02 1.414-2.02 1.257 0 2.62 2.096 3.893 3.78-.91 3.818-1.873 6.143-4.145 5.664-.593-.16-1.15-.537-1.15-2.167m4.46 2.655c1.006-1.093 1.638-2.8 2.139-4.607 1.05 1.103 2.266 1.935 3.772 1.935 1.506 0 2.718-.832 3.773-1.935.488 1.807 1.13 3.514 2.135 4.607a67.507 67.507 0 0 1-11.806 0m16.282-2.655c0 1.637-.556 2.007-1.15 2.167-2.275.482-3.235-1.846-4.145-5.665 1.287-1.683 2.62-3.779 3.894-3.779.425 0 1.414.197 1.414 2.02z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
