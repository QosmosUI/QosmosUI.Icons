// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundGroupOff : ComponentBase
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
		builder.AddAttribute(18, "d", "M15,8c0-1.42-0.5-2.73-1.33-3.76C14.09,4.1,14.53,4,15,4c2.21,0,4,1.79,4,4s-1.79,4-4,4c-0.06,0-0.12,0-0.18,0l-0.77-0.77 C14.65,10.29,15,9.18,15,8z M7.24,4.41C7.77,4.15,8.37,4,9,4c2.21,0,4,1.79,4,4c0,0.63-0.15,1.23-0.41,1.76L7.24,4.41z M21.19,21.19 c0.39,0.39,0.39,1.02,0,1.41s-1.02,0.39-1.41,0l-2.99-2.99C16.6,19.85,16.32,20,16,20H2c-0.55,0-1-0.45-1-1v-2c0-2.66,5.33-4,8-4 c0.37,0,0.8,0.03,1.25,0.08L9.17,12C9.11,12,9.06,12,9,12c-2.21,0-4-1.79-4-4c0-0.06,0-0.11,0-0.17L1.39,4.22 C1,3.83,1,3.2,1.39,2.81s1.02-0.39,1.41,0L21.19,21.19z M18.89,16.07c-0.29-1.22-1.13-2.19-2.23-2.94C19.42,13.53,23,14.82,23,17v2 c0,0.32-0.15,0.6-0.38,0.79L18.89,16.07z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
