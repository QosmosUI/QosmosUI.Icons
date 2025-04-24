// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome.Default;

public class LiaUnlockAltSolid : ComponentBase
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
		builder.AddAttribute(14, "d", "M 16 3 C 12.964844 3 10.414063 4.964844 9.375 7.625 L 11.21875 8.375 C 11.976563 6.433594 13.835938 5 16 5 C 18.753906 5 21 7.246094 21 10 L 21 11.375 C 19.523438 10.515625 17.824219 10 16 10 C 10.488281 10 6 14.488281 6 20 C 6 25.511719 10.488281 30 16 30 C 21.511719 30 26 25.511719 26 20 C 26 17.214844 24.847656 14.691406 23 12.875 L 23 10 C 23 6.15625 19.84375 3 16 3 Z M 16 12 C 20.429688 12 24 15.570313 24 20 C 24 24.429688 20.429688 28 16 28 C 11.570313 28 8 24.429688 8 20 C 8 15.570313 11.570313 12 16 12 Z M 16 18 C 14.894531 18 14 18.894531 14 20 C 14 20.738281 14.402344 21.371094 15 21.71875 L 15 25 L 17 25 L 17 21.71875 C 17.597656 21.371094 18 20.738281 18 20 C 18 18.894531 17.105469 18 16 18 Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
