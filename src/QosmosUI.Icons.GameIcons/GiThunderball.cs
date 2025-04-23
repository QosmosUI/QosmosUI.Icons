// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiThunderball : ComponentBase
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
		builder.AddAttribute(14, "d", "M22.03 16.844l147 158.125 37.75-14.626 6.75 17.437-110.25 42.72 209.564 230.53.187.25c18.074 22.833 46.023 37.5 77.314 37.5 54.318 0 98.562-44.243 98.562-98.56 0-43.636-28.55-80.77-67.937-93.69l-132.095-73.56-56.75 23.968-7.28-17.22 43.31-18.28-.186-.094 102.624-43.28L22.03 16.843zm368.314 293.5c44.218 0 79.875 35.656 79.875 79.875 0 7.866-1.146 15.45-3.25 22.624L446.155 409l4.688-39.656-22.78 54.22 32.467 4.873c-5.74 10.555-13.776 19.644-23.467 26.625l-51-24.75 37.312-44.78-79.594-40.626 53.064 47.25-43.97 36.47 42.72 41.312c-1.736.11-3.486.156-5.25.156-44.22 0-79.875-35.657-79.875-79.875 0-1.48.045-2.95.124-4.408l30.562 11.47-6.5 25.562 27.75-34.938-49.437-17.72c6.807-26.514 26.865-47.622 52.717-55.967l24.5 35.217 51.438-5.218-41.75-8.72-17.688-24.75c2.68-.27 5.404-.406 8.157-.406z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
