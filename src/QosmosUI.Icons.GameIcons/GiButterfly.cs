// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiButterfly : ComponentBase
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
		builder.AddAttribute(14, "d", "M222.97 43.094l-17.72 5.937c18.246 54.362 27.075 112.164 24.406 174.47l-.875 20.5 16.032-12.78c47.213-37.597 81.827-86.216 102.282-146.095l-17.688-6.063c-17.04 49.88-44.08 90.906-80.656 124.22.156-56.652-8.915-109.937-25.78-160.188zM53.812 51.22C51.09 160.79 110.03 244.245 208.75 273c2.573-110.1-55.144-193.608-154.938-221.78zm335.156 150.374c-58.436-.03-115.656 25.943-163.5 76.094 90.775 49.848 192.148 32.407 268.217-47.563-34.172-19.135-69.658-28.513-104.718-28.53zM136.936 277.03c-52.45.582-94.1 32.36-116.687 91.25 82.336 33.03 151.56 4.26 182.72-77.374-23.333-9.574-45.51-14.102-66.032-13.875zm81.97 19.47c-37.76 80.056-8.793 149.03 75.343 183.094 37.786-80.46 9.994-149.316-75.344-183.094z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
