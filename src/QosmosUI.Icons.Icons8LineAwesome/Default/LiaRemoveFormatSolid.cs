// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome.Default;

public class LiaRemoveFormatSolid : ComponentBase
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
		builder.AddAttribute(14, "d", "M 4.2890625 5.9726562 L 3.0839844 7.5703125 L 27.777344 26.177734 L 28.980469 24.580078 L 18.027344 16.326172 L 20.285156 10 L 25 10 L 25 11.5 C 25 11.776 25.224 12 25.5 12 L 26.5 12 C 26.776 12 27 11.776 27 11.5 L 27 7.5 C 27 7.224 26.776 7 26.5 7 L 10.5 7 C 10.224 7 10 7.224 10 7.5 L 10 10.277344 L 4.2890625 5.9726562 z M 12 10 L 17.285156 10 L 15.662109 14.544922 L 11.933594 11.734375 C 11.972056 11.663558 12 11.586203 12 11.5 L 12 10 z M 14.253906 18.490234 L 13 22 L 11.5 22 C 11.224 22 11 22.224 11 22.5 L 11 24.5 C 11 24.776 11.224 25 11.5 25 L 16.5 25 C 16.776 25 17 24.776 17 24.5 L 17 22.5 C 17 22.224 16.776 22 16.5 22 L 16 22 L 16.619141 20.265625 L 14.253906 18.490234 z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
