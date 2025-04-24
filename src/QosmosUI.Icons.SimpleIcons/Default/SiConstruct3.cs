// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiConstruct3 : ComponentBase
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
		builder.AddAttribute(15, "d", "M12.392 0c-6.752 0-12 5.498-12 12 0 6.574 5.313 12 12 12 4.283 0 8.087-2.254 10.217-5.704a.571.571 0 0 0-.2-.795l-5.55-3.204a.572.572 0 0 0-.76.177 4.453 4.453 0 0 1-3.707 1.983c-2.458 0-4.458-2-4.458-4.457 0-2.458 2-4.457 4.458-4.457 1.491 0 2.877.741 3.707 1.983a.571.571 0 0 0 .76.177l5.55-3.204a.571.571 0 0 0 .2-.795A11.998 11.998 0 0 0 12.392 0zm0 3.527c3.048 0 5.72 1.61 7.213 4.026l-2.99 1.726c-.037.021-.085.013-.108-.026a4.942 4.942 0 0 0-4.115-2.2A4.953 4.953 0 0 0 7.445 12c0 .9.241 1.745.663 2.473l-2.342 1.353a.327.327 0 0 0-.112.458 7.977 7.977 0 0 0 6.738 3.7 7.978 7.978 0 0 0 6.789-3.781l2.983 1.722a.08.08 0 0 1 .028.113 11.447 11.447 0 0 1-9.8 5.472C6.045 23.51.882 18.346.882 12c0-2.095.562-4.06 1.544-5.754l2.35 1.356c.15.088.345.04.439-.11a8.467 8.467 0 0 1 7.177-3.966zM22.965 8.95a.666.666 0 0 0-.336.088l-4.149 2.395a.654.654 0 0 0 0 1.131l4.149 2.396c.434.25.98-.064.98-.566v-4.79a.655.655 0 0 0-.644-.654zm-.663 1.785v2.528L20.112 12z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
