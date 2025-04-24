// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Typicons.Default;

public class TiGlobeOutline : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "24";

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
		builder.OpenElement(13, "path");
		builder.AddAttribute(14, "d", "M11 6c2.206 0 4 1.794 4 4s-1.794 4-4 4c-2.204 0-3.998-1.794-3.998-4s1.794-4 3.998-4m0-2c-3.314 0-5.998 2.686-5.998 6s2.684 6 5.998 6c3.312 0 6-2.688 6-6 0-3.314-2.688-6-6-6zM17 20h-4v-1.23c1.641-.371 3.146-1.188 4.363-2.406 1.699-1.699 2.637-3.96 2.637-6.363 0-2.067-.691-4.028-1.968-5.619l.675-.673c.391-.391.391-1.023.001-1.415-.392-.392-1.024-.39-1.415-.001l-2.052 2.049.708.708c1.322 1.321 2.051 3.08 2.051 4.95s-.729 3.627-2.051 4.949-3.079 2.051-4.949 2.051-3.627-.729-4.949-2.051c-.391-.391-1.023-.391-1.414 0-.391.39-.391 1.023 0 1.414 1.699 1.699 3.959 2.637 6.363 2.637v1h-4c-.553 0-1 .447-1 1s.447 1 1 1h10c.553 0 1-.447 1-1s-.447-1-1-1z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
