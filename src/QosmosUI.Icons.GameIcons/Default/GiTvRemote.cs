// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiTvRemote : ComponentBase
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
		builder.AddAttribute(14, "d", "M380.412 26.416L21 374.77l121.647 121.647L491 137.005c-44.235-66.353-44.235-66.353-110.588-110.589zm-.691 22.81l22.117 22.117-12.44 12.44-22.119-22.117zm66.353 66.352l22.117 22.118-12.441 12.44-22.118-22.117zM369.353 81.71c6.871 6.871 6.871 18.012 0 24.883-6.871 6.87-18.011 6.87-24.882 0-6.871-6.871-6.871-18.012 0-24.883 6.87-6.87 18.01-6.87 24.882 0zm33.176 33.177c6.871 6.871 6.871 18.011 0 24.882-6.87 6.871-18.01 6.871-24.882 0-6.871-6.87-6.871-18.011 0-24.882 6.871-6.871 18.011-6.871 24.882 0zm33.177 33.176c6.871 6.871 6.871 18.012 0 24.883-6.871 6.87-18.011 6.87-24.882 0-6.872-6.871-6.872-18.012 0-24.883 6.87-6.87 18.01-6.87 24.882 0zm-99.53-33.176c6.872 6.871 6.872 18.011 0 24.882-6.87 6.871-18.01 6.871-24.882 0-6.871-6.87-6.871-18.011 0-24.882 6.871-6.871 18.011-6.871 24.882 0zm33.177 33.176c6.871 6.871 6.871 18.012 0 24.883-6.871 6.87-18.011 6.87-24.882 0-6.871-6.871-6.871-18.012 0-24.883 6.87-6.87 18.01-6.87 24.882 0zm33.176 33.177c6.871 6.87 6.871 18.011 0 24.882-6.87 6.871-18.01 6.871-24.882 0-6.871-6.87-6.871-18.011 0-24.882 6.871-6.871 18.011-6.871 24.882 0zM303 148.063c6.871 6.871 6.871 18.012 0 24.883-6.871 6.87-18.011 6.87-24.882 0-6.871-6.871-6.871-18.012 0-24.883 6.87-6.87 18.01-6.87 24.882 0zm33.176 33.177c6.872 6.87 6.872 18.011 0 24.882-6.87 6.871-18.01 6.871-24.882 0-6.871-6.87-6.871-18.011 0-24.882 6.871-6.871 18.011-6.871 24.882 0zm33.177 33.176c6.871 6.871 6.871 18.012 0 24.883-6.871 6.87-18.011 6.87-24.882 0-6.871-6.871-6.871-18.012 0-24.883 6.87-6.87 18.01-6.87 24.882 0zm-114.735-40.088L279.5 199.21l-44.235 44.236-24.883-24.883zm63.588 63.588l24.882 24.883-44.235 44.235-24.882-24.882zm-69.118 30.412c10.299 10.298 16.352 23.318 18.181 36.821h-41.035a24.805 24.805 0 0 1 0 17.593h41.035c-1.83 13.503-7.882 26.523-18.18 36.821-10.3 10.299-23.32 16.352-36.822 18.182v-41.036a24.805 24.805 0 0 1-17.593 0v41.036c-13.503-1.83-26.523-7.883-36.821-18.182-10.298-10.298-16.352-23.318-18.181-36.821h41.036a24.805 24.805 0 0 1 0-17.593h-41.036c1.83-13.503 7.883-26.523 18.18-36.82 10.3-10.3 23.32-16.353 36.822-18.182v41.036a24.805 24.805 0 0 1 17.593 0v-41.036c13.503 1.83 26.523 7.883 36.821 18.181zM76.985 351.96l22.118 22.118-12.441 12.441-22.118-22.117zm33.177 33.177l22.117 22.118-12.44 12.44-22.118-22.117zm33.176 33.176l22.118 22.118-12.441 12.441-22.118-22.117z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
