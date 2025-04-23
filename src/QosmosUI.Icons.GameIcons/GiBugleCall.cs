// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiBugleCall : ComponentBase
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
		builder.AddAttribute(14, "d", "M340.53 16.47l-19.25 89.374L391.94 16.47H340.53zm151.283 18.686L372.063 167.75l119.75-47.906V35.156zM185.375 80.25c-.652.01-1.293.034-1.938.063-9.51.422-18.37 2.635-25.687 7.593-16.964 11.492-11.295 37.156-22.78 63.094C95.73 239.616 56.09 303.885 21.062 351.313v103.375c61.582-21.345 153.303-43.464 287.343-47.907 28.125-.93 49.728 12.582 66.594 1.158 41.638-28.207 26.563-122.468-33.28-210.813-3.74-5.52-7.224-11.14-11.126-16.344-46.8-62.426-104.125-101.083-145.22-100.53zM180 104.75c-6.756 13.893-.412 43.86 15.938 80.75-5.16-18.626-4.688-32.142 2.687-36.625 16.125-9.802 59.054 27.175 95.875 82.594 36.82 55.417 53.593 108.29 37.47 118.093-6.634 4.032-17.81.138-31.22-9.688 27.717 28.092 52.734 44.51 68.094 43.656-1.785 3.17-3.675 6.244-6.5 8.158-26.9 18.225-91.755-30.25-144.656-108.344-52.902-78.094-73.87-156.34-46.97-174.563 2.757-1.866 5.784-3.525 9.282-4.03zm311.813 115.563l-84.688 27.437 84.688 12.844v-40.28z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
