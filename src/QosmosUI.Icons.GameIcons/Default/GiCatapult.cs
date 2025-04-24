// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiCatapult : ComponentBase
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
		builder.AddAttribute(14, "d", "M197.746 30.38l-9.898 30.905-40.485 18.194-28.79 28.055 30.855 35.512 47.486-4.596 36.06 8.35 30.83-33.52-4.263-56.7-61.794-26.2zM25.902 133.32c-13.472 25.957-6.665 67.412 30.356 96.746 37.04 29.35 78.807 26.396 100.855 7.223L25.903 133.32zm359.174 68.99l-34.152 11.38 7.217 21.65-227.6 147.94c12.527 4.355 23.416 12.25 31.466 22.484L369.904 270.63l36.303 108.913c16.727.414 31.995 6.866 43.7 17.264l-64.83-194.498zM171.484 248.67c-9.358 9.058-21.296 15.425-34.656 18.715l63.496 49.064L232.3 295.67l-60.816-46.996zM292.66 342.31l-31.976 20.784L317.504 407h32.183c3.296-4.39 7.104-8.377 11.336-11.865L292.66 342.31zM108.166 397.5c-27.997 0-50.5 22.503-50.5 50.5s22.503 50.5 50.5 50.5 50.5-22.503 50.5-50.5-22.503-50.5-50.5-50.5zm296.334 0c-27.997 0-50.5 22.503-50.5 50.5s22.503 50.5 50.5 50.5S455 475.997 455 448s-22.503-50.5-50.5-50.5zM25 425v46h18.66c-2.58-7.196-3.994-14.937-3.994-23s1.415-15.804 3.994-23H25zm147.672 0c2.58 7.196 3.994 14.937 3.994 23s-1.415 15.804-3.994 23h167.322c-2.58-7.196-3.994-14.937-3.994-23s1.415-15.804 3.994-23H172.672zm296.334 0c2.58 7.196 3.994 14.937 3.994 23s-1.415 15.804-3.994 23H487v-46h-17.994zm-360.84 3.166A19.833 19.833 0 0 1 128 448a19.833 19.833 0 0 1-19.834 19.834A19.833 19.833 0 0 1 88.334 448a19.833 19.833 0 0 1 19.832-19.834zm296.334 0A19.833 19.833 0 0 1 424.334 448a19.833 19.833 0 0 1-19.834 19.834A19.833 19.833 0 0 1 384.666 448a19.833 19.833 0 0 1 19.834-19.834z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
