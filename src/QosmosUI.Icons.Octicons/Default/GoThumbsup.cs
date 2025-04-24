// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Octicons.Default;

public class GoThumbsup : ComponentBase
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
		builder.AddAttribute(14, "d", "M13.349 2.378a.748.748 0 0 1 .808-.361l.127.027a3.875 3.875 0 0 1 2.879 4.97L16.527 9h1.137c2.645 0 4.513 2.591 3.676 5.1l-1.559 4.678A3.25 3.25 0 0 1 16.698 21h-5.289a4.503 4.503 0 0 1-2.828-.999A1.75 1.75 0 0 1 7 21H4.75A1.75 1.75 0 0 1 3 19.25v-8.5C3 9.784 3.784 9 4.75 9h4.67a.251.251 0 0 0 .217-.126l3.712-6.496ZM8.75 18.16l.683.598a3.003 3.003 0 0 0 1.976.742h5.289a1.75 1.75 0 0 0 1.66-1.197l1.559-4.677a2.375 2.375 0 0 0-2.253-3.126H15.5a.75.75 0 0 1-.714-.979l.948-2.964a2.375 2.375 0 0 0-1.373-2.927l-3.422 5.988a1.749 1.749 0 0 1-1.519.882h-.67v7.66Zm-1.5-7.66h-2.5a.25.25 0 0 0-.25.25v8.5c0 .138.112.25.25.25H7a.25.25 0 0 0 .25-.25V10.5Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
