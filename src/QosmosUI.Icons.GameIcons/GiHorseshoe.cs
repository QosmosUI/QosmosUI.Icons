// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiHorseshoe : ComponentBase
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
		builder.AddAttribute(14, "d", "M251.188 28.538c-202.97 2.955-190.282 230.2-126.782 409.47-14.678 9.41-17.29 6.385-15.75 17.062 1.105 7.65 12.483 23.233 17.563 25.844s9.372 2.85 17.03 2.343 60.337-8.77 49.22-22.625c-48-67.4-126.572-365.46 63.53-374.062 190.102 8.603 111.53 306.66 63.53 374.062-11.117 13.855 41.562 22.117 49.22 22.625s11.95.267 17.03-2.343 16.46-18.194 17.564-25.844c1.54-10.678-1.072-7.65-15.75-17.063 63.5-179.27 76.187-406.514-126.78-409.469-1.6-.023-3.19-.005-4.814 0-1.625-.004-3.214-.023-4.813 0zm-45.625 22.157c6.903 0 12.5 5.596 12.5 12.5s-5.597 12.5-12.5 12.5-12.5-5.597-12.5-12.5 5.596-12.5 12.5-12.5zm100.875 0c6.903 0 12.5 5.596 12.5 12.5s-5.597 12.5-12.5 12.5-12.5-5.597-12.5-12.5 5.596-12.5 12.5-12.5zM135.594 109.32c6.903 0 12.5 5.596 12.5 12.5s-5.597 12.5-12.5 12.5-12.5-5.597-12.5-12.5 5.596-12.5 12.5-12.5zm240.812 0c6.904 0 12.5 5.596 12.5 12.5s-5.596 12.5-12.5 12.5-12.5-5.597-12.5-12.5 5.597-12.5 12.5-12.5zm-266.844 96c6.904 0 12.5 5.596 12.5 12.5s-5.596 12.5-12.5 12.5-12.5-5.597-12.5-12.5 5.597-12.5 12.5-12.5zm292.875 0c6.904 0 12.5 5.596 12.5 12.5s-5.596 12.5-12.5 12.5-12.5-5.597-12.5-12.5 5.597-12.5 12.5-12.5zM118.22 307.82c6.902 0 12.5 5.596 12.5 12.5s-5.598 12.5-12.5 12.5-12.5-5.597-12.5-12.5 5.595-12.5 12.5-12.5zm275.56 0c6.905 0 12.5 5.596 12.5 12.5s-5.595 12.5-12.5 12.5-12.5-5.597-12.5-12.5 5.598-12.5 12.5-12.5zm-254.936 84.062c6.903 0 12.5 5.597 12.5 12.5s-5.597 12.5-12.5 12.5-12.5-5.596-12.5-12.5 5.596-12.5 12.5-12.5zm234.312 0c6.904 0 12.5 5.597 12.5 12.5s-5.596 12.5-12.5 12.5-12.5-5.596-12.5-12.5 5.597-12.5 12.5-12.5z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
