// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiWalkingScout : ComponentBase
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
		builder.AddAttribute(14, "d", "M79.624 33.606L52.851 113.93l16.636 6.049a72.511 72.511 0 0 1 27.055-9.02V74.407l146 54.75v13.237h96v50h-69.91l108.203 39.345-19.818-84.07-18.657-68.404zm322.744 20.022l-17.652 3.531 12.99 64.947 18.72 1.813zm-287.826 46.754v74.012h110V141.63zm-18 28.75c-26.165 4.27-46 26.847-46 54.262 0 30.482 24.518 55 55 55 27.414 0 49.992-19.835 54.262-46H96.542zm276.645 8.683l28.04 118.96 60.231 24.093-11.295-56.474h-37.568l-22.24-84.916zm36.31 3.704l16.992 64.875h20.074l-3.931-19.655-8.598-42.99zm-166.955 18.875v14h78v-14zm-51.271 32l42.066 42.066 149.799 24.014-.772-3.278-3.09-3.414-163.316-59.388zm-15.303 10.152c-6.032 22.105-22.226 40.075-43.22 48.557l73.448 83.943 54.924 9.152 6.4-19.203-41.195-72.09zm109.508 125.508l-19.702 59.105 49.254-29.553zm-79.873 25.14L172.883 399l55.636 16.691 13.156-13.156 13.681-41.049zm-34.592 64.037l-41.907 27.938-11.074 33.225h202.512v-16.305z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
