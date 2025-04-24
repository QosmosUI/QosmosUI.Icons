// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome.Default;

public class LiaBrailleSolid : ComponentBase
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
		builder.AddAttribute(14, "d", "M 12 6 C 10.894531 6 10 6.894531 10 8 C 10 9.105469 10.894531 10 12 10 C 13.105469 10 14 9.105469 14 8 C 14 6.894531 13.105469 6 12 6 Z M 20 6 C 18.894531 6 18 6.894531 18 8 C 18 9.105469 18.894531 10 20 10 C 21.105469 10 22 9.105469 22 8 C 22 6.894531 21.105469 6 20 6 Z M 12 14 C 10.894531 14 10 14.894531 10 16 C 10 17.105469 10.894531 18 12 18 C 13.105469 18 14 17.105469 14 16 C 14 14.894531 13.105469 14 12 14 Z M 20 14 C 18.894531 14 18 14.894531 18 16 C 18 17.105469 18.894531 18 20 18 C 21.105469 18 22 17.105469 22 16 C 22 14.894531 21.105469 14 20 14 Z M 12 22 C 10.894531 22 10 22.894531 10 24 C 10 25.105469 10.894531 26 12 26 C 13.105469 26 14 25.105469 14 24 C 14 22.894531 13.105469 22 12 22 Z M 20 22 C 18.894531 22 18 22.894531 18 24 C 18 25.105469 18.894531 26 20 26 C 21.105469 26 22 25.105469 22 24 C 22 22.894531 21.105469 22 20 22 Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
