// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Themify.Default;

public class TfiDribbble : ComponentBase
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
		builder.AddAttribute(15, "d", "M8.5 0c-4.694 0-8.5 3.806-8.5 8.5s3.806 8.5 8.5 8.5 8.5-3.806 8.5-8.5-3.806-8.5-8.5-8.5zM15.994 8.621c-2.075-0.456-3.896-0.423-5.469-0.092-0.251-0.627-0.536-1.273-0.849-1.93 1.681-0.648 3.292-1.586 4.548-2.934 1.106 1.308 1.776 2.994 1.776 4.835 0 0.041-0.006 0.080-0.006 0.121zM13.523 2.947c-1.16 1.257-2.688 2.135-4.297 2.74-0.76-1.468-1.69-2.96-2.814-4.385 0.664-0.193 1.363-0.302 2.088-0.302 1.934 0 3.692 0.742 5.023 1.947zM5.43 1.665c1.133 1.397 2.062 2.884 2.828 4.353-2.974 0.92-5.966 1.028-7.114 1.030 0.474-2.407 2.104-4.4 4.286-5.383zM1 8.5c0-0.151 0.014-0.3 0.022-0.449 0.065 0.001 0.134 0.001 0.212 0.001 1.306 0 4.402-0.125 7.482-1.114 0.3 0.625 0.578 1.245 0.82 1.844-3.605 1.101-5.736 3.705-6.513 4.826-1.251-1.34-2.023-3.133-2.023-5.108zM3.758 14.304c0.596-0.901 2.601-3.518 6.145-4.57 0.961 2.598 1.405 4.744 1.566 5.651-0.911 0.394-1.914 0.615-2.969 0.615-1.798 0-3.449-0.637-4.742-1.696zM12.4 14.894c-0.198-1.063-0.636-3.042-1.503-5.405 1.444-0.28 3.109-0.288 5.008 0.145-0.341 2.226-1.658 4.129-3.505 5.26z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
