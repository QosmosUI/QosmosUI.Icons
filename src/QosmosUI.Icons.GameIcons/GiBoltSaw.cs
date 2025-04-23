// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiBoltSaw : ComponentBase
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
		builder.AddAttribute(14, "d", "M118.262 17.338l-.004.002 14.6 33.287L34.74 64.645l46.723 45.552L14.3 183.783l43.804 16.936-9.344 105.706 48.474-8.176 51.393 121.475 26.28-29.786 95.197 94.61 2.335-36.208 112.714 44.967-19.27-43.218 104.538-15.184-42.633-40.883 66.577-72.418-50.224-19.27 8.76-106.876-52.56 8.76L348.946 81.58l-25.695 29.785-89.354-88.77-2.337 39.714-113.298-44.97zm144.8 100.435l52.75 54.9 10.428-26.282 25.125 84.682 19.008-13.43-14.63 63.073 35.02-2.336-50.077 50.225 36.066 17.518.006-.002-.002.005-.004-.002-63.086 14.6 17.443 24.53-79.653-25.698 4.516 32.123-51.422-53.147-11.575 28.618-24.38-82.93-26.116 18.688 17.448-74.754-37.942 2.336 49.354-49.64-35.043-16.938 72.998-16.935-19.215-26.866 76.87 25.113-3.89-27.45zm-23.345 95.846c-14.81 0-18.424 16.9-8.074 37.75 10.35 20.848 30.742 37.747 45.55 37.747 14.81 0 18.424-16.9 8.075-37.748-10.35-20.85-30.742-37.75-45.55-37.75z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
