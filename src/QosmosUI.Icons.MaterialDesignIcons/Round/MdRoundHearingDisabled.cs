// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundHearingDisabled : ComponentBase
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
		builder.OpenElement(18, "path");
		builder.AddAttribute(19, "d", "M16.96,3.3c-0.32-0.39-0.29-0.96,0.07-1.32l0.01-0.01c0.42-0.42,1.12-0.38,1.49,0.08C20.07,3.94,21,6.36,21,9 c0,2.57-0.89,4.94-2.36,6.81l-1.43-1.43C18.33,12.88,19,11.02,19,9C19,6.83,18.23,4.84,16.96,3.3z M7.49,4.66 C8.23,4.24,9.08,4,10,4c2.8,0,5,2.2,5,5c0,0.8-0.23,1.69-0.63,2.54l1.48,1.48c0.02-0.04,0.05-0.08,0.08-0.13 C16.62,11.65,17,10.26,17,9c0-3.93-3.07-7-7-7C8.51,2,7.15,2.44,6.03,3.2L7.49,4.66z M10,6.5c-0.21,0-0.4,0.03-0.59,0.08l3.01,3.01 C12.47,9.4,12.5,9.21,12.5,9C12.5,7.62,11.38,6.5,10,6.5z M20.49,20.49L3.51,3.51c-0.39-0.39-1.02-0.39-1.41,0 c-0.39,0.39-0.39,1.02,0,1.41l1.42,1.42c-0.2,0.49-0.35,1-0.43,1.54C2.99,8.47,3.47,9,4.06,9H4.1c0.48,0,0.89-0.35,0.96-0.82 C5.08,8.1,5.1,8.02,5.12,7.95l6.62,6.62c-0.88,0.68-1.78,1.41-2.27,2.9c-0.5,1.5-1,2.01-1.71,2.38C7.56,19.94,7.29,20,7,20 c-0.88,0-1.63-0.58-1.9-1.37C4.97,18.24,4.57,18,4.15,18C3.49,18,3,18.64,3.2,19.26C3.73,20.85,5.23,22,7,22 c0.57,0,1.13-0.12,1.64-0.35c1.36-0.71,2.13-1.73,2.73-3.55c0.32-0.98,0.9-1.43,1.71-2.05c0.03-0.02,0.05-0.04,0.08-0.06l5.91,5.91 c0.39,0.39,1.02,0.39,1.41,0C20.88,21.51,20.88,20.88,20.49,20.49z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
