// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiJigsawPiece : ComponentBase
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
		builder.AddAttribute(14, "d", "M234.72 26.594c-.753-.008-1.514.01-2.282.03-5.09.147-10.548.97-16.375 2.532-62.162 16.66-38.924 89.862-13.97 94.72 4.963.964 15.1 29.773 5.407 47.968L102.25 200.03l28.063 104.75c-4.66 18.956-34.61 21.788-51.438 8-13.04-10.692-68.983 9.403-54.78 62.408 14.2 53.004 76.607 33.183 80.75 11.906 1.016-5.245 28.51-24.732 45.405-7.844l28.125 104.938 114.594-30.72c29.46-14.44 5.724-35.85-14.376-43.437-15.9-5.987-26.554-64.91 26.844-79.217 5.005-1.342 9.676-1.97 14-2.032 41.79-.61 51.995 53.516 37.062 66.5-4.135 3.595-13.396 43.19 15.844 36.876l5.312-1.5c-.927.323-1.822.6-2.687.844l118.186-31.656-30.344-113.313c-14.378-18.138-42.185-4.923-49.687 15-5.993 15.91-50.688 24.518-65-28.874-14.312-53.39 32.484-60.992 49.25-47 14.26 11.905 51.205 11.807 40.375-30.47l5.438 18.095-26.157-97.593-138.75 37.188c-19.11-8.485-25.912-31.455-10.405-44.438 27.632-23.133 14.2-81.373-33.156-81.843zm137.624 405.562l-3.844 1.094 6.28-1.688c-.837.233-1.653.425-2.436.594zm63.437-243.562c.775 2.288 1.436 4.482 1.97 6.562l-1.97-6.562z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
