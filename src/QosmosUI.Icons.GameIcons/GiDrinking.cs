// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiDrinking : ComponentBase
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
		builder.AddAttribute(14, "d", "M136.56 70.504a88.18 88.18 0 0 0-12.686.949c-33.833 5.004-62.022 29.192-80.272 65.89-18.25 36.699-26.008 85.566-18.285 137.307 7.723 51.741 29.418 96.251 57.598 126.082 28.18 29.831 62.216 44.819 96.048 39.815 33.833-5.004 62.024-29.195 80.274-65.893 4.264-8.573 7.947-17.818 11.002-27.601-29.164.07-58.834-2.573-92.08-24.287 47.863-14.36 76.86-36.492 101.926-60.243a271.619 271.619 0 0 0-2.565-25.173c-7.723-51.741-29.416-96.253-57.596-126.084-24.657-26.103-53.8-40.838-83.365-40.762zm244.189 97.467l-87.937 109.81c-.11.17-17.645 28.102-14.198 42.682 1.549 6.554 7.56 14.287 14.304 14.287 6.744 0 12.758-7.733 14.307-14.287 3.426-14.494-13.853-42.137-14.238-42.75l8.82 5.222 128.162 75.854 59.686-74.506zm1.06 27.468l69.85 74.6H322.047zm-133.21 2.33l13.13 12.311c-17.393 18.552-47.5 23.81-71.523 21.414l1.787-17.912c19.327 1.927 45.889-4.382 56.605-15.813z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
