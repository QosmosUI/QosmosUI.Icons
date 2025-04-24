// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome.Default;

public class LiaCrosshairsSolid : ComponentBase
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
		builder.AddAttribute(14, "d", "M 15 3 L 15 5.0625 C 9.734375 5.539063 5.539063 9.734375 5.0625 15 L 3 15 L 3 17 L 5.0625 17 C 5.539063 22.265625 9.734375 26.460938 15 26.9375 L 15 29 L 17 29 L 17 26.9375 C 22.265625 26.460938 26.460938 22.265625 26.9375 17 L 29 17 L 29 15 L 26.9375 15 C 26.460938 9.734375 22.265625 5.539063 17 5.0625 L 17 3 Z M 15 7.03125 L 15 9 L 17 9 L 17 7.03125 C 21.191406 7.484375 24.515625 10.808594 24.96875 15 L 23 15 L 23 17 L 24.96875 17 C 24.515625 21.191406 21.191406 24.515625 17 24.96875 L 17 23 L 15 23 L 15 24.96875 C 10.808594 24.515625 7.484375 21.191406 7.03125 17 L 9 17 L 9 15 L 7.03125 15 C 7.484375 10.808594 10.808594 7.484375 15 7.03125 Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
