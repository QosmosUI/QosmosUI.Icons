// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiWoodenChair : ComponentBase
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
		builder.AddAttribute(14, "d", "M256 27.12c-44.3 0-88.4 3.36-119 9.99v63.79h238V37.11c-30.6-6.63-74.7-9.99-119-9.99zm-91.6 91.78l15.8 132c5.8-.3 11.8-.6 18-.9l-15.7-131.1zm82.5 0l-1.6 130h18l1.6-130zm82.6 0L313.8 250c6.2.3 12.2.6 18 .9l15.8-132zm-73.5 148c-31.8 0-63.6 1-89.3 3-12.8 1-24.1 2.2-33 3.6-5.4.9-9.5 1.9-12.7 2.8v32.6h270v-32.6c-3.2-.9-7.3-1.9-12.7-2.8-8.9-1.4-20.2-2.6-33-3.6-25.7-2-57.5-3-89.3-3zm-103 60v158h30v-158zm176 0v158h30v-158zm-128 64v16h110v-16z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
