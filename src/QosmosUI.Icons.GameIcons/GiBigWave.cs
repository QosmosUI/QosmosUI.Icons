// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiBigWave : ComponentBase
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
		builder.AddAttribute(14, "d", "M319.406 75.156c-50.542.49-104.39 20.876-150.094 72.844-10.232 9.65-19.88 19.59-29.187 29.313-20.516 21.433-39.694 41.877-60.22 56.468-18.484 13.142-37.73 21.617-61 22.75v89.876c53.93-32.793 59.934-67.832 115.595-136.312 6.38-6.524 12.727-13.19 19.125-19.875 9.96-10.407 20.016-20.803 30.563-30.657 46.422-36.83 92.022-27.93 107.218 2.5 4.6-49.27 57.958-30.564 66.813 18.875 6.91-33.696 20.327-44.354 34.03-31.625-28.136 49.585-26.61 110.87-8.406 164.937 20.51 60.915 61.743 114.13 110.344 133.75v-20.563c-38.34-19.194-74.662-65.71-92.657-119.156-15.937-47.336-17.777-99.07 2.75-141.655 8.492 16.92 16.342 43.406 21.94 79.53 17.992-84.587 54.762-72.463 56.624-10.593 42.998-66.287-52.197-161.48-163.438-160.406zm-35.656 95.78C194.225 181.69 66.158 359.648 43.625 494.97h91.25c1.02-133.954 71.114-282.045 148.875-324.033zm32.406 13.69c-76.76 49.056-114.574 208.732-109.812 310.343h78.437c-41.213-80.74-23.207-252.666 31.376-310.345zm21.875 26.218c-34.686 82.23-25.705 191.077 25.158 284.125h78c-75.605-53.774-120.09-190.455-103.157-284.126z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
