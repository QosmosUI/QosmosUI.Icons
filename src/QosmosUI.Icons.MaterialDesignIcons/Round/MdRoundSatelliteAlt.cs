// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundSatelliteAlt : ComponentBase
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
		builder.OpenElement(14, "rect");
		builder.AddAttribute(15, "fill", "none");
		builder.AddAttribute(16, "height", "24");
		builder.AddAttribute(17, "width", "24");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(18, "g");
		builder.OpenElement(19, "path");
		builder.AddAttribute(20, "d", "M20.95,14.88c-0.4,3.18-2.89,5.67-6.07,6.07C14.37,21.01,14,21.44,14,21.94c0,0.04,0,0.08,0.01,0.12 c0.07,0.55,0.57,0.94,1.12,0.87c4.09-0.51,7.3-3.72,7.81-7.81c0.06-0.55-0.33-1.05-0.88-1.11C21.51,13.94,21.01,14.33,20.95,14.88z M18.84,15.26c0.14-0.53-0.18-1.08-0.72-1.22c-0.54-0.14-1.08,0.18-1.22,0.72c-0.27,1.05-1.09,1.87-2.15,2.15 C14.3,17.03,14,17.43,14,17.88c0,0.08,0.01,0.17,0.03,0.25c0.14,0.53,0.69,0.85,1.22,0.72C17.02,18.38,18.39,17.01,18.84,15.26z M21.8,4.12l-3.54-3.54c-0.78-0.78-2.05-0.78-2.83,0l-3.18,3.18c-0.78,0.78-0.78,2.05,0,2.83l1.24,1.24l-0.71,0.71L11.55,7.3 c-0.78-0.78-2.05-0.78-2.83,0L7.3,8.72c-0.78,0.78-0.78,2.05,0,2.83l1.24,1.24l-0.71,0.71L6.6,12.25c-0.78-0.78-2.05-0.78-2.83,0 l-3.18,3.18c-0.78,0.78-0.78,2.05,0,2.83l3.54,3.54c0.78,0.78,2.05,0.78,2.83,0l3.18-3.18c0.78-0.78,0.78-2.05,0-2.83l-1.24-1.24 l0.71-0.71l1.24,1.24c0.78,0.78,2.05,0.78,2.83,0l1.41-1.41c0.78-0.78,0.78-2.05,0-2.83L13.84,9.6l0.71-0.71l1.24,1.24 c0.78,0.78,2.05,0.78,2.83,0l3.18-3.18C22.58,6.17,22.58,4.9,21.8,4.12z M5.54,20.38L2,16.85l1.06-1.06l3.54,3.54L5.54,20.38z M7.66,18.26l-3.54-3.54l1.06-1.06l3.54,3.54L7.66,18.26z M17.2,8.72l-3.54-3.54l1.06-1.06l3.54,3.54L17.2,8.72z M19.32,6.6 l-3.54-3.54L16.85,2l3.54,3.54L19.32,6.6z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
