// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Devicons;

public class DiIonic : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "27";

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
    public string ViewBox { get; set; } = "0 0 27 32";

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
		builder.AddAttribute(14, "d", "M20.873 10.726c0.198-0.228 0.319-0.525 0.319-0.85 0-0.717-0.582-1.299-1.299-1.299-0.325 0-0.622 0.12-0.85 0.318-1.549-1.168-3.475-1.861-5.559-1.861-5.101 0-9.252 4.15-9.252 9.252s4.15 9.252 9.252 9.252 9.251-4.15 9.251-9.252c0-2.085-0.693-4.011-1.861-5.559zM13.483 25.226c-4.93 0-8.94-4.011-8.94-8.94s4.011-8.94 8.94-8.94c2.004 0 3.857 0.663 5.349 1.781-0.15 0.212-0.239 0.47-0.239 0.749 0 0.717 0.582 1.299 1.299 1.299 0.279 0 0.537-0.089 0.749-0.239 1.118 1.493 1.781 3.345 1.781 5.35 0 4.93-4.010 8.94-8.94 8.94zM17.26 16.285c0 2.086-1.691 3.777-3.777 3.777s-3.777-1.691-3.777-3.777c0-2.086 1.691-3.777 3.777-3.777s3.777 1.691 3.777 3.777z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
