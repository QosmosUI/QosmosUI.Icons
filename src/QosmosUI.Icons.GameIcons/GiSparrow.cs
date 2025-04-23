// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiSparrow : ComponentBase
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
		builder.AddAttribute(14, "d", "M272.625 97.375c-.44 19.098 6.645 38.842 23.938 49.063-2.897 6.85-4.688 14.284-4.688 22.187 0 3.698.412 7.577 1.125 11.53-45.116-2.51-94.654 27.96-115.47 75.282l-94.718-86.812 2.813 43.125-57.813-19.063 33.844 53.032-38.406 18.124c61.937 20.327 134.08 52.95 197.25 59l-7.72 34.062-48.655 41.063 12.063 14.28 29.75-25.094-9.063 39.97 18.25 4.124 9.094-40.125 14.405 32.72 17.125-7.533-24.594-55.812 8.313-36.688c15.398.06 30.104-1.818 43.81-6.25l16.5 31.313-12.124 56.97 18.28 3.905 7.47-35.03 21 39.905 16.53-8.72-18.56-35.28 33.687 15.844L374 369.56l-56.063-26.343-17.343-32.94c36.401-19.08 57.443-50.84 56.375-79.06 13.583-6.22 26.922-15.686 36.31-27.595 36.75-8.613 83.28-7.746 106.533 17.844-8.747-70.424-60.418-81.806-105.594-82.876-26.663-33.223-85.387-8.755-121.595-41.22zm86.438 44.656c7.52 0 13.625 6.107 13.625 13.626 0 7.522-6.104 13.625-13.625 13.625-7.522 0-13.594-6.102-13.594-13.624 0-7.52 6.07-13.625 13.592-13.625z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
