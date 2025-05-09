// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Outline;

public class MdOutlineParagliding : ComponentBase
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
		builder.AddAttribute(18, "d", "M12,17c-1.1,0-2-0.9-2-2c0-1.1,0.9-2,2-2s2,0.9,2,2C14,16.1,13.1,17,12,17z M15.48,17.94C14.68,18.54,14,19,12,19 s-2.68-0.46-3.48-1.06C8.04,17.55,7,16.76,7,14H5c0,2.7,0.93,4.41,2.3,5.5c0.5,0.4,1.1,0.7,1.7,0.9V24h6v-3.6 c0.6-0.2,1.2-0.5,1.7-0.9c1.37-1.09,2.3-2.8,2.3-5.5h-2C17,16.76,15.96,17.55,15.48,17.94z M23,4.25v3.49c0,0.8-0.88,1.26-1.56,0.83 C21.3,8.48,21.16,8.39,21,8.31L19,13h-2l-1.5-6.28C14.4,6.58,13.22,6.5,12,6.5S9.6,6.58,8.5,6.72L7,13H5L3,8.31 C2.84,8.39,2.7,8.48,2.56,8.57C1.88,9,1,8.55,1,7.74V4.25C1,1.9,5.92,0,12,0S23,1.9,23,4.25z M6.9,6.98 C5.97,7.17,5.12,7.41,4.37,7.69l1.51,3.55L6.9,6.98z M19.63,7.69c-0.75-0.28-1.6-0.52-2.53-0.71l1.02,4.25L19.63,7.69z M21,4.31 C20.65,3.63,17.57,2,12,2S3.35,3.63,3,4.31v1.77C5.34,5.07,8.56,4.5,12,4.5s6.66,0.57,9,1.58V4.31z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
