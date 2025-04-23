// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiCandleLight : ComponentBase
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
		builder.AddAttribute(14, "d", "M258.75 23.563c-27.913 0-93.875 87.237-93.875 158.593 0 59.35 29.018 79.715 68.625 94.875-15.47-15.607-26.03-43.75-26.03-76.186 0-49.232 31.292-89.188 53.25-89.188 21.132 0 53.25 39.955 53.25 89.188 0 30.39-9.41 56.833-23.283 72.937 36.097-18.016 61.938-35.72 61.938-91.624 0-71.356-66.786-158.594-93.875-158.594zm6.72 175.906l-18.5 2.686c5.764 39.366 6.665 69.034 4.25 97.875-24.957-.97-49.677-5.972-73.69-14.75v95.47c-3.295 25.668-22.434 30.526-22.093 53.47.29 19.547 14.998 26.003 22.094 17.624v36.28h164.69v-88.343c8.615 10.89 27.17 3.06 27.53-21.31.432-29.117-24.597-34.605-27.53-68.814V285.28c-23.916 8.88-48.17 13.702-72.314 14.72 2.337-29.752 1.383-60.792-4.437-100.53z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
