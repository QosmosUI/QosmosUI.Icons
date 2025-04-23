// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundTempleBuddhist : ComponentBase
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
		builder.OpenElement(24, "g");
		builder.OpenElement(25, "path");
		builder.AddAttribute(26, "d", "M21.85,9.01c-0.41,0-0.82,0.24-0.95,0.63C20.64,10.43,19.89,11,19.02,11H4.98c-0.87,0-1.62-0.57-1.88-1.36 C2.97,9.25,2.57,9.02,2.16,9.02h0C1.5,9.02,1,9.66,1.21,10.28c0.43,1.27,1.48,2.24,2.79,2.58V20c0,1.1,0.9,2,2,2h4l0-2.89 c0-1,0.68-1.92,1.66-2.08C12.92,16.82,14,17.79,14,19v3h4c1.1,0,2-0.9,2-2v-7.14c0.46-0.12,2.22-0.76,2.81-2.58 C23.01,9.65,22.51,9,21.85,9.01L21.85,9.01z");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(27, "g");
		builder.OpenElement(28, "path");
		builder.AddAttribute(29, "d", "M6,8.86V10h12V8.86c0.46-0.12,2.22-0.76,2.81-2.58c0.2-0.63-0.3-1.27-0.96-1.27l0,0c-0.41,0-0.82,0.24-0.95,0.63 C18.64,6.43,17.89,7,17.02,7H6.98C6.11,7,5.36,6.43,5.1,5.64C4.97,5.25,4.57,5.02,4.16,5.02h0C3.5,5.02,3,5.66,3.21,6.28 C3.64,7.55,4.69,8.53,6,8.86z");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(30, "g");
		builder.OpenElement(31, "path");
		builder.AddAttribute(32, "d", "M11.2,2.07L8.25,6h7.5L12.8,2.07C12.4,1.53,11.6,1.53,11.2,2.07z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
