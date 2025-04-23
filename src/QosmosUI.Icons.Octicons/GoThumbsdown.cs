// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Octicons;

public class GoThumbsdown : ComponentBase
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
		builder.AddAttribute(14, "d", "M10.651 21.622a.748.748 0 0 1-.808.361l-.127-.027a3.875 3.875 0 0 1-2.879-4.97L7.473 15H6.336c-2.645 0-4.513-2.591-3.676-5.1l1.559-4.678A3.25 3.25 0 0 1 7.302 3h5.289c1.031 0 2.029.354 2.828.999A1.75 1.75 0 0 1 17 3h2.25c.966 0 1.75.784 1.75 1.75v8.5A1.75 1.75 0 0 1 19.25 15h-4.67a.251.251 0 0 0-.217.126l-3.712 6.496ZM15.25 5.84l-.684-.598a2.999 2.999 0 0 0-1.975-.742H7.302a1.75 1.75 0 0 0-1.66 1.197l-1.559 4.677A2.375 2.375 0 0 0 6.336 13.5H8.5a.75.75 0 0 1 .714.979l-.948 2.964a2.375 2.375 0 0 0 1.373 2.927l3.422-5.988a1.749 1.749 0 0 1 1.519-.882h.67V5.84Zm1.5 7.66h2.5a.25.25 0 0 0 .25-.25v-8.5a.25.25 0 0 0-.25-.25H17a.25.25 0 0 0-.25.25v8.75Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
