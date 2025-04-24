// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.IcoMoonFree.Default;

public class ImTumblr : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "16";

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
    public string ViewBox { get; set; } = "0 0 16 16";

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
		builder.AddAttribute(14, "d", "M9.001 7l-0 3.659c0 0.928-0.012 1.463 0.086 1.727 0.098 0.262 0.342 0.534 0.609 0.691 0.354 0.212 0.758 0.318 1.214 0.318 0.81 0 1.289-0.107 2.090-0.633v2.405c-0.683 0.321-1.279 0.509-1.833 0.639-0.555 0.129-1.154 0.194-1.798 0.194-0.732 0-1.163-0.092-1.725-0.276-0.562-0.185-1.042-0.45-1.438-0.79-0.398-0.343-0.672-0.706-0.826-1.091s-0.23-0.944-0.23-1.676v-5.611h-2.147v-2.266c0.628-0.204 1.331-0.497 1.778-0.877 0.449-0.382 0.809-0.839 1.080-1.374 0.272-0.534 0.459-1.214 0.561-2.039h2.579l-0 4h3.999v3h-3.999z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
