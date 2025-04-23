// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundSettingsRemote : ComponentBase
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
		builder.OpenElement(19, "g");
		builder.OpenElement(20, "path");
		builder.AddAttribute(21, "d", "M15,9H9c-0.55,0-1,0.45-1,1v12c0,0.55,0.45,1,1,1h6c0.55,0,1-0.45,1-1V10C16,9.45,15.55,9,15,9z M12,14.25 c-0.69,0-1.25-0.56-1.25-1.25s0.56-1.25,1.25-1.25s1.25,0.56,1.25,1.25S12.69,14.25,12,14.25z");
		builder.CloseElement();
		builder.OpenElement(22, "path");
		builder.AddAttribute(23, "d", "M7.82,6.82L7.82,6.82c0.35,0.35,0.9,0.38,1.3,0.1C9.93,6.34,10.93,6,12,6c1.07,0,2.07,0.34,2.88,0.91 c0.4,0.28,0.95,0.26,1.3-0.09l0,0c0.43-0.43,0.39-1.15-0.09-1.5C14.94,4.49,13.53,4,12,4c-1.53,0-2.94,0.49-4.09,1.32 C7.42,5.67,7.39,6.39,7.82,6.82z");
		builder.CloseElement();
		builder.OpenElement(24, "path");
		builder.AddAttribute(25, "d", "M12,0C9.36,0,6.94,0.93,5.05,2.47c-0.46,0.38-0.5,1.07-0.08,1.49l0,0c0.36,0.36,0.93,0.39,1.32,0.07 C7.84,2.77,9.83,2,12,2c2.17,0,4.16,0.77,5.7,2.04c0.39,0.32,0.96,0.29,1.32-0.07l0,0c0.42-0.42,0.38-1.11-0.08-1.49 C17.06,0.93,14.64,0,12,0z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
