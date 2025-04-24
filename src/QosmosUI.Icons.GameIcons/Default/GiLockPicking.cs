// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiLockPicking : ComponentBase
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
		builder.AddAttribute(14, "d", "M494 12.973L208.54 169.975 35.65 97.938a121.168 121.168 0 0 0-1.716 14.103l174.302 101.68L494 64.212zm-68.223 6.12S346.247 35.15 320 48c-45.024 22.044-98.655 84.697-98.655 84.697C288.43 88.467 344.922 48 425.777 19.092zm-319.953 6.063c-19.304 0-36.98 9.903-50.3 26.918-6.275 8.02-11.472 17.613-15.233 28.297l137.866 57.444c1.29-35.483-7.338-63.638-20.734-82.76-13.84-19.758-32.403-29.898-51.598-29.898zm-71.422 108c3.352 30.315 17.906 56.833 38.366 70.74l4.677 3.176L62.23 309.137l99.247 19.83-17.54-117.656a81.96 81.96 0 0 0 10.15-8.34zm300.895 57.03c-50.015 39.164-126.724 78.674-165.047 43.546 11.574 23.1 24.986 42.545 51.31 38.317 37.69-6.055 92.397-52.364 113.737-81.863zM59.572 326.962l-2.035 13.65L494 430.653v-16.888zm-4.7 31.513l-2.038 13.687L494 489.967v-17.55zm-4.71 31.605l-15.055 100.98H185.64l-10.06-67.49z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
