// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundPassword : ComponentBase
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
		builder.OpenElement(18, "g");
		builder.OpenElement(19, "path");
		builder.AddAttribute(20, "d", "M3,17h18c0.55,0,1,0.45,1,1v0c0,0.55-0.45,1-1,1H3c-0.55,0-1-0.45-1-1v0C2,17.45,2.45,17,3,17z M2.5,12.57 c0.36,0.21,0.82,0.08,1.03-0.28L4,11.47l0.48,0.83c0.21,0.36,0.67,0.48,1.03,0.28l0,0c0.36-0.21,0.48-0.66,0.28-1.02L5.3,10.72 h0.95C6.66,10.72,7,10.38,7,9.97v0c0-0.41-0.34-0.75-0.75-0.75H5.3L5.77,8.4C5.98,8.04,5.86,7.58,5.5,7.37l0,0 C5.14,7.17,4.68,7.29,4.47,7.65L4,8.47L3.53,7.65C3.32,7.29,2.86,7.17,2.5,7.37l0,0C2.14,7.58,2.02,8.04,2.23,8.4L2.7,9.22H1.75 C1.34,9.22,1,9.56,1,9.97v0c0,0.41,0.34,0.75,0.75,0.75H2.7l-0.48,0.83C2.02,11.91,2.14,12.37,2.5,12.57L2.5,12.57z M10.5,12.57 L10.5,12.57c0.36,0.21,0.82,0.08,1.03-0.28L12,11.47l0.48,0.83c0.21,0.36,0.67,0.48,1.03,0.28l0,0c0.36-0.21,0.48-0.66,0.28-1.02 l-0.48-0.83h0.95c0.41,0,0.75-0.34,0.75-0.75v0c0-0.41-0.34-0.75-0.75-0.75H13.3l0.47-0.82c0.21-0.36,0.08-0.82-0.27-1.03l0,0 c-0.36-0.21-0.82-0.08-1.02,0.27L12,8.47l-0.47-0.82c-0.21-0.36-0.67-0.48-1.02-0.27l0,0c-0.36,0.21-0.48,0.67-0.27,1.03 l0.47,0.82H9.75C9.34,9.22,9,9.56,9,9.97v0c0,0.41,0.34,0.75,0.75,0.75h0.95l-0.48,0.83C10.02,11.91,10.14,12.37,10.5,12.57z M23,9.97c0-0.41-0.34-0.75-0.75-0.75H21.3l0.47-0.82c0.21-0.36,0.08-0.82-0.27-1.03l0,0c-0.36-0.21-0.82-0.08-1.02,0.27L20,8.47 l-0.47-0.82c-0.21-0.36-0.67-0.48-1.02-0.27l0,0c-0.36,0.21-0.48,0.67-0.27,1.03l0.47,0.82h-0.95C17.34,9.22,17,9.56,17,9.97v0 c0,0.41,0.34,0.75,0.75,0.75h0.95l-0.48,0.83c-0.21,0.36-0.08,0.82,0.28,1.02l0,0c0.36,0.21,0.82,0.08,1.03-0.28L20,11.47 l0.48,0.83c0.21,0.36,0.67,0.48,1.03,0.28l0,0c0.36-0.21,0.48-0.66,0.28-1.02l-0.48-0.83h0.95C22.66,10.72,23,10.38,23,9.97 L23,9.97z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
