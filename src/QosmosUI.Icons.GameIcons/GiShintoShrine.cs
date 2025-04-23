// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiShintoShrine : ComponentBase
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
		builder.AddAttribute(14, "d", "M25 43.637v13.447c166.014 44.44 287.965 45.322 452.29 2.586l4.93-14.79C317.103 87.802 190.876 87.396 25 43.636zm7.965 34.168l20.83 41.66c169.675 15.31 234.248 15.327 403.537.074l13.19-39.575c-156.893 39.28-279.4 38.56-437.557-2.16zM247.027 137l-11.5 46h40.946l-11.5-46h-17.946zM89 140.623V361H48v-41h16l-24-16-24 16h16v41h-7v14h7v71.14h-7v14h7V496h16v-35.86h41V487h46v-26.86h41V496h16v-35.86h7v-14h-7V375h7v-14h-7v-41h16l-24-16-24 16h16v41h-41V144.207c-14.517-1.026-29.803-2.226-46-3.584zm334 0c-16.197 1.358-31.483 2.558-46 3.584V361h-41v-41h16l-24-16-24 16h16v41h-7v14h7v71.14h-7v14h7V496h16v-35.86h41V487h46v-26.86h41V496h16v-35.86h7v-14h-7V375h7v-14h-7v-41h16l-24-16-24 16h16v41h-41V140.623zM44.486 185l10 30H71v-30H44.486zM153 185v30h206v-30h-63.473l4 16h-87.054l4-16H153zm288 0v30h16.514l10-30H441zM48 375h41v71.14H48V375zm87 0h41v71.14h-41V375zm201 0h41v71.14h-41V375zm87 0h41v71.14h-41V375z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
