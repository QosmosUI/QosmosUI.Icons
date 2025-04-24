// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome.Default;

public class LiaThumbtackSolid : ComponentBase
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
		builder.AddAttribute(14, "d", "M 20.53125 2.5625 L 19.84375 3.5 L 14.9375 10.1875 C 12.308594 9.730469 9.527344 10.472656 7.5 12.5 L 6.78125 13.1875 L 12.09375 18.5 L 4 26.59375 L 4 28 L 5.40625 28 L 13.5 19.90625 L 18.8125 25.21875 L 19.5 24.5 C 21.527344 22.472656 22.269531 19.691406 21.8125 17.0625 L 28.5 12.15625 L 29.4375 11.46875 Z M 20.78125 5.625 L 26.375 11.21875 L 20.15625 15.78125 L 19.59375 16.1875 L 19.78125 16.84375 C 20.261719 18.675781 19.738281 20.585938 18.59375 22.1875 L 9.8125 13.40625 C 11.414063 12.261719 13.324219 11.738281 15.15625 12.21875 L 15.8125 12.40625 L 16.21875 11.84375 Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
