// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiDrippingKnife : ComponentBase
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
		builder.AddAttribute(14, "d", "M490.906 15c-15.93 27.59-38.93 49.68-66.125 65.906-1.656 22.7-13.066 44.383-30.655 63.844-24.774 27.41-61.863 51.865-104.78 73.906-84.056 43.17-190.69 76.712-270.75 97.656v53.875c7.514-2.44 15.065-4.847 22.624-7.25 18.695.008 39.45 7.253 46.25 50.282C80.952 445.75 64 453.105 64 477c0 12.348 12.224 21.406 24.03 21.406 12.074 0 23.532-8.464 23.532-20.187 0-23.002-16.374-32.466-23-65.283 9.795-76.6 133.782-117.104 133.782-71.75 0 11.632-12.813 21.018-12.813 31.625 0 12.752 11.694 21.75 24.032 21.75 12.068 0 24.657-10.1 24.657-23.53 0-13.43-14-20.934-14-31.75 0-71.077 114.83-78.082 132.686-16.782-13.16 56.997-42.03 75.01-42.03 116.844 0 22.04 21.583 38 44.28 38 22.2 0 45.125-17.067 45.125-40.28 0-43.735-30.165-58.033-43.06-115.19 23.29-129.734 61.263-121.692 88.31-176.03.036-.06.06-.127.095-.188C490.395 109.56 498.903 66.81 490.905 15zm-86.53 76.656c-37.166 17.086-80.115 24.428-123 21.28C221.435 153.363 107.803 206.662 18.593 225v71.97c78.706-20.824 182.013-53.747 262.219-94.94 41.78-21.456 77.22-45.23 99.437-69.81 12.273-13.58 20.51-26.965 24.125-40.564zm54.28 102.125c-7.41 43.062-29.47 51.75-29.47 81.94.002 15.146 14.987 26.28 29.47 26.28 14.81 0 28.875-10.4 28.875-24.78 0-28.982-21.217-40.46-28.874-83.44z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
