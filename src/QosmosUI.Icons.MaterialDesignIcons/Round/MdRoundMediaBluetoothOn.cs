// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundMediaBluetoothOn : ComponentBase
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
		builder.AddAttribute(20, "d", "M9,5l0.01,8.55c-0.6-0.34-1.28-0.55-2-0.55C4.79,13,3,14.79,3,17s1.79,4,4.01,4S11,19.21,11,17V7h2c1.1,0,2-0.9,2-2v0 c0-1.1-0.9-2-2-2h-2C9.9,3,9,3.9,9,5z M20.29,11.72l-2.47-2.47c-0.32-0.31-0.85-0.09-0.85,0.35v3.94l-2.33-2.33 c-0.23-0.23-0.61-0.23-0.85,0l0,0c-0.23,0.23-0.23,0.62,0,0.85L16.73,15l-2.93,2.93c-0.23,0.23-0.23,0.61,0,0.85l0,0 c0.23,0.23,0.61,0.23,0.85,0l2.33-2.33v3.94c0,0.45,0.54,0.67,0.85,0.35l2.46-2.46c0.39-0.39,0.39-1.02,0-1.41L18.42,15l1.87-1.86 C20.68,12.75,20.68,12.11,20.29,11.72z M18.17,11.3l1.13,1.13l-1.13,1.13V11.3z M19.3,17.57l-1.13,1.13v-2.26L19.3,17.57z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
