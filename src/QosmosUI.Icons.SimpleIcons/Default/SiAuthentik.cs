// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiAuthentik : ComponentBase
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
		builder.AddAttribute(15, "d", "M13.96 9.01h-.84V7.492h-1.234v3.663H5.722c.34.517.538.982.538 1.152 0 .46-1.445 3.059-3.197 3.059C.8 15.427-.745 12.8.372 10.855a3.062 3.062 0 0 1 2.691-1.606c1.04 0 1.971.915 2.557 1.755V6.577a3.773 3.773 0 0 1 3.77-3.769h10.84C22.31 2.808 24 4.5 24 6.577v10.845a3.773 3.773 0 0 1-3.77 3.769h-1.6V17.5h-7.64v3.692h-1.6a3.773 3.773 0 0 1-3.77-3.769v-3.41h12.114v-6.52h-1.59v.893h-.84v-.893H13.96v1.516Zm-9.956 1.845c-.662-.703-1.578-.544-2.209 0-2.105 2.054 1.338 5.553 3.302 1.447a5.395 5.395 0 0 0-1.093-1.447Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
