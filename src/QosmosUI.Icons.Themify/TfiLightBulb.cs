// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Themify;

public class TfiLightBulb : ComponentBase
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
		builder.AddAttribute(15, "d", "M8.5 0c-3.032 0-5.5 2.617-5.5 5.833 0 2.354 0.964 3.67 1.814 4.831 0.637 0.868 1.186 1.618 1.186 2.673v2.096c0 0.864 0.673 1.567 1.5 1.567h2c0.827 0 1.5-0.703 1.5-1.567v-2.126c0-1.045 0.517-1.735 1.17-2.609 0.815-1.091 1.83-2.447 1.83-4.865 0-3.216-2.468-5.833-5.5-5.833zM9.5 16h-2c-0.275 0-0.5-0.254-0.5-0.567v-1.633h3v1.633c0 0.313-0.225 0.567-0.5 0.567zM11.369 10.099c-0.587 0.785-1.19 1.593-1.336 2.701h-3.072c-0.152-1.102-0.754-1.927-1.34-2.727-0.797-1.088-1.621-2.213-1.621-4.24 0-2.665 2.019-4.833 4.5-4.833s4.5 2.168 4.5 4.833c0 2.085-0.829 3.194-1.631 4.266z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
