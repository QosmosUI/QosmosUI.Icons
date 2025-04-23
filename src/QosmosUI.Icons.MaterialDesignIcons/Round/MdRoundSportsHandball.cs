// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundSportsHandball : ComponentBase
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
		builder.AddAttribute(25, "d", "M14.27,6C13.72,6.95,14.05,8.18,15,8.73c0.95,0.55,2.18,0.22,2.73-0.73c0.55-0.95,0.22-2.18-0.73-2.73 C16.05,4.72,14.82,5.05,14.27,6z");
		builder.CloseElement();
		builder.OpenElement(26, "path");
		builder.AddAttribute(27, "d", "M15.84,10.41c0,0-1.63-0.94-2.6-1.5c-2.13-1.24-3.01-3.83-2.18-6.07c0.17-0.46-0.01-0.97-0.43-1.21 C10.1,1.33,9.41,1.56,9.2,2.13C8.25,4.64,8.85,7.48,10.66,9.4l-4.65,8.05c-0.28,0.48-0.11,1.09,0.37,1.37 c0.48,0.28,1.09,0.11,1.37-0.37l1-1.73l1.73,1l-2.5,4.33c-0.28,0.48-0.11,1.09,0.37,1.37c0.48,0.28,1.09,0.11,1.37-0.37 l5.79-10.02c0.98,1.34,1.26,3.12,0.66,4.72c-0.17,0.45,0.02,0.96,0.43,1.2c0.53,0.31,1.22,0.08,1.44-0.5 C19.01,15.83,18.45,12.61,15.84,10.41z");
		builder.CloseElement();
		builder.OpenElement(28, "path");
		builder.AddAttribute(29, "d", "M12.75,3.8c0.72,0.41,1.63,0.17,2.05-0.55c0.41-0.72,0.17-1.63-0.55-2.05c-0.72-0.41-1.63-0.17-2.05,0.55 C11.79,2.47,12.03,3.39,12.75,3.8z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
