// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundLocationDisabled : ComponentBase
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
		builder.OpenElement(13, "path");
		builder.AddAttribute(14, "d", "M0 0h24v24H0V0z");
		builder.AddAttribute(15, "fill", "none");
		builder.CloseElement();
		builder.OpenElement(16, "path");
		builder.AddAttribute(17, "d", "M22 13c.55 0 1-.45 1-1s-.45-1-1-1h-1.06c-.46-4.17-3.77-7.48-7.94-7.94V2c0-.55-.45-1-1-1s-1 .45-1 1v1.06c-.98.11-1.91.38-2.77.78l1.53 1.53C10.46 5.13 11.22 5 12 5c3.87 0 7 3.13 7 7 0 .79-.13 1.54-.37 2.24l1.53 1.53c.4-.86.67-1.79.78-2.77H22zm-1.56 5.88L5.12 3.56c-.39-.39-1.02-.39-1.41 0-.39.39-.39 1.02 0 1.41L5.04 6.3C3.97 7.62 3.26 9.23 3.06 11H2c-.55 0-1 .45-1 1s.45 1 1 1h1.06c.46 4.17 3.77 7.48 7.94 7.94V22c0 .55.45 1 1 1s1-.45 1-1v-1.06c1.77-.2 3.38-.91 4.69-1.98l1.33 1.33c.39.39 1.02.39 1.41 0 .4-.39.4-1.02.01-1.41zM12 19c-3.87 0-7-3.13-7-7 0-1.61.55-3.09 1.46-4.27l9.81 9.81C15.09 18.45 13.61 19 12 19z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
