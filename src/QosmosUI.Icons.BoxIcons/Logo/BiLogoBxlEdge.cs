// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.BoxIcons.Logo;

public class BiLogoBxlEdge : ComponentBase
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
		builder.AddAttribute(14, "d", "M20.349 13.684H8.874c0 .433.063.825.195 1.178a3.334 3.334 0 0 0 1.381 1.634c.309.196.646.359 1.005.484.356.13.729.226 1.107.288.821.13 1.658.123 2.477-.021a9.79 9.79 0 0 0 2.421-.783c.393-.18.79-.376 1.201-.594v3.805a13.453 13.453 0 0 1-2.711.978c-.457.112-.92.196-1.396.246-.486.054-.975.079-1.464.079a8.185 8.185 0 0 1-1.95-.232 7.679 7.679 0 0 1-1.762-.668 7.29 7.29 0 0 1-1.51-1.062 6.67 6.67 0 0 1-1.941-3.103 6.978 6.978 0 0 1-.267-1.953c0-.737.101-1.439.303-2.11a6.718 6.718 0 0 1 2.264-3.342 7.38 7.38 0 0 1 1.847-1.066 3.891 3.891 0 0 0-.869 1.329 5.682 5.682 0 0 0-.401 1.538h6.391c0-.646-.063-1.207-.196-1.689-.131-.484-.342-.885-.637-1.201A2.64 2.64 0 0 0 13.23 6.7c-.462-.16-1.021-.241-1.675-.241-.771 0-1.543.111-2.314.344a9.804 9.804 0 0 0-2.2.955c-.695.412-1.335.897-1.919 1.452a9.167 9.167 0 0 0-1.474 1.819c.084-.742.247-1.474.485-2.18a9.304 9.304 0 0 1 .912-1.938 8.622 8.622 0 0 1 1.303-1.609 7.735 7.735 0 0 1 1.655-1.235 8.45 8.45 0 0 1 1.955-.792 10.042 10.042 0 0 1 2.233-.254c.46 0 .917.041 1.375.124.457.084.903.196 1.339.342a8.012 8.012 0 0 1 2.315 1.239 7.95 7.95 0 0 1 1.711 1.833c.463.692.813 1.459 1.055 2.292s.365 1.701.365 2.602v2.23h-.002z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
