// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiSteam : ComponentBase
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
		builder.AddAttribute(14, "d", "M226.15 23.207c-80.605-.39-127.583 43.189-129.207 77.09 33.444-3.521 82.187-2.553 87.068 38.68-23.032-21.249-54.896-21.775-84.396-17.952-130.23 16.878-73.97 200.73 30.488 163.58 8.433 18.916 15.168 69.646 53.36 72.938 37 3.19 36.031 26.349 41.771 70.064 4.752 36.193 60.779 56.268 87.462 61.189 0 0-46.53-79.949-12.347-115.482 88.652-121.077-27.22-185.252-97.254-165.072-47.65 13.73-35.887 42.675-4.389 73.926-45.518-16.55-49.993-37.885-48.692-59.605 2.103-35.092 68.267-61.61 111.12-52.377 108.005 23.27 133.107 102.151 63.987 199.353 70.597 27.995 161.623-6.968 162.912-64.653.804-35.98-21.452-65.04-51.446-74.652-27.22-7.232-38.96 5.289-48.2 23.711-2.666-20.154 17.639-54.573 43.47-37.295C443.959 106.856 404.186 24.068 226.15 23.207z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
