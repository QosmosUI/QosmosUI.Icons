// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiIced : ComponentBase
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
		builder.OpenElement(13, "title");
		builder.CloseElement();
		builder.OpenElement(14, "path");
		builder.AddAttribute(15, "d", "m22.605 0-6.023 6.123 1.313 1.291 6.023-6.123L22.605 0zm-5.638.047L7.932 9.232l1.312 1.29 9.035-9.184L16.967.047zM9.699 1.775c-2.337 2.377-3.477 3.528-4.617 4.68a1972.17 1972.17 0 0 0-4.621 4.686l-.379.384 2.867 9.772L12.762 24l10.511-10.5-1.3-1.3-9.02 9.007-1.908-6.83 5.559-5.65-1.311-1.291-5.559 5.65-6.845-1.79C4.506 9.655 5.449 8.703 6.39 7.75c1.14-1.153 2.282-2.305 4.62-4.684L9.7 1.776zM21.605 6.73l-1.53 1.53-6.458 6.565 1.313 1.291 6.45-6.558 1.528-1.528-1.303-1.3zM2.46 13.088l6.812 1.781 1.895 6.783-6.738-1.857-1.969-6.707z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
