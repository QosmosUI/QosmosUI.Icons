// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundHouseboat : ComponentBase
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
		builder.OpenElement(13, "rect");
		builder.AddAttribute(14, "fill", "none");
		builder.AddAttribute(15, "height", "24");
		builder.AddAttribute(16, "width", "24");
		builder.CloseElement();
		builder.OpenElement(17, "path");
		builder.AddAttribute(18, "d", "M22,17.83c0-0.42-0.27-0.8-0.67-0.94C20.62,16.62,20.21,16,18.67,16c-1.91,0-2.14,1-3.33,1c-1.24,0-1.39-1-3.34-1 s-2.1,1-3.34,1c-1.19,0-1.42-1-3.33-1c-1.54,0-1.95,0.62-2.66,0.88C2.27,17.03,2,17.4,2,17.83c0,0.7,0.69,1.19,1.35,0.95 c0.8-0.29,1.18-0.78,2-0.78c1.19,0,1.42,1,3.33,1c1.95,0,2.08-1,3.32-1s1.37,1,3.32,1c1.91,0,2.14-1,3.33-1c0.83,0,1.21,0.49,2,0.78 C21.31,19.02,22,18.52,22,17.83z M18.91,9.81c0.33-0.45,0.23-1.07-0.22-1.4l-6.1-4.47c-0.35-0.26-0.83-0.26-1.18,0l-6.1,4.47 c-0.45,0.33-0.54,0.95-0.22,1.4c0.33,0.45,0.95,0.54,1.4,0.22L7,9.65V13H5.74c-0.27,0-0.52-0.11-0.71-0.29l-0.66-0.66 c-0.39-0.39-1.02-0.39-1.41,0c-0.39,0.39-0.39,1.02,0,1.41l0.66,0.66C4.18,14.68,4.95,15,5.74,15h12.51c0.8,0,1.56-0.32,2.12-0.88 l0.66-0.66c0.39-0.39,0.39-1.02,0-1.41c-0.39-0.39-1.02-0.39-1.41,0l-0.66,0.66C18.78,12.89,18.52,13,18.26,13H17V9.65l0.51,0.37 C17.96,10.35,18.58,10.25,18.91,9.81z M13,13h-2v-2h2V13z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
