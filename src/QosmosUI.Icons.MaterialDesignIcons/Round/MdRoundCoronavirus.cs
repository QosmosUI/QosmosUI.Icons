// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundCoronavirus : ComponentBase
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
		builder.AddAttribute(18, "d", "M21.25,10.5c-0.41,0-0.75,0.34-0.75,0.75h-1.54c-0.15-1.37-0.69-2.63-1.52-3.65l1.09-1.09l0.01,0.01 c0.29,0.29,0.77,0.29,1.06,0s0.29-0.77,0-1.06L18.54,4.4c-0.29-0.29-0.77-0.29-1.06,0c-0.29,0.29-0.29,0.76-0.01,1.05l-1.09,1.09 c-1.02-0.82-2.27-1.36-3.64-1.51V3.5h0.01c0.41,0,0.75-0.34,0.75-0.75C13.5,2.34,13.16,2,12.75,2h-1.5c-0.41,0-0.75,0.34-0.75,0.75 c0,0.41,0.33,0.74,0.74,0.75v1.55C9.87,5.19,8.62,5.74,7.6,6.56L6.51,5.47l0.01-0.01c0.29-0.29,0.29-0.77,0-1.06 c-0.29-0.29-0.77-0.29-1.06,0L4.4,5.46c-0.29,0.29-0.29,0.77,0,1.06c0.29,0.29,0.76,0.29,1.05,0.01l1.09,1.09 c-0.82,1.02-1.36,2.26-1.5,3.63H3.5c0-0.41-0.34-0.75-0.75-0.75C2.34,10.5,2,10.84,2,11.25v1.5c0,0.41,0.34,0.75,0.75,0.75 c0.41,0,0.75-0.34,0.75-0.75h1.54c0.15,1.37,0.69,2.61,1.5,3.63l-1.09,1.09c-0.29-0.29-0.76-0.28-1.05,0.01 c-0.29,0.29-0.29,0.77,0,1.06l1.06,1.06c0.29,0.29,0.77,0.29,1.06,0c0.29-0.29,0.29-0.77,0-1.06l-0.01-0.01l1.09-1.09 c1.02,0.82,2.26,1.36,3.63,1.51v1.55c-0.41,0.01-0.74,0.34-0.74,0.75c0,0.41,0.34,0.75,0.75,0.75h1.5c0.41,0,0.75-0.34,0.75-0.75 c0-0.41-0.34-0.75-0.75-0.75h-0.01v-1.54c1.37-0.14,2.62-0.69,3.64-1.51l1.09,1.09c-0.29,0.29-0.28,0.76,0.01,1.05 c0.29,0.29,0.77,0.29,1.06,0l1.06-1.06c0.29-0.29,0.29-0.77,0-1.06c-0.29-0.29-0.77-0.29-1.06,0l-0.01,0.01l-1.09-1.09 c0.82-1.02,1.37-2.27,1.52-3.65h1.54c0,0.41,0.34,0.75,0.75,0.75c0.41,0,0.75-0.34,0.75-0.75v-1.5C22,10.84,21.66,10.5,21.25,10.5z M13.75,8c0.55,0,1,0.45,1,1s-0.45,1-1,1s-1-0.45-1-1S13.2,8,13.75,8z M12,13c-0.55,0-1-0.45-1-1c0-0.55,0.45-1,1-1s1,0.45,1,1 C13,12.55,12.55,13,12,13z M10.25,8c0.55,0,1,0.45,1,1s-0.45,1-1,1s-1-0.45-1-1S9.7,8,10.25,8z M8.5,13c-0.55,0-1-0.45-1-1 c0-0.55,0.45-1,1-1s1,0.45,1,1C9.5,12.55,9.05,13,8.5,13z M10.25,16c-0.55,0-1-0.45-1-1c0-0.55,0.45-1,1-1s1,0.45,1,1 C11.25,15.55,10.8,16,10.25,16z M13.75,16c-0.55,0-1-0.45-1-1c0-0.55,0.45-1,1-1s1,0.45,1,1C14.75,15.55,14.3,16,13.75,16z M14.5,12 c0-0.55,0.45-1,1-1s1,0.45,1,1c0,0.55-0.45,1-1,1S14.5,12.55,14.5,12z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
