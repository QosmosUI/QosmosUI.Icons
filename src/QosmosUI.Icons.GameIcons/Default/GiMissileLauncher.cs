// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiMissileLauncher : ComponentBase
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
		builder.AddAttribute(14, "d", "M490.74 21.411c-8.947.782-20.72 3.22-33.566 7.781-16.386 5.82-34.345 14.758-50.969 25.893l26.783 36.525c15.712-12.52 29.853-26.925 40.428-40.757 8.265-10.811 14.055-21.243 17.324-29.442zm-99.265 44.026L57.609 310.24l8.28 11.291 83.062-60.906 10.643 14.516-83.063 60.906 8.28 11.29 333.865-244.806zm-18.252 92.746L203.164 282.876l13.924 7.15L375.855 173.61zm-48.602 75.316l-35.775 26.234c3.899 3.046 8.821 4.856 14.213 4.856 12.809 0 23-10.191 23-23 0-2.855-.51-5.579-1.438-8.09zm-255.267 7.527L21.26 260.67l25.705 35.057 65.54-48.057zm226.705 40.948v30.615h14v-30.615a40.734 40.734 0 0 1-7 .615c-2.386 0-4.723-.219-7-.615zm-135.065 31.822l-65.54 48.058 25.706 35.06 33.194-39.964zm-117.9 7.09l-11.291 8.279 27.2 37.096 11.29-8.28zm236.965 9.703v78h46v-78zm-18 54.336l-61.426 71.664h23.709l37.717-44.004zm82 0v27.66l37.716 44.004h23.71zm-192 89.664v16h94v-16zm208 0v16h94v-16z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
