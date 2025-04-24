// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome.Default;

public class LiaThumbsDownSolid : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 32 32";

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
		builder.AddAttribute(14, "d", "M 10.15625 6 C 8.746094 6 7.515625 6.996094 7.21875 8.375 L 5.0625 18.375 C 4.667969 20.222656 6.113281 22 8 22 L 13.75 22 L 13.5625 22.75 C 13.359375 22.90625 13.230469 22.972656 12.9375 23.375 C 12.46875 24.015625 12 25.007813 12 26.34375 C 12 27.769531 13.289063 29 14.90625 29 L 15.3125 29 L 15.625 28.71875 L 22.40625 22 L 27 22 L 27 6 Z M 10.15625 8 L 21 8 L 21 20.59375 L 14.59375 26.90625 C 14.171875 26.824219 14 26.652344 14 26.34375 C 14 25.441406 14.273438 24.882813 14.53125 24.53125 C 14.789063 24.179688 14.96875 24.09375 14.96875 24.09375 L 15.3125 23.90625 L 15.4375 23.5 L 16.03125 21.25 L 16.34375 20 L 8 20 C 7.339844 20 6.894531 19.425781 7.03125 18.78125 L 9.15625 8.78125 C 9.257813 8.3125 9.679688 8 10.15625 8 Z M 23 8 L 25 8 L 25 20 L 23 20 Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
