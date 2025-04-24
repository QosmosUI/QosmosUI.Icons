// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiFishhookFork : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 512 512";

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
		builder.OpenElement(13, "path");
		builder.AddAttribute(14, "d", "M22.408 18.39v60.587S198.19 236.165 317.504 334.035c-9.2 3.815-19.898 5.503-31.102 5.277 52.274 39.08 103.82 79.553 163.178 105.01-28.328-60.655-63.28-112.895-103.516-167.015 1.993 14.567.067 26.324-4.67 35.523-76.207-91.106-195.03-202.617-296.402-294.44H22.408zm121.678 0C251.25 104.46 357.514 189.502 429.088 284.7c-5.74 10.573-18.106 14.794-31.537 11.68l101.62 115.052c-7.606-173.11-135.933-294.98-266.897-393.043h-88.187zM22.61 171.4v.004-.004zm0 .004v93.44C154.905 380.347 288.107 475.25 425 498.45L308.193 389.825c.88 12.204-1.625 22.48-10.51 22.778-98.07-71.302-191.387-152.64-275.072-241.198z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
