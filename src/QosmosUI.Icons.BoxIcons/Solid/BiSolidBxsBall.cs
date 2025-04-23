// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.BoxIcons.Solid;

public class BiSolidBxsBall : ComponentBase
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
		builder.AddAttribute(14, "d", "M20.247 3.034c-.069-.018-1.742-.433-4.052-.433-2.842 0-6.868.64-9.91 3.687-5.34 5.349-3.34 13.61-3.252 13.96a1 1 0 0 0 .728.726c.069.018 1.726.426 4.018.426 2.849 0 6.884-.641 9.932-3.688 5.335-5.335 3.351-13.6 3.264-13.949a1.005 1.005 0 0 0-.728-.729zm-3.537 9.262-1.414 1.414-1.793-1.792-1.586 1.586 1.792 1.793-1.414 1.414-1.792-1.793-1.793 1.793-1.414-1.414 1.793-1.793-1.793-1.794 1.414-1.414 1.793 1.794 1.586-1.586-1.794-1.793 1.414-1.414 1.794 1.793 1.793-1.793 1.414 1.414-1.793 1.793 1.793 1.792z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
