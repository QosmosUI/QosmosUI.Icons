// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundPodcasts : ComponentBase
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
		builder.OpenElement(13, "g");
		builder.OpenElement(14, "path");
		builder.AddAttribute(15, "d", "M0,0h24v24H0V0z");
		builder.AddAttribute(16, "fill", "none");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(17, "g");
		builder.OpenElement(18, "path");
		builder.AddAttribute(19, "d", "M14,12c0,0.74-0.4,1.38-1,1.72V21c0,0.55-0.45,1-1,1h0c-0.55,0-1-0.45-1-1v-7.28c-0.6-0.35-1-0.98-1-1.72c0-1.1,0.9-2,2-2 S14,10.9,14,12z M10.75,6.13c-2.27,0.46-4.12,2.28-4.61,4.55c-0.4,1.86,0.07,3.62,1.08,4.94c0.35,0.45,1.03,0.47,1.43,0.07 l0.07-0.07c0.34-0.34,0.34-0.87,0.06-1.25c-0.68-0.9-0.98-2.1-0.66-3.37c0.35-1.42,1.52-2.57,2.95-2.88C13.69,7.52,16,9.49,16,12 c0,0.87-0.28,1.67-0.76,2.32c-0.3,0.41-0.29,0.97,0.07,1.33l0,0c0.44,0.44,1.17,0.37,1.54-0.14C17.57,14.53,18,13.31,18,12 C18,8.28,14.61,5.35,10.75,6.13z M10.83,2.07C6.3,2.58,2.61,6.25,2.07,10.78c-0.35,2.95,0.59,5.67,2.32,7.7 c0.37,0.43,1.03,0.46,1.43,0.06l0.05-0.05c0.35-0.35,0.38-0.92,0.05-1.3c-1.56-1.83-2.33-4.37-1.7-7.06 c0.7-3.01,3.18-5.39,6.22-5.97C15.53,3.18,20,7.08,20,12c0,1.96-0.72,3.76-1.9,5.16c-0.34,0.4-0.31,0.98,0.05,1.35l0,0 c0.42,0.42,1.11,0.39,1.49-0.07C21.11,16.7,22,14.46,22,12C22,6.09,16.87,1.38,10.83,2.07z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
