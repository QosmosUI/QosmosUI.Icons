// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundSick : ComponentBase
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
		builder.AddAttribute(18, "d", "M23,7c0,1.1-0.9,2-2,2s-2-0.9-2-2c0-0.78,0.99-2.44,1.58-3.36c0.2-0.31,0.64-0.31,0.84,0C22.01,4.56,23,6.22,23,7z M21.86,10.38C21.94,10.91,22,11.45,22,12c0,5.52-4.48,10-10.01,10C6.47,22,2,17.52,2,12C2,6.48,6.47,2,11.99,2 c2.45,0,4.69,0.88,6.43,2.34C17.91,5.29,17.5,6.27,17.5,7c0,1.93,1.57,3.5,3.5,3.5C21.3,10.5,21.58,10.45,21.86,10.38z M14.03,10.03 l1.06,1.06c0.29,0.29,0.77,0.29,1.06,0c0.29-0.29,0.29-0.77,0-1.06L15.62,9.5l0.53-0.53c0.29-0.29,0.29-0.77,0-1.06 s-0.77-0.29-1.06,0l-1.06,1.06C13.74,9.26,13.74,9.74,14.03,10.03z M8.38,9.5l-0.53,0.53c-0.29,0.29-0.29,0.77,0,1.06 c0.29,0.29,0.77,0.29,1.06,0l1.06-1.06c0.29-0.29,0.29-0.77,0-1.06L8.91,7.91c-0.29-0.29-0.77-0.29-1.06,0s-0.29,0.77,0,1.06 L8.38,9.5z M16.47,15.8c-1-1.39-2.62-2.3-4.47-2.3c-0.87,0-1.69,0.2-2.43,0.56L5.99,12c0-0.52-0.26-1.02-0.74-1.29 c-0.8-0.46-1.84-0.11-2.17,0.8c-0.21,0.57-0.03,1.25,0.44,1.64c0.52,0.44,1.2,0.45,1.72,0.16l2.97,1.72 c-0.25,0.24-0.48,0.5-0.68,0.78C7.17,16.3,7.53,17,8.15,17c0.23,0,0.46-0.1,0.6-0.3C9.47,15.68,10.65,15,12,15s2.53,0.68,3.25,1.7 c0.14,0.19,0.36,0.3,0.6,0.3h0C16.47,17,16.83,16.3,16.47,15.8z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
