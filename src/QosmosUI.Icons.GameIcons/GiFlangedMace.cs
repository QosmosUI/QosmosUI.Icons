// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiFlangedMace : ComponentBase
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
		builder.AddAttribute(14, "d", "M487.666 24.334c-24.62 11.186-45.546 18.608-63.14 21.9l41.24 41.24c3.292-17.594 10.714-38.52 21.9-63.14zm-86.082 24.414c-32.088 11.49-60.035 12.74-84.406 4.617l-9.674-3.222-1.998 9.996c-10.117 50.582-18.887 83.28-36.71 121.694l61.37 61.37c38.413-17.823 71.112-26.593 121.695-36.71l9.997-1.998-3.222-9.674c-8.124-24.37-6.873-52.318 4.617-84.406zm2.025 18.148c-13.847 11.685-29.848 19.95-55.34 19.95h-5.56l-2.487 4.974c-18.768 37.536-37.835 74.907-55.494 98.27 17.45-37.59 26.875-71.046 36.4-117.088 25.205 6.06 52.813 3.84 82.48-6.106zm7.902 16.276L303.65 194.957c17.364-24.354 33.734-57.204 50.276-90.32 24.903-1.193 42.88-10.125 57.586-21.465zm17.316 17.316c-11.34 14.707-20.272 32.683-21.465 57.586-33.116 16.542-65.966 32.912-90.32 50.276zm16.276 7.903c-9.945 29.667-12.166 57.275-6.106 82.48-46.042 9.525-79.5 18.95-117.088 36.4 23.363-17.658 60.734-36.725 98.27-55.493l4.974-2.488v-5.56c0-25.492 8.265-41.493 19.95-55.34zm-192.292 82.915l-12.728 12.728 67.883 67.883 12.728-12.728-7.67-7.67-52.543-52.543zm-6.363 41.718l-43.843 43.842 32.528 32.528 43.842-43.842zm-67.884 45.256l-12.728 12.728 55.154 55.154 12.73-12.728zm-14.142 36.77l-41.012 41.01 32.527 32.528 41.01-41.012zM99.37 357.474l-12.727 12.728 55.154 55.154 12.728-12.728zm-14.14 36.77L18 461.472V494h32.527l67.23-67.23z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
