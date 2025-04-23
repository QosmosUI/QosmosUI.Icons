// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Themify;

public class TfiPaintBucket : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "17";

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
    public string ViewBox { get; set; } = "0 0 17 17";

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
		builder.OpenElement(13, "g");
		builder.CloseElement();
		builder.OpenElement(14, "path");
		builder.AddAttribute(15, "d", "M16.701 9.818l-8.868-8.924-0.134 0.133c-0.668-0.661-1.552-1.026-2.493-1.027 0 0 0 0-0.001 0-0.948 0-1.841 0.37-2.512 1.041-0.672 0.671-1.042 1.563-1.042 2.514 0 0.941 0.366 1.825 1.027 2.493l-2.208 2.209c-0.303 0.304-0.47 0.706-0.47 1.133 0 0.429 0.166 0.83 0.467 1.13l4.811 4.859c0.302 0.302 0.704 0.469 1.131 0.469 0.429 0 0.831-0.168 1.133-0.471l5.558-5.558 3.601-0.001zM2.651 3.554c0-0.682 0.266-1.323 0.749-1.806 0.483-0.482 1.123-0.748 1.805-0.748 0.001 0 0.001 0 0.001 0 0.674 0 1.306 0.262 1.786 0.734l-3.606 3.607c-0.473-0.481-0.735-1.113-0.735-1.787zM6.833 14.671c-0.113 0.113-0.265 0.177-0.425 0.177s-0.311-0.062-0.422-0.174l-3.636-3.674h8.154l-3.671 3.671zM11.504 10h-10.145l-0.183-0.186c-0.114-0.113-0.176-0.263-0.176-0.423 0-0.161 0.063-0.312 0.177-0.427l6.654-6.654 6.468 6.509-1.614 0.001-1.181 1.18zM15.688 11.959l-0.407-0.604-0.418 0.598c-0.319 0.457-1.363 2.011-1.363 2.798 0 0.965 0.785 1.75 1.75 1.75s1.75-0.786 1.75-1.751c0-0.782-1.004-2.334-1.312-2.791zM15.25 15.5c-0.413 0-0.75-0.337-0.75-0.75 0-0.24 0.349-0.92 0.766-1.591 0.4 0.67 0.734 1.349 0.734 1.591 0 0.413-0.337 0.75-0.75 0.75z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
