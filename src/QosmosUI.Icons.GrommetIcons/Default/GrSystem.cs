// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GrommetIcons.Default;

public class GrSystem : ComponentBase
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
		builder.AddAttribute(14, "fill", "none");
		builder.AddAttribute(15, "stroke-width", "2");
		builder.AddAttribute(16, "d", "M1,19 L23,19 L23,1 L1,1 L1,19 Z M5,23 L19,23 L5,23 Z M8,23 L16,23 L16,19 L8,19 L8,23 Z M7.757,5.757 L9.879,7.879 L7.757,5.757 Z M9,10 L6,10 L9,10 Z M9.879,12.121 L7.757,14.243 L9.879,12.121 Z M12,13 L12,16 L12,13 Z M14.121,12.121 L16.243,14.243 L14.121,12.121 Z M18,10 L15,10 L18,10 Z M16.243,5.757 L14.121,7.879 L16.243,5.757 Z M12,7 L12,4 L12,7 Z M12,7 C10.343,7 9,8.343 9,10 C9,11.657 10.343,13 12,13 C13.657,13 15,11.657 15,10 C15,8.343 13.657,7 12,7 L12,7 Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
