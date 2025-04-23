// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundCellTower : ComponentBase
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
		builder.OpenElement(18, "rect");
		builder.AddAttribute(19, "fill", "none");
		builder.AddAttribute(20, "height", "24");
		builder.AddAttribute(21, "width", "24");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(22, "g");
		builder.OpenElement(23, "g");
		builder.OpenElement(24, "path");
		builder.AddAttribute(25, "d", "M7.9,14.1l0.09-0.09c0.27-0.27,0.32-0.71,0.08-1.01C7.36,12.09,7,11.01,7,10c0-1.08,0.35-2.16,1.04-3.01 c0.25-0.3,0.21-0.75-0.07-1.02L7.9,5.9C7.56,5.56,7,5.6,6.7,5.98C5.79,7.16,5.3,8.58,5.3,10c0,1.42,0.49,2.84,1.4,4.02 C7,14.4,7.56,14.44,7.9,14.1z");
		builder.CloseElement();
		builder.OpenElement(26, "path");
		builder.AddAttribute(27, "d", "M18.51,3.49l-0.08,0.08c-0.3,0.3-0.29,0.76-0.03,1.08c1.26,1.53,1.9,3.48,1.9,5.35c0,1.87-0.63,3.81-1.9,5.35 c-0.28,0.33-0.23,0.83,0.08,1.14v0c0.35,0.35,0.93,0.31,1.24-0.07C21.29,14.54,22,12.31,22,10c0-2.32-0.79-4.55-2.31-6.43 C19.39,3.2,18.84,3.16,18.51,3.49z");
		builder.CloseElement();
		builder.OpenElement(28, "path");
		builder.AddAttribute(29, "d", "M5.57,3.57L5.49,3.49C5.16,3.16,4.61,3.2,4.31,3.57C2.79,5.45,2,7.68,2,10c0,2.32,0.79,4.55,2.31,6.43 c0.3,0.37,0.85,0.42,1.18,0.08l0.08-0.08c0.3-0.3,0.29-0.76,0.03-1.08C4.33,13.81,3.7,11.87,3.7,10c0-1.87,0.63-3.81,1.9-5.35 C5.86,4.33,5.87,3.87,5.57,3.57z");
		builder.CloseElement();
		builder.OpenElement(30, "path");
		builder.AddAttribute(31, "d", "M16.07,14.07c0.36,0.36,0.95,0.32,1.26-0.09c0.9-1.18,1.37-2.58,1.37-3.98c-0.08-1.41-0.51-2.83-1.4-4.01 c-0.29-0.39-0.86-0.43-1.2-0.09l-0.08,0.08c-0.27,0.27-0.32,0.71-0.08,1.01C16.64,7.91,17,8.99,17,10c0,1.07-0.34,2.13-1.01,2.98 C15.73,13.3,15.77,13.77,16.07,14.07L16.07,14.07z");
		builder.CloseElement();
		builder.OpenElement(32, "path");
		builder.AddAttribute(33, "d", "M14.5,10c0-1.6-1.51-2.85-3.18-2.41c-0.8,0.21-1.46,0.85-1.7,1.65c-0.32,1.06,0.06,2.04,0.76,2.64l-2.96,8.87 C7.21,21.37,7.67,22,8.32,22h0c0.41,0,0.77-0.26,0.9-0.65L9.67,20h4.67l0.45,1.35c0.13,0.39,0.49,0.65,0.9,0.65h0 c0.65,0,1.1-0.63,0.9-1.25l-2.96-8.87C14.16,11.42,14.5,10.76,14.5,10z M10.33,18L12,13l1.67,5H10.33z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
