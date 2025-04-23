// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiDiplodocus : ComponentBase
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
		builder.AddAttribute(14, "d", "M346.647 22.946c-19.81.144-40.982 6.645-48.194 25.359A39.33 20.719 0 0 0 279.4 66.033a39.33 20.719 0 0 0 36.664 20.649c17.706 4.338 42.703-3.822 56.312-25.166 22.5 9.72 50.156 21.74 56.615 47.18 13.014 51.25-19.25 147.44-38.24 153.953-54.464 18.681-114.531 21.169-152.465 45.69-43.773 28.295-72.155 82.248-111.75 92.456-32.22 8.307-96.032-7.227-103.89 18.01-1.202 8.7 6.012 16.63 25.914.074 28.679 7.782 106.19 35.345 179.18-23.144a169.515 169.515 0 0 0 14.203 7.9c.994 27.816 8.107 57.606 12.525 85.422h46.705l-4.916-44.467c4.988-16.298 11.013-25.643 14.697-43.342l17.664 3.461c-2.009 10.255-3.905 12.287-7.558 22.088 10.685.506 22.867-.07 33.894-1.025-7.715-17.771-11.885-41.54-15.886-57.371l17.45-4.41c5.517 21.825 14.342 52.147 17.983 60.296 3.248 7.27 11.303 64.77 11.303 64.77h37.223l7.515-85.74c28.595-16.919 38.1-37.13 43.64-60.215 19.358-80.647 23.886-168.749-7.448-243.842-19.615-47.005-57.366-60.762-91.875-72.01-7.463-2.65-17.643-4.381-28.211-4.304zm124.39 367.332c-6.211 7.738-13.93 15.286-23.39 22.273-1.986 24.653-3.834 51.635-5.881 76.506h32.767s-1.97-56.922-3.496-98.78zM356.46 443.266c-11.83 1.167-25.701 1.252-39.832.293l4.838 45.498h41.787z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
